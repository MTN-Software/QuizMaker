﻿using System;
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
        string currentDocument;
        public frmMain()
        {
            InitializeComponent();
            DocumentMaker.Instance.XDoc = XDocument.Load(@"..\..\tempFile.xml");
            listQ = questionBankEditorControl1.Controls[0].Controls[1].Controls[0].Controls[0].Controls[0];
            listA = questionBankEditorControl1.Controls[0].Controls[1].Controls[0].Controls[1].Controls[0];
            currentDocument = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Any unsaved modifications will be lost", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DocumentMaker.Instance.XDoc = XDocument.Load(@"..\..\superTemp.xml");
                DocumentMaker.Instance.XDoc.Save(@"..\..\tempFile.xml");
                this.Close();
            }
            
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

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            //saveFile.CreatePrompt = true;
            saveFile.Filter = "XML Files (*.xml)|*.xml";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    sw.Write("");
                DocumentMaker.Instance.XDoc.Save(saveFile.FileName);
                currentDocument = saveFile.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentDocument == null)
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                DocumentMaker.Instance.XDoc.Save(currentDocument);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Any unsaved modifications will be lost.", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DocumentMaker.Instance.XDoc = XDocument.Load(@"..\..\superTemp.xml");
                DocumentMaker.Instance.XDoc.Save(@"..\..\tempFile.xml");
                currentDocument = null;
            }
        }

    }
}
