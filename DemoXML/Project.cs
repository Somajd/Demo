using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoXML
{
    class Project
    {
        public string ProjectName { get; set; }
        public string ProjectFilename { get; set; }
        public string DiagramFilename { get; set; }
        public string AWSAccount { get; set; }
        public string AWSAccessKey { get; set; }
        public string AWSSecretKey { get; set; }
        public string OutputFolder { get; set; }
        public string VariableFilename { get; set; }




        public IDictionary<string, string> TFVariables { get; set; }

        public bool LoadProject (string Filename)
        {
            ProjectFilename = Filename;
            XDocument xdoc = XDocument.Load(Filename);

            xdoc.Descendants("Project")
             .Select(p => new
             {   name = p.Attribute("name").Value,
                 diagramname = p.Attribute("diagramname").Value,
                 outputfolder = p.Attribute("outputfolder").Value,
                 variablefilename = p.Attribute("variablefilename").Value,
             }).ToList().ForEach(p => {
                 ProjectName = p.name;
                 DiagramFilename = p.diagramname;
                 OutputFolder = p.outputfolder;
                 VariableFilename = p.variablefilename;
             });

            xdoc.Descendants("AWSParameter")
            .Select(p => new
            {
                account = p.Attribute("account").Value,
                accesskey = p.Attribute("accesskey").Value,
                secretkey = p.Attribute("secretkey").Value,
            }).ToList().ForEach(p => {
                AWSAccount = p.account;
                AWSAccessKey = p.accesskey;
                AWSSecretKey = p.secretkey;
            });

            Dictionary<string, string> vars = new Dictionary<string, string>();
             xdoc.Descendants("Variable")
             .Select(p => new
             {
                 keyname = p.Attribute("name").Value,
                 keyvalue = p.Attribute("value").Value,
                 
             }).ToList().ForEach(p => 
             {
                vars.Add(p.keyname, p.keyvalue);
             });

            TFVariables = vars;
            return true;
        }

        public bool SaveAsProject(string Filename)
        {
            GlobalVars.ProjectFilename = Filename;
            return SaveProject();
        }
        public bool SaveProject()
        {
            if(File.Exists(this.ProjectFilename))
            {
                DateTime dt = DateTime.Now;
                string suffix = dt.ToString("YYYYMMDD-hhmmss") + ".bkup";
                File.Copy(GlobalVars.ProjectFilename, GlobalVars.ProjectFilename + suffix);
            }

            string Filename = this.ProjectFilename;

            XDocument data = XDocument.Load(Filename);

            XElement awsParam =  new XElement("AWSParameter");
            awsParam.SetAttributeValue("accesskey", this.AWSAccessKey);
            awsParam.SetAttributeValue("secretkey", this.AWSSecretKey);
            awsParam.SetAttributeValue("account", this.AWSAccount);
            

            XElement tfVars = new XElement("TFVariables");

            foreach ( KeyValuePair<string, string> itm in this.TFVariables)
            {
                XElement tfVar = new XElement("Variable");
                tfVar.SetAttributeValue("name", itm.Key);
                tfVar.SetAttributeValue("value", itm.Value);

                tfVars.Add(tfVar);
            }

            data.Element("Project").Element("AWSParameter").ReplaceWith(awsParam);
            data.Element("Project").Element("TFVariables").ReplaceWith(tfVars);

            data.Element("Project").SetAttributeValue("name", this.ProjectName);
            data.Element("Project").SetAttributeValue("diagramname", this.DiagramFilename);
            data.Element("Project").SetAttributeValue("outputfolder", this.OutputFolder);
            data.Element("Project").SetAttributeValue("variablefilename", this.VariableFilename);


            data.Save(Filename);
            return true;
        }

        public string GetTFVariables()
        {
            string outputText ="";

            outputText = "aws_access_key = \"" + this.AWSAccessKey.Trim() + "\"\r\n";
            outputText += "aws_secret_key = \"" + this.AWSSecretKey.Trim() + "\"\r\n";
            
            foreach (KeyValuePair<string, string> itm in this.TFVariables)
            {
                outputText += itm.Key + " = \"" + itm.Value.Replace('\\','/').Trim() + "\"\r\n";
            }

                return outputText;
        }

        public string GetTFVariableDef()
        {
            string outputText = "";

            outputText = "variable \"aws_access_key\" {}\r\n";
            outputText += "variable \"aws_secret_key\" {}\r\n";

            foreach (KeyValuePair<string, string> itm in this.TFVariables)
            {
                outputText += "variable \""+itm.Key + "\" {}\r\n";
            }

            return outputText;
        }
        
    }
}