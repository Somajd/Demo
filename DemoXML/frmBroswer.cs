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
    public partial class frmBroswer : Form
    {
        public frmBroswer()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void frmBroswer_Load(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.draw.io/?local=1&analytics=0&picker=0&gapi=0&db=0&od=0&math=0");
            webBrowser1.Url = uri;
        }
    }
}
