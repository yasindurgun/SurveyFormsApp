using SurveyFormsApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class ParagraphQuestion : Question, IQuestion
    {
        public string[] Answer = new string[1];
        public ParagraphQuestion(string text) : base(text,QuestionType.Paragraph)
        {
            Text = text;
            Answer[0] = "";
        }

        public string Text { get; set; }

        public void AnswerTheParagraphQuestion(string answer)
        {
            if (Answer[0] == "" || Answer[0]== null)
            {
                if (answer.Length > 200)
                {
                    throw new Exception("Kısa yanıt soru tipi için 200 karakterden fazla karakter girilemez.");
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
