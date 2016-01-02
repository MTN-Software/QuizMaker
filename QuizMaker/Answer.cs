using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    /// <summary>
    /// The Answer class.
    /// Immutable.
    /// </summary>
    public sealed class Answer
    {
        #region Members
        string text;
        bool isCorrect;
        #endregion

        #region Constructor
        public Answer(string text, bool isCorrect)
        {
            this.text = text;
            this.isCorrect = isCorrect;
        }
        #endregion

        #region Properties
        public string Text
        {
            get { return text; }
        }

        public bool IsCorrect
        {
            get { return isCorrect; }
        }
        #endregion
    }
}
