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
   

    public partial class frmProjectSettings : Form
    {
        public string varEditMode { get; set; }
        public string oldKeyname { get; set; }
        public string oldKeyvalue { get; set; }

        public frmProjectSettings()
        {
            InitializeComponent();
        }

        private void frmProjectSettings_Load(object sender, EventArgs e)
        {
            if (GlobalVars.ProjectFilename.ToString().Length > 0)
            {

                Project prj = new Project();
                if (prj.LoadProject(GlobalVars.ProjectFilename.ToString()))
                {
                    this.Text = prj.ProjectName + " - Project Settings";
                    txtProjectName.Text = prj.ProjectName;
                    txtDrawFileName.Text = prj.DiagramFilename;
                    txtAWSAccount.Text = prj.AWSAccount;
                    txtAWSAccessKey.Text = prj.AWSAccessKey;
                    txtAWSSecretKey.Text = prj.AWSSecretKey;

                    dataGridView1.DataSource = (from entry in prj.TFVariables
                                                orderby entry.Key
                                                select new { entry.Key, entry.Value }).ToList();
                }

               
                GlobalVars.varPrj = prj;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.ge
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                txtKeyName.Text = Convert.ToString(selectedRow.Cells["Key"].Value);
                txtKeyValue.Text = Convert.ToString(selectedRow.Cells["Value"].Value);

                oldKeyname = Convert.ToString(selectedRow.Cells["Key"].Value);
                oldKeyvalue = Convert.ToString(selectedRow.Cells["Value"].Value);

                btnUpdate.Text = "Update";
                btnUpdate.Enabled = true;
                btnDelete.Text = "Delete";
                btnDelete.Enabled = true;

                varEditMode = "Update";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            varEditMode = "New";

            txtKeyName.Text = "";
            txtKeyValue.Text = "";

            btnNew.Enabled = false;
            btnUpdate.Text = "Save";
            btnDelete.Text = "Cancel";


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { 
            if (varEditMode == "New")
            {
                if (txtKeyName.Text.ToString().Length >0)
                {
                    GlobalVars.varPrj.TFVariables.Add(txtKeyName.Text, txtKeyValue.Text);

                    dataGridView1.DataSource = (from entry in GlobalVars.varPrj.TFVariables
                                                orderby entry.Key
                                                select new { entry.Key, entry.Value }).ToList();
                }

                varEditMode = "Update";
                btnNew.Enabled = true;
                btnUpdate.Text = "Update";
                btnDelete.Text = "Delete";
            }
            else if (varEditMode == "Update")
            {

                if ( oldKeyname != txtKeyName.Text)
                {
                    GlobalVars.varPrj.TFVariables.Remove(oldKeyname);
                    GlobalVars.varPrj.TFVariables.Add(txtKeyName.Text, txtKeyValue.Text);

                    dataGridView1.DataSource = (from entry in GlobalVars.varPrj.TFVariables
                                                orderby entry.Key
                                                select new { entry.Key, entry.Value }).ToList();

                }
                else
                {
                    GlobalVars.varPrj.TFVariables[txtKeyName.Text] = txtKeyValue.Text;

                    dataGridView1.DataSource = (from entry in GlobalVars.varPrj.TFVariables
                                                orderby entry.Key
                                                select new { entry.Key, entry.Value }).ToList();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (varEditMode == "Update")
            {
                GlobalVars.varPrj.TFVariables.Remove(oldKeyname);

                dataGridView1.DataSource = (from entry in GlobalVars.varPrj.TFVariables
                                            orderby entry.Key
                                            select new { entry.Key, entry.Value }).ToList();
            }
            else
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    txtKeyName.Text = Convert.ToString(selectedRow.Cells["Key"].Value);
                    txtKeyValue.Text = Convert.ToString(selectedRow.Cells["Value"].Value);

                    oldKeyname = Convert.ToString(selectedRow.Cells["Key"].Value);
                    oldKeyvalue = Convert.ToString(selectedRow.Cells["Value"].Value);

                    btnUpdate.Text = "Update";
                    btnUpdate.Enabled = true;
                    btnDelete.Text = "Delete";
                    btnDelete.Enabled = true;

                    varEditMode = "Update";

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GlobalVars.varPrj.ProjectName = txtProjectName.Text;
            GlobalVars.varPrj.DiagramFilename = txtDrawFileName.Text;
            GlobalVars.varPrj.AWSAccount = txtAWSAccount.Text;
            GlobalVars.varPrj.AWSAccessKey = txtAWSAccessKey.Text;
            GlobalVars.varPrj.AWSSecretKey = txtAWSSecretKey.Text;

            if (GlobalVars.varPrj.SaveProject())
            {
                MessageBox.Show("Project Setting Saved!","Saved", MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnDrawFilename_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;

                if (path.Contains(".xml"))
                {
                    txtDrawFileName.Text = path;
                   
                }

            }
        }
    }
}
