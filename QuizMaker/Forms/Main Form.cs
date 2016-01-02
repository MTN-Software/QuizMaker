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
using System.Xml;
using System.Xml.Linq;

namespace QuizMaker
{
    public partial class frmMain : Form
    {
        Control listQ;
        Control listA;
        public frmMain()
        {
            InitializeComponent();
            DocumentMaker.Instance.XDoc = XDocument.Load(@"..\..\tempFile.xml");
            listQ = questionBankEditorControl1.Controls[0].Controls[1].Controls[0].Controls[0].Controls[0];
            listA = questionBankEditorControl1.Controls[0].Controls[1].Controls[0].Controls[1].Controls[0];
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Any unsaved modifications will be lost", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
            
        }

        #region XML Tab
        private void tabXml_Enter(object sender, EventArgs e)
        {
            var xDoc = XDocument.Parse(DocumentMaker.Instance.XDoc.ToString());
            txtXmlPreview.Text = xDoc.ToString();
        }
        
        private void txtXmlPreview_Enter(object sender, EventArgs e)
        {
            //Leave blank for now
        }
        #endregion

        #region Tasks

        #endregion

        
    }
}
