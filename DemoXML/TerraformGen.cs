using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace DemoXML
{
    class TerraformGen
    {
        public bool LoadVPC(string path, List<amazonVPC> vpcList)
        {
            /*XDocument xdoc = XDocument.Load(path);

            xdoc.Descendants("object").Where(x => x.Attribute("tftype").ToString().Contains("awsVPC"))
             .Select(p => new
             {
                 id = p.Attribute("id").Value,
                 type = p.Attribute("tftype").Value,
                 name = p.Attribute("Name").Value,
                 cidrblock = p.Attribute("cidr_block").Value,
                 region = p.Attribute("Region").Value,
                 enableDnsSupport = p.Attribute("enable_dns_support").Value,
                 enableDnsHostname = p.Attribute("enable_dns_hostnames").Value,
                 description = p.Attribute("label").Value


             }).ToList().ForEach(p =>
             {

                 if (p.type == "awsVPC")
                 {
                     amazonVPC awsVPC = new amazonVPC();
                     awsVPC.name = p.name;
                     awsVPC.cidr_block = p.cidrblock;
                     awsVPC.region = p.region;
                     awsVPC.enable_dns_support = p.enableDnsSupport;
                     awsVPC.enable_dns_hostnames = p.enableDnsHostname;
                     awsVPC.description = p.description;

                     vpcList.Add(awsVPC);
                 }

             }); */

            var tlinq = XDocument.Load(path);
            var iList = tlinq.Descendants("object").Where(x => x.Attribute("tftype").ToString().Contains("awsVPC"))
                               .Select(x => x.Attributes().ToDictionary(y => y.Name, y => y.Value)
                               ).ToList();


            foreach (var ins in iList)
            {
                amazonVPC awsVPC = new amazonVPC();
                List<amazonProp> awsProp = new List<amazonProp>();
                List<amazonTag> awsTag = new List<amazonTag>();


                if (typeof(IDictionary).IsAssignableFrom(ins.GetType()))
                {
                    foreach (var attrib in ins)
                    {
                        string attribValue = attrib.Value.Trim().ToString();
                        switch (attrib.Key.ToString())
                        {
                            case "name":
                                awsVPC.name = attribValue;
                                break;
                            case "cidr_block":
                                awsVPC.cidr_block = attribValue;
                                break;
                            case "region":
                                awsVPC.region = attribValue;
                                break;
                            case "description":
                                awsVPC.description = attribValue;
                                break;
                            case "enable_dns_support":
                                awsVPC.enable_dns_support = attribValue;
                                break;

                            case "enable_dns_hostnames":
                                awsVPC.enable_dns_hostnames = attribValue;
                                break;
                                                            
                            case "id":
                            case "label":
                            case "placeholders":
                            case "tftype":
                                break;

                            case "props":
                                if (attribValue.Contains(";") || attribValue.Contains("="))
                                {
                                    List<string> Props = attribValue.Split(';').ToList();

                                    foreach (string pr in Props)
                                    {
                                        amazonProp p1 = new amazonProp();

                                        string[] nv = pr.Split('=');
                                        p1.propname = nv[0].ToString();
                                        p1.propvalue = nv[1].ToString();

                                        awsProp.Add(p1);
                                    }
                                    awsVPC.props = awsProp;
                                }
                                break;

                            case "tags":
                                if (attribValue.Contains(";") || attribValue.Contains("="))
                                {
                                    List<string> Tags = attribValue.Split(';').ToList();

                                    foreach (string tg in Tags)
                                    {

                                        amazonTag t = new amazonTag();

                                        string[] nv = tg.Split('=');
                                        t.tagname = nv[0].ToString();
                                        t.tagvalue = nv[1].ToString();

                                        awsTag.Add(t);

                                    }
                                    awsVPC.tags = awsTag;
                                }
                                break;

                            default:

                                amazonProp p = new amazonProp();
                                p.propname = attrib.Key.ToString();
                                p.propvalue = attribValue;

                                awsProp.Add(p);

                                awsVPC.props = awsProp;

                                break;
                        }
                    }

                }

                vpcList.Add(awsVPC);
            }

            return true;
        }

        public bool LoadSubnet(string path, List<amazonSubnet> subnetList)
        {
            

            var tlinq = XDocument.Load(path);
            var iList = tlinq.Descendants("object").Where(x => x.Attribute("tftype").ToString().Contains("awsSubnet"))
                               .Select(x => x.Attributes().ToDictionary(y => y.Name, y => y.Value)
                               ).ToList();


            foreach (var ins in iList)
            {
                amazonSubnet awsSN = new amazonSubnet();
                List<amazonProp> awsProp = new List<amazonProp>();
                List<amazonTag> awsTag = new List<amazonTag>();


                if (typeof(IDictionary).IsAssignableFrom(ins.GetType()))
                {
                    foreach (var attrib in ins)
                    {
                        string attribValue = attrib.Value.Trim().ToString();
                        switch (attrib.Key.ToString())
                        {
                            case "name":
                                awsSN.name = attribValue;
                                break;
                            case "cidr_block":
                                awsSN.cidr_block = attribValue;
                                break;
                            case "vpc_id":
                                awsSN.vpc_id = attribValue;
                                break;
                            case "description":
                                awsSN.description = attribValue;
                                break;
                            case "map_public_ip_on_launch":
                                awsSN.map_public_ip_on_launch = attribValue;
                                break;

                            case "id":
                            case "label":
                            case "placeholders":
                            case "tftype":
                                break;

                            case "props":
                                if (attribValue.Contains(";") || attribValue.Contains("="))
                                {
                                    List<string> Props = attribValue.Split(';').ToList();

                                    foreach (string pr in Props)
                                    {
                                        amazonProp p1 = new amazonProp();

                                        string[] nv = pr.Split('=');
                                        p1.propname = nv[0].ToString();
                                        p1.propvalue = nv[1].ToString();

                                        awsProp.Add(p1);
                                    }
                                    awsSN.props = awsProp;
                                }
                                break;

                            case "tags":
                                if (attribValue.Contains(";") || attribValue.Contains("="))
                                {
                                    List<string> Tags = attribValue.Split(';').ToList();

                                    foreach (string tg in Tags)
                                    {

                                        amazonTag t = new amazonTag();

                                        string[] nv = tg.Split('=');
                                        t.tagname = nv[0].ToString();
                                        t.tagvalue = nv[1].ToString();

                                        awsTag.Add(t);

                                    }
                                    awsSN.tags = awsTag;
                                }
                                break;

                            default:

                                amazonProp p = new amazonProp();
                                p.propname = attrib.Key.ToString();
                                p.propvalue = attribValue;

                                awsProp.Add(p);

                                awsSN.props = awsProp;

                                break;
                        }
                    }

                }

                subnetList.Add(awsSN);
            }


            return true;
        }

        public bool LoadSecurityGroup(string path, List<amazonSecurityGrp> sgList)
        {
            XDocument xdoc = XDocument.Load(path);

            xdoc.Descendants("object").Where(x => x.Attribute("tftype").ToString().Contains("aws_security_group"))
             .Select(p => new
             {
                 id = p.Attribute("id").Value,
                 type = p.Attribute("tftype").Value,
                 name = p.Attribute("name").Value,
                 vpc_id = p.Attribute("vpc_id").Value,
                 description = p.Attribute("description").Value,
                 rules = HttpUtility.HtmlDecode(p.Attribute("label").Value)

             }).ToList().ForEach(p =>
             {

                 if (p.type == "aws_security_group")
                 {
                     amazonSecurityGrp awsSecGrp = new amazonSecurityGrp();
                     awsSecGrp.name = p.name;
                     awsSecGrp.vpc_id = p.vpc_id;
                     awsSecGrp.description = p.description;
                     awsSecGrp.ingressRules = new List<amazonIngress>();
                     awsSecGrp.egressRules = new List<amazonEngress>();


                     DataSet ds = new DataSet();

                     ds = HTMLHelper.ConvertHTMLTablesToDataSet(p.rules);

                     foreach (DataTable dt in ds.Tables)
                     {
                         foreach (DataRow dr in dt.Rows)
                         {
                             if (dr["type"].ToString().Contains("egress"))
                             {
                                 amazonEngress awsEg = new amazonEngress();
                                 awsEg.from_port = dr["from_port"].ToString();
                                 awsEg.to_port = dr["to_port"].ToString();
                                 awsEg.protocol = dr["protocol"].ToString();
                                 awsEg.cidr_block = dr["cidr_blocks"].ToString();
                                 awsSecGrp.egressRules.Add(awsEg);
                             }
                             else if (dr["type"].ToString().Contains("ingress"))
                             {
                                 amazonIngress awsIg = new amazonIngress();
                                 awsIg.from_port = dr["from_port"].ToString();
                                 awsIg.to_port = dr["to_port"].ToString();
                                 awsIg.protocol = dr["protocol"].ToString();
                                 awsIg.cidr_block = dr["cidr_blocks"].ToString();
                                 awsSecGrp.ingressRules.Add(awsIg);
                             }
                         }

                     }



                     sgList.Add(awsSecGrp);
                 }

             }); 



            return true;
        }

        public bool LoadInternetGateway(string path, List<amazonInternetGateway> igwList)
        {
            /*XDocument xdoc = XDocument.Load(path);

            xdoc.Descendants("object").Where(x => x.Attribute("tftype").ToString().Contains("aws_internet_gateway"))
             .Select(p => new
             {
                 id = p.Attribute("id").Value,
                 type = p.Attribute("tftype").Value,
                 name = p.Attribute("name").Value,
                 vpc_id = p.Attribute("vpc_id").Value,
                 description = p.Attribute("description").Value,
                 routename = p.Attribute("route_name").Value,
                 route_table_id = p.Attribute("route_table_id").Value,
                 destination_cidr_block = p.Attribute("destination_cidr_block").Value,
                 gateway_id = p.Attribute("gateway_id").Value

             }).ToList().ForEach(p =>
             {

                 if (p.type == "aws_internet_gateway")
                 {
                     amazonInternetGateway awsIGW = new amazonInternetGateway();
                     awsIGW.name = p.name;
                     awsIGW.vpc_id = p.vpc_id;
                     awsIGW.description = p.description;
                     awsIGW.route_name = p.routename;
                     awsIGW.route_table_id = p.route_table_id;
                     awsIGW.destination_cidr_block = p.destination_cidr_block;
                     awsIGW.gateway_id = p.gateway_id;

                     igwList.Add(awsIGW);
                 }

             });*/

             var tlinq = XDocument.Load(path);
            var iList = tlinq.Descendants("object").Where(x => x.Attribute("tftype").ToString().Contains("aws_internet_gateway"))
                               .Select(x => x.Attributes().ToDictionary(y => y.Name, y => y.Value)
                               ).ToList();


            foreach (var ins in iList)
            {
                amazonInternetGateway awsIGW = new amazonInternetGateway();
                List<amazonProp> awsProp = new List<amazonProp>();
                List<amazonTag> awsTag = new List<amazonTag>();


                if (typeof(IDictionary).IsAssignableFrom(ins.GetType()))
                {
                    foreach (var attrib in ins)
                    {
                        string attribValue = attrib.Value.Trim().ToString();
                        switch (attrib.Key.ToString())
                        {
                            case "name":
                                awsIGW.name = attribValue;
                                break;
                            case "vpc_id":
                                awsIGW.vpc_id = attribValue;
                                break;
                            case "route_name":
                                awsIGW.route_name = attribValue;
                                break;
                            case "description":
                                awsIGW.description = attribValue;
                                break;
                            case "route_table_id":
                                awsIGW.route_table_id = attribValue;
                                break;

                            case "destination_cidr_block":
                                awsIGW.destination_cidr_block = attribValue;
                                break;
                            case "gateway_id":
                                awsIGW.gateway_id = attribValue;
                                break;


                            case "id":
                            case "label":
                            case "placeholders":
                            case "tftype":
                                break;

                            case "props":
                                if (attribValue.Contains(";") || attribValue.Contains("="))
                                {
                                    List<string> Props = attribValue.Split(';').ToList();

                                    foreach (string pr in Props)
                                    {
                                        amazonProp p1 = new amazonProp();

                                        string[] nv = pr.Split('=');
                                        p1.propname = nv[0].ToString();
                                        p1.propvalue = nv[1].ToString();

                                        awsProp.Add(p1);
                                    }
                                    awsIGW.props = awsProp;
                                }
                                break;

                            case "tags":
                                if (attribValue.Contains(";") || attribValue.Contains("="))
                                {
                                    List<string> Tags = attribValue.Split(';').ToList();

                                    foreach (string tg in Tags)
                                    {

                                        amazonTag t = new amazonTag();

                                        string[] nv = tg.Split('=');
                                        t.tagname = nv[0].ToString();
                                        t.tagvalue = nv[1].ToString();

                                        awsTag.Add(t);

                                    }
                                    awsIGW.tags = awsTag;
                                }
                                break;

                            default:

                                amazonProp p = new amazonProp();
                                p.propname = attrib.Key.ToString();
                                p.propvalue = attribValue;

                                awsProp.Add(p);

                                awsIGW.props = awsProp;

                                break;
                        }
                    }

                }

                igwList.Add(awsIGW);
            }

            return true;
        }

        public bool LoadInstance(string path, List<amazonInstance> instList)
        {


            var tlinq = XDocument.Load(path);
            var iList = tlinq.Descendants("object").Where(x => x.Attribute("tftype").ToString().Contains("aws_instance"))
                               .Select(x => x.Attributes().ToDictionary(y => y.Name, y => y.Value)
                               ).ToList();


            foreach (var ins in iList)
            {
                amazonInstance awsInst = new amazonInstance();
                List<amazonProp> awsProp = new List<amazonProp>();
                List<amazonTag> awsTag = new List<amazonTag>();


                if (typeof(IDictionary).IsAssignableFrom(ins.GetType()))
                {
                    foreach (var attrib in ins)
                    {
                        string attribValue = attrib.Value.Trim().ToString();
                        switch (attrib.Key.ToString())
                        {
                            case "name":
                                awsInst.name = attribValue;
                                break;
                            case "instance_type":
                                awsInst.instance_type = attribValue;
                                break;
                            case "ami":
                                awsInst.ami = attribValue;
                                break;
                            case "description":
                                awsInst.description = attribValue;
                                break;
                            case "key_name":
                                awsInst.key_name = attribValue;
                                break;

                            case "subnet_id":
                                awsInst.subnet_id = attribValue;
                                break;

                            case "vpc_security_group_ids":
                                awsInst.vpc_security_group_ids = attribValue;
                                break;

                            case "id":
                            case "label":
                            case "placeholders":
                            case "tftype":
                                break;

                            case "props":
                                if (attribValue.Contains(";") || attribValue.Contains("="))
                                {
                                    List<string> Props = attribValue.Split(';').ToList();

                                    foreach (string pr in Props)
                                    {
                                        amazonProp p1 = new amazonProp();

                                        string[] nv = pr.Split('=');
                                        p1.propname = nv[0].ToString();
                                        p1.propvalue = nv[1].ToString();

                                        awsProp.Add(p1);
                                    }
                                    awsInst.props = awsProp;
                                }
                                break;

                            case "tags":
                                if (attribValue.Contains(";") || attribValue.Contains("="))
                                {
                                    List<string> Tags = attribValue.Split(';').ToList();

                                    foreach (string tg in Tags)
                                    {

                                        amazonTag t = new amazonTag();

                                        string[] nv = tg.Split('=');
                                        t.tagname = nv[0].ToString();
                                        t.tagvalue = nv[1].ToString();

                                        awsTag.Add(t);

                                    }
                                    awsInst.tags = awsTag;
                                }
                                break;

                            default:

                                amazonProp p = new amazonProp();
                                p.propname = attrib.Key.ToString();
                                p.propvalue = attribValue;

                                awsProp.Add(p);

                                awsInst.props = awsProp;

                                break;
                        }
                    }

                }

                instList.Add(awsInst);
            }
            return true;
        }

        public bool GenerateTFVars (Project prj, string Outputfile)
        {
            string outputText = "";

            outputText = prj.GetTFVariables();

            File.WriteAllText(Outputfile, outputText);

            return true;
        }
        public bool GenerateTFVarsDef(Project prj, string Outputfile)
        {
            string outputText = "";

            outputText = prj.GetTFVariableDef();

            File.WriteAllText(Outputfile, outputText);

            return true;
        }

        public bool GenerateTerraform(string InputFile, string Outputfile)
        {

            string outputText;

            outputText = GenerateProvider();
            outputText += GenerateVPC(InputFile);
            outputText += GenerateSubnet(InputFile);
            outputText += GenerateSecurityGroup(InputFile);
            outputText += GenerateInternetGateway(InputFile);
            outputText += GenerateInstance(InputFile);

            File.WriteAllText(Outputfile, outputText);

            return true;
       
        }

        private string GenerateProvider()
        {
            string outputTF = "";

            outputTF += "provider \"aws\" { \r\n";
            outputTF += "\taccess_key = \"${ var.aws_access_key}\"\r\n";
            outputTF += "\tsecret_key = \"${ var.aws_secret_key}\"\r\n";
            outputTF += "\tregion = \"${ var.aws_region}\"\r\n";
            outputTF += "}\r\n\r\n";
            return outputTF;

        }

        private string  GenerateVPC(string InputFile)
        {
            TerraformGen tfGen = new TerraformGen();
            string outputTF = "";
            // For Loading VPC
            List<amazonVPC> VPCList = new List<amazonVPC>();

            tfGen.LoadVPC(InputFile, VPCList);

            foreach (amazonVPC aVpc in VPCList)
            {
                outputTF += aVpc.ToString();
            }
            

            return outputTF;
        }

        private string GenerateSubnet(string InputFile)
        {
            TerraformGen tfGen = new TerraformGen();
            string outputTF = "";
            // For Loading Subnets
            List<amazonSubnet> subnetList = new List<amazonSubnet>();

            tfGen.LoadSubnet(InputFile, subnetList);

            foreach (amazonSubnet aSNet in subnetList)
            {
                outputTF += aSNet.ToString();
            }
           

            return outputTF;
        }

        private string GenerateSecurityGroup(string InputFile)
        {
            TerraformGen tfGen = new TerraformGen();
            string outputTF = "";
            // For Loading Security Group
            List<amazonSecurityGrp> secgrpList = new List<amazonSecurityGrp>();

            tfGen.LoadSecurityGroup(InputFile, secgrpList);

            foreach (amazonSecurityGrp aSNet in secgrpList)
            {
                outputTF += aSNet.ToString();
            }

            return outputTF;
        }

        private string GenerateInternetGateway( string InputFile)
        {
            TerraformGen tfGen = new TerraformGen();
            string outputTF = "";
            // For Loading Security Group
            List<amazonInternetGateway> igwList = new List<amazonInternetGateway>();

            tfGen.LoadInternetGateway(InputFile, igwList);

            foreach (amazonInternetGateway igw in igwList)
            {
                outputTF += igw.ToString();
            }
            return outputTF;
        }

        private string GenerateInstance(string InputFile)
        {

            TerraformGen tfGen = new TerraformGen();
            string outputTF = "";
            // For Loading Security Group
            List<amazonInstance> instList = new List<amazonInstance>();

            tfGen.LoadInstance(InputFile, instList);

            foreach (amazonInstance inst in instList)
            {
                outputTF += inst.ToString();
            }
            return outputTF;
        }
    }
    }

