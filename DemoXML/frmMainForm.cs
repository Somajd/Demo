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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void loadTestPlatformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form testPltfm = new frmTestPlat();
            testPltfm.MdiParent = this;
            testPltfm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmSettings = new frmProjectSettings();
            frmSettings.MdiParent = this;
            frmSettings.Show();
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "project files (*.tfg)|*.tfg";
            openFileDialog.Title = " Please select the Terrform Generator Project File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;

                if (path.Contains(".tfg"))
                {
                    GlobalVars.ProjectFilename = path;


                    Project prj = new Project();
                    if (prj.LoadProject(GlobalVars.ProjectFilename.ToString()))
                    { GlobalVars.varPrj = prj; }

                    toolStripStatusLabel1.Text = path;
                    statusStrip1.Refresh();

                }
            }
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void drawIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBr = new frmBroswer();
            frmBr.MdiParent = this;
            frmBr.Show();
        }

        private void generateScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmGen = new frmTfGenerator();
            frmGen.MdiParent = this;
            frmGen.Show();
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVars.varPrj.SaveProject())
            {
                MessageBox.Show("Project saved \n" + GlobalVars.varPrj.ProjectFilename, "Saved", MessageBoxButtons.OK);
            }
        }

        private void saveAsProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName;

                if (!path.Contains(".tfg"))
                {
                    path += ".tfg";
                }
                    GlobalVars.ProjectFilename = path;
                    toolStripStatusLabel1.Text = path;
                    statusStrip1.Refresh();

                if (GlobalVars.varPrj.SaveAsProject(path))
                {
                    MessageBox.Show("Project saved \n" + GlobalVars.varPrj.ProjectFilename, "Saved", MessageBoxButtons.OK);
                }

            }
        }

        private void visualizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmVisual = new frmVisualizer();
            frmVisual.MdiParent = this;
            frmVisual.Show();
        }
    }
}
