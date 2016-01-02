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
    public partial class frmAddAnswer : Form
    {
        string elementName;
        public frmAddAnswer()
        {
            InitializeComponent();
        }

        public frmAddAnswer(string elementName)
        {
            InitializeComponent();
            this.elementName = elementName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Answer newAns = new Answer(txtAnswer.Text, chkIsCorrect.Checked);
            DocumentMaker.Instance.XDoc.Descendants("Question")
                        .Where(n => (string)n.Element("Text") == elementName)   // gets the question that has the same text as elementName
                        .Single().Add(new XElement("Answer", new XAttribute("isCorrect", newAns.IsCorrect.ToString().ToLower()), newAns.Text)); // adds a new "Answer" subelement to the question 
                                                                                                                                                // containing whether or not it is the correct answer and
                                                                                                                                                // the text from the textbox
            DocumentMaker.Instance.XDoc.Save(@"..\..\tempFile.xml"); // save to temporary file.
            QuestionBank.Instance.Questions
                                .Where(x => x.Text == elementName)
                                .Single().Answers.Add(newAns);      // adds the answer to the corresponding question's answer list
            this.Close();
        }
    }
}
