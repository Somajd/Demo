using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoXML
{
    public partial class frmVisualizer : Form
    {
        public frmVisualizer()
        {
            InitializeComponent();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //Load VPC
            LoadTreeWithVPC();

            //Load Subnet
            LoadTreeWithSubnet();


            //Load Instance
            LoadTreeWithInstance();

            //Load Internet Gateway
            LoadTreeWithInternetGateway();

            //Load Instance
            LoadTreeWithSecurityGroup();
        }




        private void LoadTreeWithVPC()
        {
            TerraformGen tfGen = new TerraformGen();

            // For Loading VPC
            List<amazonVPC> VPCList = new List<amazonVPC>();

            tfGen.LoadVPC(GlobalVars.varPrj.DiagramFilename, VPCList);

            foreach (amazonVPC aVpc in VPCList)
            {
                TreeNode[] tvwNode = tvwStructure.Nodes.Find(aVpc.name, false);

                if (tvwNode.Length == 0)
                {
                    TreeNode tn = tvwStructure.Nodes.Add(aVpc.name, "VPC[" + aVpc.name + "|" + aVpc.cidr_block + "]");
                    tn.Nodes.Add("SN:" + aVpc.name, "Subnets");
                    tn.Nodes.Add("RT:" + aVpc.name, "Route Tables");
                    tn.Nodes.Add("IG:" + aVpc.name, "Internet Gateways");
                    tn.Nodes.Add("NACL:" + aVpc.name, "Network ACLs");
                    tn.Nodes.Add("EIP:" + aVpc.name, "Elastic IPs");
                    tn.Nodes.Add("SG:" + aVpc.name, "Security Groups");

                    tn.ExpandAll();
                }

            }
        }

        private void LoadTreeWithSubnet()
        {
            TerraformGen tfGen = new TerraformGen();
            // For Loading Subnets
            List<amazonSubnet> subnetList = new List<amazonSubnet>();

            tfGen.LoadSubnet(GlobalVars.varPrj.DiagramFilename, subnetList);

            foreach (amazonSubnet aSnet in subnetList)
            {

                TreeNode[] tvwNode = tvwStructure.Nodes.Find("SN:"+aSnet.vpc_id, true);

                if (tvwNode.Length > 0)
                {
                    TreeNode tn = tvwNode[0].Nodes.Add(aSnet.name, "SN[" + aSnet.name + "|" + aSnet.cidr_block + "]");

                    tn.Nodes.Add("INST:" + aSnet.name, "Instances");

                    tn.ExpandAll();
                }
            }
        }


        private void LoadTreeWithInstance()
        {
            TerraformGen tfGen = new TerraformGen();

            // For Loading Instance
            List<amazonInstance> instList = new List<amazonInstance>();

            tfGen.LoadInstance(GlobalVars.varPrj.DiagramFilename, instList);

            foreach (amazonInstance inst in instList)
            {
                TreeNode[] tvwNode = tvwStructure.Nodes.Find("INST:" + inst.subnet_id, true);

                if (tvwNode.Length > 0)
                {
                    tvwNode[0].Nodes.Add(inst.name, "INST[" + inst.name + "|" + inst.instance_type + "]");

                    tvwNode[0].ExpandAll();
                }
            }
           

        }

        private void LoadTreeWithInternetGateway()
        {
            TerraformGen tfGen = new TerraformGen();

            // For Loading Internet Gateway
            List<amazonInternetGateway> igList = new List<amazonInternetGateway>();

            tfGen.LoadInternetGateway(GlobalVars.varPrj.DiagramFilename, igList);

            foreach (amazonInternetGateway ig in igList)
            {
                TreeNode[] tvwNode = tvwStructure.Nodes.Find("IG:" + ig.vpc_id, true);

                if (tvwNode.Length > 0)
                {
                    tvwNode[0].Nodes.Add(ig.name, "IG[" + ig.name + "|" + ig.route_name+ "]");

                    tvwNode[0].ExpandAll();
                }
            }


        }

        private void LoadTreeWithSecurityGroup()
        {
            TerraformGen tfGen = new TerraformGen();

            // For Loading Security Group
            List<amazonSecurityGrp> sgList = new List<amazonSecurityGrp>();

            tfGen.LoadSecurityGroup(GlobalVars.varPrj.DiagramFilename, sgList);

            foreach (amazonSecurityGrp sg in sgList)
            {
                TreeNode[] tvwNode = tvwStructure.Nodes.Find("SG:" + sg.vpc_id, true);

                if (tvwNode.Length > 0)
                {
                    tvwNode[0].Nodes.Add(sg.name, "SG[" + sg.name + "|" + sg.vpc_id+ "]");

                    tvwNode[0].ExpandAll();
                }
            }


        }

        private void tvwStructure_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void tvwStructure_Click(object sender, EventArgs e)
        {
            if (tvwStructure.SelectedNode == null)
                return;
        
            if (tvwStructure.SelectedNode.Text.Contains(":") )
            {
               //
            }
            else if (tvwStructure.SelectedNode.Text.Contains("["))
            {
                string tnKey = tvwStructure.SelectedNode.Text.Split('[')[0];
                string tnName = tvwStructure.SelectedNode.Text.Split('[')[1].Split('|')[0];
                switch (tnKey)
                {
                    case "VPC":
                        LoadPropWindowWithVPC(tnName);
                        break;
                    case "SN":
                        LoadPropWindowWithSN(tnName);
                        break;
                    case "INST":
                        LoadPropWindowWithINST(tnName);
                            break;
                    case "IG":
                        LoadPropWindowWithIGW(tnName);
                        break;
                    case "SG":
                        LoadPropWindowWithSG(tnName);
                        break;

                    default:
                        break;
                }

                         
            }
        }

        private void LoadPropWindowWithVPC(string VPCName)
        {
            TerraformGen tfGen = new TerraformGen();
            // For Loading VPC
            List<amazonVPC> VPCList = new List<amazonVPC>();

            tfGen.LoadVPC(GlobalVars.varPrj.DiagramFilename, VPCList);

            foreach (amazonVPC aVpc in VPCList)
            {
                if (aVpc.name == VPCName)
                { prgPropGrid.SelectedObject = aVpc;
                    return;
                }
            }
        }

        private void LoadPropWindowWithSN(string SNName)
        {
            TerraformGen tfGen = new TerraformGen();
            // For Loading Subnet
            List<amazonSubnet> SNList = new List<amazonSubnet>();

            tfGen.LoadSubnet(GlobalVars.varPrj.DiagramFilename, SNList);

            foreach (amazonSubnet aSN in SNList)
            {
                if (aSN.name == SNName)
                {
                    prgPropGrid.SelectedObject = aSN;
                    return;
                }
            }
        }

        private void LoadPropWindowWithINST(string InstName)
        {
            TerraformGen tfGen = new TerraformGen();
            // For Loading Instances
            List<amazonInstance> InstList = new List<amazonInstance>();

            tfGen.LoadInstance(GlobalVars.varPrj.DiagramFilename, InstList);

            foreach (amazonInstance aInst in InstList)
            {
                if (aInst.name == InstName)
                {
                    prgPropGrid.SelectedObject = aInst;
                    return;
                }
            }
        }
        private void LoadPropWindowWithIGW(string IGName)
        {
            TerraformGen tfGen = new TerraformGen();
            // For Loading IGW
            List<amazonInternetGateway> igList = new List<amazonInternetGateway>();

            tfGen.LoadInternetGateway(GlobalVars.varPrj.DiagramFilename, igList);

            foreach (amazonInternetGateway aIG in igList)
            {
                if (aIG.name == IGName)
                {
                    prgPropGrid.SelectedObject = aIG;
                    return;
                }
            }

        }
        private void LoadPropWindowWithSG(string SGName)
        {
            TerraformGen tfGen = new TerraformGen();
            // For Loading SG
            List<amazonSecurityGrp> sgList = new List<amazonSecurityGrp>();

            tfGen.LoadSecurityGroup(GlobalVars.varPrj.DiagramFilename, sgList);

            foreach (amazonSecurityGrp aSG in sgList)
            {
                if (aSG.name == SGName)
                {
                    prgPropGrid.SelectedObject = aSG;
                    return;
                }
            }

        }

        private void prgPropGrid_Click(object sender, EventArgs e)
        {

        }

        private void tvwStructure_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void tvwStructure_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {

        }
    }
}
