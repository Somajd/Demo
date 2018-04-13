using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemoXML
{
    public class amazonVPC    {
        public string name { get; internal set; }
        public string cidr_block { get; internal set; }
        public string enable_dns_support { get; internal set; }
        public string enable_dns_hostnames { get; internal set; }
        public string region { get; internal set; }
        public string description { get; internal set; }
        public List<amazonProp> props { get; set; }
        public List<amazonTag> tags { get; set; }


        public override string ToString()
        {
            string tfVPC;

            tfVPC = "#" + description + "\r\n";
            tfVPC += "resource \"aws_vpc\" \"" + name + "\" {\r\n";
            tfVPC += "\tcidr_block = \"" + cidr_block + "\"\r\n";
            tfVPC += "\tenable_dns_support = " + enable_dns_support + "\r\n";
            tfVPC += "\tenable_dns_hostnames = " + enable_dns_hostnames + "\r\n";

            if (props != null)
            {
                foreach (amazonProp pr in props)
                {
                    tfVPC += "\t" + pr.propname + " = \"" + pr.propvalue + "\"\r\n";
                }
            }
            if (tags != null)
            {
                tfVPC += "\ttags {\r\n";
                foreach (amazonTag tg in tags)
                {
                    tfVPC += "\t\t" + tg.tagname + " = \"" + tg.tagvalue + "\" \r\n";
                }


                tfVPC += "\t}\r\n";
            }
            tfVPC += "}\r\n";
            //return base.ToString() + tfVPC;
            return tfVPC;
        }

    }

    public class amazonSubnet
    {
        public string vpc_id { get; set; }
        public string name { get; set; }
        public string cidr_block { get; set; }
        public string map_public_ip_on_launch { get; set; }
        public string description { get; internal set; }
        public List<amazonProp> props { get; set; }
        public List<amazonTag> tags { get; set; }


        public override string ToString()
        {
            string tfSubnet;

            tfSubnet = "#" + description + "\r\n";
            tfSubnet += "resource \"aws_subnet\" \"" + name + "\" {\r\n";
            tfSubnet += "\tvpc_id = \"${aws_vpc." + vpc_id + ".id}\"\r\n";
            tfSubnet += "\tcidr_block = \"" + cidr_block + "\"\r\n";
            tfSubnet += "\tmap_public_ip_on_launch = " + map_public_ip_on_launch + "\r\n";
            

            if (props != null)
            {
                foreach (amazonProp pr in props)
                {
                    tfSubnet += "\t" + pr.propname + " = \"" + pr.propvalue + "\"\r\n";
                }
            }

            if (tags != null)
            {
                tfSubnet += "\ttags {\r\n";
                foreach (amazonTag tg in tags)
                {
                    tfSubnet += "\t\t" + tg.tagname + " = \"" + tg.tagvalue + "\" \r\n";
                }

                tfSubnet += "\t}\r\n";
            }
            tfSubnet += "}\r\n";
            //return base.ToString() + tfVPC;
            return tfSubnet;
        }

    }

    public class amazonIngress
    {
        public string from_port { get; set; }
        public string to_port { get; set; }
        public string protocol { get; set; }
        public string cidr_block { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            string tIngress;

            tIngress = "\n\t#" + description + "\r\n";
            tIngress += "\tingress {\r\n";
            tIngress += "\t\tfrom_port = " + from_port + "\r\n";
            tIngress += "\t\tto_port = " + to_port + "\r\n";
            tIngress += "\t\tprotocol = \"" + protocol + "\"\r\n";
            tIngress += "\t\tcidr_blocks = [\"" + cidr_block + "\"]\r\n";
            tIngress += "\t}\n";

            return tIngress;

        }
    }

    public class amazonEngress
    {
        public string from_port { get; set; }
        public string to_port { get; set; }
        public string protocol { get; set; }
        public string cidr_block { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            string tEgress;

            tEgress = "\n\t#" + description + "\r\n";
            tEgress += "\tegress {\r\n";
            tEgress += "\t\tfrom_port = " + from_port + "\r\n";
            tEgress += "\t\tto_port = " + to_port + "\r\n";
            tEgress += "\t\tprotocol = \"" + protocol + "\"\r\n";
            tEgress += "\t\tcidr_blocks = [\"" + cidr_block + "\"]\r\n";
            tEgress += "\t}\n";

            return tEgress;

        }
    }


    public class amazonSecurityGrp
    {
        public string name { get; set; }
        public string description { get; set; }
        public string vpc_id { get; set; }

        public List<amazonEngress> egressRules;
        public List<amazonIngress> ingressRules;

        public override string ToString()
        {
            
            string tSecGrp;

            tSecGrp = "#" + description + "\r\n";
            tSecGrp += "resource \"aws_security_group\" \"" + name +"\"  {\r\n";
            tSecGrp += "\tname = \"" + name + "\"\r\n";
            tSecGrp += "\tdescription = \"" + description + "\"\r\n";
            tSecGrp += "\tvpc_id = \"${aws_vpc." + vpc_id + ".id}\"\r\n";
           
            foreach (amazonEngress awseg in egressRules)
            {
                tSecGrp += awseg.ToString().Replace("<br>","").ToString();
            }
            foreach (amazonIngress awsing in ingressRules)
            {
                tSecGrp += awsing.ToString().Replace("<br>","").ToString();
            }


            tSecGrp += "}\r\n";

            return tSecGrp;
        }
    }


    public class amazonInternetGateway
    {
        public string vpc_id { get; set; }
        public string name { get; set; }
        public string destination_cidr_block { get; set; }
        public string route_table_id { get; set; }
        public string route_name { get; set; }
        public string description { get; internal set; }
        public string gateway_id { get; internal set; }
        public List<amazonProp> props { get; set; }
        public List<amazonTag> tags { get; set; }



        public override string ToString()
        {
            string tfIGW;

            tfIGW = "#" + description + "\r\n";
            tfIGW += "resource \"aws_internet_gateway\" \"" + name + "\" {\r\n";
            tfIGW += "\tvpc_id = \"${aws_vpc." + vpc_id + ".id}\"\r\n";
            tfIGW += "\t} \n\n";

            tfIGW += "#" + description + " - Main Route Table\r\n";
            tfIGW += "resource \"aws_route\" \"" + route_name + "\" {\r\n";
            tfIGW += "\troute_table_id = \"${aws_vpc." + vpc_id + ".main_route_table_id}\"\r\n";
            tfIGW += "\tdestination_cidr_block = \"" + destination_cidr_block + "\"\r\n";
            tfIGW += "\tgateway_id =\"${aws_internet_gateway." + name + ".id}\"\r\n";

            if (props != null)
            {
                foreach (amazonProp pr in props)
                {
                    tfIGW += "\t" + pr.propname + " = \"" + pr.propvalue + "\"\r\n";
                }
            }

            if (tags != null)
            {
                tfIGW += "\ttags {\r\n";
                foreach (amazonTag tg in tags)
                {
                    tfIGW += "\t\t" + tg.tagname + " = \"" + tg.tagvalue + "\" \r\n";
                }

                tfIGW += "\t}\r\n";
            }
            tfIGW += "}\r\n";

            //return base.ToString() + tfVPC;
            return tfIGW;
        }

    }


    public class amazonTag
    {
        public string tagname { get; set; }
        public string tagvalue { get; set; }
    }
    public class amazonProp
    {
        public string propname { get; set; }
        public string propvalue { get; set; }
    }

    public class amazonInstance
    {
        public string instance_type { get; set; }
        public string name { get; set; }
        public string ami { get; set; }
        public string key_name { get; set; }
        public string vpc_security_group_ids { get; set; }
        public string description { get; internal set; }
        public string subnet_id { get; internal set; }
        public List<amazonProp> props { get; set; }
        public List<amazonTag> tags { get; set; }


        public override string ToString()
        {
            string tfInstance;

            tfInstance = "#" + description + "\r\n";
            tfInstance += "resource \"aws_instance\" \"" + name + "\" {\r\n";
            tfInstance += "\tami = \"" + ami + "\"\r\n";
            tfInstance += "\tinstance_type = \"" + instance_type + "\"\r\n";
            tfInstance += "\tkey_name = \"" + key_name + "\"\r\n";
            tfInstance += "\tvpc_security_group_ids = [\"" + vpc_security_group_ids + "\"]\r\n";
            tfInstance += "\tsubnet_id = \"" + subnet_id + "\"\r\n";

            if (props != null)
            {
                foreach (amazonProp pr in props)
                {
                    tfInstance += "\t" + pr.propname + " = \"" + pr.propvalue + "\"\r\n";
                }
            }

            if (tags != null)
            {
                tfInstance += "\ttags {\r\n";
                foreach (amazonTag tg in tags)
                {
                    tfInstance += "\t\t" + tg.tagname + " = \"" + tg.tagvalue + "\" \r\n";
                }

                tfInstance += "\t} \n}\n";
            }            
            return tfInstance;
        }

    }



    public static class HTMLHelper
    {
    public static DataSet ConvertHTMLTablesToDataSet(string HTML)
    {
        // Declarations 
        DataSet ds = new DataSet();
        DataTable dt = null;
        DataRow dr = null;
        //DataColumn dc = null;
        string TableExpression = "<table[^>]*>(.*?)</table>";
        string HeaderExpression = "<th[^>]*>(.*?)</th>";
        string RowExpression = "<tr[^>]*>(.*?)</tr>";
        string ColumnExpression = "<td[^>]*>(.*?)</td>";
        bool HeadersExist = false;
        int iCurrentColumn = 0;
        int iCurrentRow = 0;

            // Get a match for all the tables in the HTML  
            MatchCollection Tables = Regex.Matches(HTML, TableExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);
            // Loop through each table element  
            foreach (Match Table in Tables)
            {
                // Reset the current row counter and the header flag  
                iCurrentRow = 0;
                HeadersExist = false;
                // Add a new table to the DataSet  
                dt = new DataTable();
                //Create the relevant amount of columns for this table (use the headers if they exist, otherwise use default names)  
                 if (Table.Value.Contains("<th"))  
                //if (Table.Value.Contains("<TH"))
                {
                    // Set the HeadersExist flag  
                    HeadersExist = true;
                    // Get a match for all the rows in the table  
                    MatchCollection Headers = Regex.Matches(Table.Value, HeaderExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    // Loop through each header element  
                    foreach (Match Header in Headers)
                    {
                        dt.Columns.Add(Header.Groups[1].ToString());
                    }
                }
                else
                {
                    for (int iColumns = 1; iColumns <= Regex.Matches(Regex.Matches(Regex.Matches(Table.Value, TableExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase)[0].ToString(), RowExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase)[0].ToString(), ColumnExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase).Count; iColumns++)
                    {
                        dt.Columns.Add("Column " + iColumns);
                    }
                }
                //Get a match for all the rows in the table  
                MatchCollection Rows = Regex.Matches(Table.Value, RowExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);
                // Loop through each row element  
                foreach (Match Row in Rows)
                {
                    // Only loop through the row if it isn't a header row  
                    if (!(iCurrentRow == 0 && HeadersExist))
                    {
                        // Create a new row and reset the current column counter  
                        dr = dt.NewRow();
                        iCurrentColumn = 0;
                        // Get a match for all the columns in the row  
                        MatchCollection Columns = Regex.Matches(Row.Value, ColumnExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);
                        // Loop through each column element  
                        foreach (Match Column in Columns)
                        {
                            // Add the value to the DataRow  
                            dr[iCurrentColumn] = Column.Groups[1].ToString();
                            // Increase the current column  
                            iCurrentColumn++;
                        }
                        // Add the DataRow to the DataTable  
                        dt.Rows.Add(dr);
                    }
                    // Increase the current row counter  
                    iCurrentRow++;
                }
                // Add the DataTable to the DataSet  
                ds.Tables.Add(dt);
            }
            return ds;

        }



    
    public static KeyValuePair<object, object> Cast<K, V>(this KeyValuePair<K, V> kvp)
    {
        return new KeyValuePair<object, object>(kvp.Key, kvp.Value);
    }

    public static KeyValuePair<T, V> CastFrom<T, V>(Object obj)
    {
        return (KeyValuePair<T, V>)obj;
    }

    public static KeyValuePair<object, object> CastFrom(Object obj)
    {
        var type = obj.GetType();
        if (type.IsGenericType)
        {
            if (type == typeof(KeyValuePair<,>))
            {
                var key = type.GetProperty("Key");
                var value = type.GetProperty("Value");
                var keyObj = key.GetValue(obj, null);
                var valueObj = value.GetValue(obj, null);
                return new KeyValuePair<object, object>(keyObj, valueObj);
            }
        }
        throw new ArgumentException(" ### -> public static KeyValuePair<object , object > CastFrom(Object obj) : Error : obj argument must be KeyValuePair<,>");
    }
    }
}

