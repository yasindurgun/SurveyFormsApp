using SurveyFormsApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class DateFormatQuestion : Question, IQuestion
    {
        //nullable DateTime
        public DateTime?[] Answer { get; set; } = new DateTime?[1];
        public DateFormatQuestion(string text) : base(text, QuestionType.DateFormat)
        {
            Answer[0] = null;
            Text = text;
        }
        public DateTime DateTime { get; set; }
        public string Text { get; set; }

        public void AnswerTheDateFormatQuestion(DateTime? answer)
        {
            if (answer != default(DateTime) && answer != null)
            {
                Answer[0] = answer;
            }
            else
            {
                throw new Exception("Bu soru tipi için yalnızca 1 adet cevap girebilirsiniz.");
            }
        }
    }
}
