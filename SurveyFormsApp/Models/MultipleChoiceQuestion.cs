using SurveyFormsApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class MultipleChoiceQuestion : MultipleAndCheckBase, IQuestion
    {
        public MultipleChoiceQuestion(string text) : base(text, QuestionType.MultipleChoice)
        {
            Text = text;
        }
        public string Answer { get; set; }
        public string Text { get; set; }

        public override void AddNewOption(Option option)
        {
            bool isSameOptions = options.Any(x => x.Text == option.Text); ;

            if (options.Count < 4)
            {
                if (!isSameOptions)
                {
                    options.Add(option);
                }
                else
                {
                    throw new Exception("Daha önce eklenmiş olan seçenek tekrar eklenemez."); 
                }
            }
            else
            {
                throw new Exception("En fazla 4 seçenek ekleyebilirsiniz.");
            }
        }

        public string[] answeredText = new string[1];
        int count = 0;
        public void AnswerTheMultipleChoiceQuestion(Option answeredOption)
        {
            //aynı anda birden fazla seçim yapılmaya çalışılıyorsa
            if (count == 1)
            {
                throw new Exception("Yalnızca 1 seçim yapabilirsiniz.");
            }
            bool answered = options.Any(x => x.Text == answeredOption.Text);

            //cevap seçenekler arasında varsa
            if (answered)
            {
                answeredText[count] = answeredOption.Text;
            }

            count++;
        }


    }
}
