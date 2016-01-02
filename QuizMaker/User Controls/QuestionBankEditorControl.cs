using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker.User_Controls
{
    public partial class QuestionBankEditorControl : UserControl
    {
        string elementName;
        public QuestionBankEditorControl()
        {
            InitializeComponent();
            btnAddAnswer.Enabled = false;
        }

        private void QuestionBankEditorControl_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("hi");
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            frmAddQuestion frmAdd = new frmAddQuestion();
            frmAdd.ShowDialog();
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            frmAddAnswer frmAdd = new frmAddAnswer(elementName);
            frmAdd.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listQuestions.Items.Clear();
            ListViewItem[] Questions = new ListViewItem[QuestionBank.Instance.Questions.Count];
            for (int i = 0; i < Questions.Length; i ++)
            {
                Questions[i] = new ListViewItem(i.ToString());
                Questions[i].SubItems.Add(QuestionBank.Instance.Questions[i].Text);
            }
            listQuestions.Items.AddRange(Questions);
        }

        private void listQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                elementName = listQuestions.SelectedItems[0].SubItems[1].Text;
                btnAddAnswer.Enabled = true;
            }catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
