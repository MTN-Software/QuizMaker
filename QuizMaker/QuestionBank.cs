using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public sealed class QuestionBank
    {
        #region Members
        private static volatile QuestionBank instance;
        private static object syncRoot = new object();
        List<Question> questions;
        string title;
        int count;
        #endregion

        #region Constructor
        private QuestionBank() {}
        #endregion

        #region Methods
        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
        #endregion

        #region Properties
        /// <summary>
        /// The singleton instance of the class
        /// </summary>
        public static QuestionBank Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new QuestionBank();
                            instance.Questions = new List<Question>();
                            instance.count = -1;
                        }
                    }
                }
                return instance;
            }
        }

        /// <summary>
        /// The questions in the question bank.
        /// </summary>
        public List<Question> Questions
        {
            get { return questions; }
            set
            {
                questions = value;
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
            }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        #endregion
    }
}
