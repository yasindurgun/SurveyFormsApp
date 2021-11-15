using SurveyFormsApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class YesNoQuestion : Question, IQuestion
    {
        public YesNoQuestion(string text) : base(text, QuestionType.YesNo)
        {
            Text = text;
        }
        public bool YesChoice { get; private set; }
        public bool NoChoice { get; set; }
        public string Text { get; set; }

        public void AnswerTheYesNoQuestion(bool yes, bool no)
        {
            if (yes && no)
            {
                throw new Exception("Aynı anda iki farklı seçenek işaretlenemez");
            }
            if(yes == false && no == false)
            {
                throw new Exception("Soru boş geçilemez");
            }
            else
            {
                this.YesChoice = yes;
                this.NoChoice = no;
            }
        }
    }
}
