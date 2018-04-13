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

namespace DemoXML
{
    public partial class frmTfGenerator : Form
    {
        public frmTfGenerator()
        {
            InitializeComponent();
        }

        private void btnOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog opnFolderDialog = new FolderBrowserDialog();
            if (opnFolderDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = opnFolderDialog.SelectedPath;
            }
        }

        private void btnDrawFilename_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;

                if (path.Contains(".xml"))
                {
                    txtDrawFilename.Text = path;
                    GlobalVars.varPrj.DiagramFilename = path;
                }

            }
        }

        private void frmTfGenerator_Load(object sender, EventArgs e)
        {
            txtDrawFilename.Text = GlobalVars.varPrj.DiagramFilename;
            txtOutputFolder.Text = GlobalVars.varPrj.OutputFolder;
            txtVariableFilename.Text = GlobalVars.varPrj.VariableFilename;
        }

        private void btnOpenFldr_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", txtOutputFolder.Text);
        }

        private void btnTfGenerate_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtDrawFilename.Text))
            {
                if (!Directory.Exists (txtOutputFolder.Text +@"\"+ GlobalVars.varPrj.ProjectName +@"\" ))
                {
                    Directory.CreateDirectory(txtOutputFolder.Text + @"\" + GlobalVars.varPrj.ProjectName + @"\");
                }

                TerraformGen tfGen = new TerraformGen();
                string retText = "";

                if (tfGen.GenerateTerraform(txtDrawFilename.Text, txtOutputFolder.Text + @"\" + GlobalVars.varPrj.ProjectName + @"\TerraformScript.tf"))
                {
                    retText = "Terraform Script Generated \n Output File : " + GlobalVars.varPrj.ProjectName + @"\TerraformScript.tf \n\n";
                }

                if ( tfGen.GenerateTFVars(GlobalVars.varPrj, txtOutputFolder.Text + @"\" + GlobalVars.varPrj.ProjectName + @"\terraform.tfvars"))
                {
                    retText += "Terraform Variables Generated \n Output File : " + txtOutputFolder.Text + @"\" + GlobalVars.varPrj.ProjectName + @"\terraform.tfvars\n\n";

                }

                if (tfGen.GenerateTFVarsDef(GlobalVars.varPrj, txtOutputFolder.Text + @"\" + GlobalVars.varPrj.ProjectName + @"\variables.tf"))
                {
                    retText += "Terraform Variables Generated \n Output File : " + txtOutputFolder.Text + @"\" + GlobalVars.varPrj.ProjectName + @"\variables.tf\n\n";

                }

                rtxtOutput.Text = retText;

                MessageBox.Show("Terraform Script Generated and Save in " + txtOutputFolder.Text + @"\" + GlobalVars.varPrj.ProjectName, "Script Generated", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Draw IO file doesn't exist, please select again.", "Invalid Input",  MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void txtDrawFilename_Leave(object sender, EventArgs e)
        {
            if (File.Exists(txtDrawFilename.Text))
            {
                GlobalVars.varPrj.DiagramFilename = txtDrawFilename.Text;
            }
                
        }

        private void txtOutputFolder_Leave(object sender, EventArgs e)
        {
            if (Directory.Exists(txtOutputFolder.Text))
            {
                GlobalVars.varPrj.OutputFolder = txtOutputFolder.Text;
                GlobalVars.varPrj.SaveProject();
            }

        }

        private void txtVariableFilename_Leave(object sender, EventArgs e)
        {
            if (txtVariableFilename.Text.Length > 0)
            {
                GlobalVars.varPrj.DiagramFilename = txtDrawFilename.Text;
            }

        }
    }
}
