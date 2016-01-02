using System;

namespace QuizMaker.User_Controls
{
    partial class QuestionBankEditorControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSetBankName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuestionBankName = new System.Windows.Forms.TextBox();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.ListSplitter = new System.Windows.Forms.SplitContainer();
            this.listQuestions = new System.Windows.Forms.ListView();
            this.colHeadQValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadQID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listAnswers = new System.Windows.Forms.ListView();
            this.colHeadAValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadACorrect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListSplitter)).BeginInit();
            this.ListSplitter.Panel1.SuspendLayout();
            this.ListSplitter.Panel2.SuspendLayout();
            this.ListSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.btnSetBankName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtQuestionBankName);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddAnswer);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddQuestion);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ListSplitter);
            this.splitContainer1.Size = new System.Drawing.Size(700, 470);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSetBankName
            // 
            this.btnSetBankName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetBankName.Location = new System.Drawing.Point(622, 18);
            this.btnSetBankName.Name = "btnSetBankName";
            this.btnSetBankName.Size = new System.Drawing.Size(75, 23);
            this.btnSetBankName.TabIndex = 4;
            this.btnSetBankName.Text = "Set";
            this.btnSetBankName.UseVisualStyleBackColor = true;
            this.btnSetBankName.Click += new System.EventHandler(this.btnSetBankName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Question Bank Name:";
            // 
            // txtQuestionBankName
            // 
            this.txtQuestionBankName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestionBankName.Location = new System.Drawing.Point(7, 20);
            this.txtQuestionBankName.Name = "txtQuestionBankName";
            this.txtQuestionBankName.Size = new System.Drawing.Size(609, 20);
            this.txtQuestionBankName.TabIndex = 2;
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAnswer.AutoSize = true;
            this.btnAddAnswer.Location = new System.Drawing.Point(622, 136);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnswer.TabIndex = 1;
            this.btnAddAnswer.Text = "Add Answer";
            this.btnAddAnswer.UseVisualStyleBackColor = true;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddQuestion.AutoSize = true;
            this.btnAddQuestion.Location = new System.Drawing.Point(3, 136);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(81, 23);
            this.btnAddQuestion.TabIndex = 0;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // ListSplitter
            // 
            this.ListSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListSplitter.Location = new System.Drawing.Point(0, 0);
            this.ListSplitter.Name = "ListSplitter";
            // 
            // ListSplitter.Panel1
            // 
            this.ListSplitter.Panel1.Controls.Add(this.listQuestions);
            // 
            // ListSplitter.Panel2
            // 
            this.ListSplitter.Panel2.Controls.Add(this.listAnswers);
            this.ListSplitter.Size = new System.Drawing.Size(700, 304);
            this.ListSplitter.SplitterDistance = 344;
            this.ListSplitter.TabIndex = 0;
            // 
            // listQuestions
            // 
            this.listQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadQID,
            this.colHeadQValue});
            this.listQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listQuestions.FullRowSelect = true;
            this.listQuestions.Location = new System.Drawing.Point(0, 0);
            this.listQuestions.MultiSelect = false;
            this.listQuestions.Name = "listQuestions";
            this.listQuestions.Size = new System.Drawing.Size(344, 304);
            this.listQuestions.TabIndex = 0;
            this.listQuestions.UseCompatibleStateImageBehavior = false;
            this.listQuestions.View = System.Windows.Forms.View.Details;
            this.listQuestions.SelectedIndexChanged += new System.EventHandler(this.listQuestions_SelectedIndexChanged);
            // 
            // colHeadQValue
            // 
            this.colHeadQValue.Text = "Question";
            this.colHeadQValue.Width = 225;
            // 
            // colHeadQID
            // 
            this.colHeadQID.Text = "ID";
            // 
            // listAnswers
            // 
            this.listAnswers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadAValue,
            this.colHeadACorrect});
            this.listAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAnswers.Location = new System.Drawing.Point(0, 0);
            this.listAnswers.Name = "listAnswers";
            this.listAnswers.Size = new System.Drawing.Size(352, 304);
            this.listAnswers.TabIndex = 0;
            this.listAnswers.UseCompatibleStateImageBehavior = false;
            this.listAnswers.View = System.Windows.Forms.View.Details;
            // 
            // colHeadAValue
            // 
            this.colHeadAValue.Text = "Answer";
            // 
            // colHeadACorrect
            // 
            this.colHeadACorrect.Text = "Correct?";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(622, 47);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // QuestionBankEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "QuestionBankEditorControl";
            this.Size = new System.Drawing.Size(700, 470);
            this.Load += new System.EventHandler(this.QuestionBankEditorControl_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ListSplitter.Panel1.ResumeLayout(false);
            this.ListSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListSplitter)).EndInit();
            this.ListSplitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer ListSplitter;
        private System.Windows.Forms.ListView listQuestions;
        private System.Windows.Forms.ColumnHeader colHeadQValue;
        private System.Windows.Forms.ListView listAnswers;
        private System.Windows.Forms.ColumnHeader colHeadQID;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.ColumnHeader colHeadAValue;
        private System.Windows.Forms.ColumnHeader colHeadACorrect;
        private System.Windows.Forms.Button btnSetBankName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuestionBankName;
        private System.Windows.Forms.Button btnRefresh;
    }
}
