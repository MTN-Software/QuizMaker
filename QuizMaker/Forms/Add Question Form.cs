using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuizMaker
{
    public partial class frmAddQuestion : Form
    {
        public frmAddQuestion()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            QuestionBank.Instance.Count++;
            string textValue = txtQuestion.Text;
            DocumentMaker.Instance.XDoc.Root.Add(new XElement("Question", new XAttribute("id", $"{QuestionBank.Instance.Count}"),
                                            new XElement("Text", textValue)));
            DocumentMaker.Instance.XDoc.Save(@"..\..\tempFile.xml");
            QuestionBank.Instance.AddQuestion(new Question(textValue));
            Close();
        }
    }
}
