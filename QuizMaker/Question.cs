using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public sealed class Question
    {
        #region Members
        List<Answer> answers;
        string text;
        #endregion

        #region Constructor
        public Question(string text)
        {
            this.text = text;
        }

        public Question(string text, params Answer[] answers)
        {
            this.text = text;
            this.answers = answers.ToList();
        }
        #endregion

        #region Properties
        public string Text
        {
            get { return text; }
        }

        public List<Answer> Answers
        {
            get { return answers; }
            set
            {
                if (!answers.Equals(value))
                {
                    answers = value;
                }
            }
        }
        #endregion
    }
}
