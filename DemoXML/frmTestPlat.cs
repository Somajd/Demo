using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DemoXML
{
    public partial class frmTestPlat : Form
    {
        public string drawFilename;
        public frmTestPlat()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;

                if (path.Contains(".tfg"))
                {
                    drawFilename = path;
                    toolStripStatusLabel1.Text = path;
                    statusStrip1.Refresh();
                    terraformGenerateToolStripMenuItem.Enabled = true;
                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openForLINQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;
                TerraformGen tfGen = new TerraformGen();

                // For Loading VPC
                /* List<amazonVPC> VPCList = new List<amazonVPC>();

                 tfGen.LoadVPC(path, VPCList);

                 foreach ( amazonVPC aVpc in VPCList)
                 {
                     richTextBox1.Text += aVpc.ToString();
                 }
                 dataGridView1.DataSource = VPCList;
                 */

                /*
                // For Loading Subnets
                List<amazonSubnet> subnetList = new List<amazonSubnet>();

                tfGen.LoadSubnet(path, subnetList);

                foreach (amazonSubnet aSNet in subnetList)
                {
                    richTextBox1.Text += aSNet.ToString();
                }
                dataGridView1.DataSource = subnetList;
                */

                // For Loading Security Group
                List<amazonSecurityGrp> secgrpList = new List<amazonSecurityGrp>();

                tfGen.LoadSecurityGroup(path, secgrpList);

                foreach (amazonSecurityGrp aSNet in secgrpList)
                {
                    richTextBox1.Text += aSNet.ToString();
                }
                dataGridView1.DataSource = secgrpList;


            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void terraformGenerateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (drawFilename.Length ==0)
            {
                terraformGenerateToolStripMenuItem.Enabled = false;
            }
        }

        private void vPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerraformGen tfGen = new TerraformGen();

            // For Loading VPC
             List<amazonVPC> VPCList = new List<amazonVPC>();

             tfGen.LoadVPC(drawFilename, VPCList);

             foreach ( amazonVPC aVpc in VPCList)
             {
                 richTextBox1.Text += aVpc.ToString();
             }
             dataGridView1.DataSource = VPCList;
             
        }

        private void subnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerraformGen tfGen = new TerraformGen();
            // For Loading Subnets
            List<amazonSubnet> subnetList = new List<amazonSubnet>();

               tfGen.LoadSubnet(drawFilename, subnetList);

               foreach (amazonSubnet aSNet in subnetList)
               {
                   richTextBox1.Text += aSNet.ToString();
               }
               dataGridView1.DataSource = subnetList;
               
        }

        private void securityGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerraformGen tfGen = new TerraformGen();

            // For Loading Security Group
            List<amazonSecurityGrp> secgrpList = new List<amazonSecurityGrp>();

            tfGen.LoadSecurityGroup(drawFilename, secgrpList);

            foreach (amazonSecurityGrp aSNet in secgrpList)
            {
                richTextBox1.Text += aSNet.ToString();
            }
            dataGridView1.DataSource = secgrpList;
        }

        private void inernetGatewayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerraformGen tfGen = new TerraformGen();

            // For Loading Security Group
            List<amazonInternetGateway> igwList = new List<amazonInternetGateway>();

            tfGen.LoadInternetGateway(drawFilename, igwList);

            foreach (amazonInternetGateway igw in igwList)
            {
                richTextBox1.Text += igw.ToString();
            }
            dataGridView1.DataSource = igwList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawFilename = "";
        }

        private void instanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TerraformGen tfGen = new TerraformGen();

            // For Loading Security Group
            List<amazonInstance> instList = new List<amazonInstance>();

            tfGen.LoadInstance(drawFilename, instList);

            foreach (amazonInstance inst in instList)
            {
                richTextBox1.Text += inst.ToString();
            }
            dataGridView1.DataSource = instList;


        }

        
    }
}
