using SurveyFormsApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class ShortQuestion : Question,IQuestion
    {
        public string[] Answer = new string[1];
        public ShortQuestion(string text) : base(text, QuestionType.ShortAnswer)
        {
            Text = text;
            Answer[0] = "";
        }

        public string Text { get; set; }

        //public string Answer { get; private set; }

        public void AnswerTheShortQuestion(string answer)
        {
            if (Answer[0] =="" || Answer[0] == null)
            {
                if (answer.Length > 30)
                {
                    throw new Exception("Kısa yanıt soru tipi için 30 karakterden fazla karakter girilemez.");
                }
                else
                {
                    this.Answer[0] = answer;
                }
            }
            else
            {
                throw new Exception("Bu soru tipi için yalnızca bir adet cevap girebilirsiniz.");
            }
        }
    }
}
