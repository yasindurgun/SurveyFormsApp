using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Abstract
{
    public enum QuestionType
    {
        ShortAnswer,
        Paragraph,
        YesNo,
        MultipleChoice,
        CheckBox,
        DateFormat
    }
    public abstract class Question
    {
        protected Question(string text, QuestionType questionType)
        {
            QuestionText = text;
            QuestionType = questionType;
        }

        public string QuestionText { get; set; }
        public QuestionType QuestionType { get; set; }
    }
}
