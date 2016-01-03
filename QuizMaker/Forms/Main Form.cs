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
        string currentDocument = null;
        public frmMain()
        {
            InitializeComponent();
            DocumentMaker.Instance.XDoc = XDocument.Load(@"..\..\tempFile.xml");
            listQ = questionBankEditorControl1.Controls[0].Controls[1].Controls[0].Controls[0].Controls[0]; // \
                                                                                                            //  |- These are redundant
            listA = questionBankEditorControl1.Controls[0].Controls[1].Controls[0].Controls[1].Controls[0]; // /
            
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
                    sw.Write(""); // create a blank file.
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
            if (currentDocument != null)
            {
                if (MessageBox.Show("Any unsaved modifications will be lost.", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DocumentMaker.Instance.XDoc = XDocument.Load(@"..\..\superTemp.xml");
                    DocumentMaker.Instance.XDoc.Save(@"..\..\tempFile.xml");  // erase all content in the temporary file
                    currentDocument = null;
                }
            }
            else
            {
                DocumentMaker.Instance.XDoc = XDocument.Load(@"..\..\superTemp.xml");
                DocumentMaker.Instance.XDoc.Save(@"..\..\tempFile.xml");  // erase all content in the temporary file
                currentDocument = null;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
            if (currentDocument == null)
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "XML Files (*.xml)|*.xml";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    DocumentMaker.Instance.Open(openFile.FileName);
                    DocumentMaker.Instance.XDoc.Save(@"..\..\tempFile.xml");
                    currentDocument = openFile.FileName;

                    //QuestionBank.Instance.Questions
                    var questions = DocumentMaker.Instance.XDoc.Descendants("Question");
                    List<Question> listQ = new List<Question>();
                    questions.ToList().ForEach(n =>
                    {
                        Question q = new Question();
                        List<Answer> answerList = new List<Answer>();
                        q.Text = n.Element("Text").Value;
                        var answers = n.Elements("Answer").ToList();
                        answers.ForEach(m =>
                        {
                            q.Answers.Add(new Answer(m.Value, m.Attribute("isCorrect").Value == "true"));
                        });
                        var correct = answers.Where(x => x.Attribute("isCorrect").Value == "true").Single().Value;
                        //q.CorrectAnswer = q.Answers.Where(x => x.Text == correct).Single();
                        listQ.Add(q);
                    });

                    QuestionBank.Instance.Questions = listQ;
                    QuestionBank.Instance.Count = QuestionBank.Instance.Questions.Count - 1;
                    MessageBox.Show("Please press refresh to apply these changes.", "File successfully loaded.");
                }
            }
        }
    }
}
