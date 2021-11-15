using SurveyFormsApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class Survey
    {
        public Survey(User user ,string title, DateTime date, int questionNumber)
        {
            CheckSurvey(title, date,questionNumber);
            User = user;
            Title = title;
            Date = date;
            QuestionNumber = questionNumber;
        }
        public string Title { get; private set; }
        public DateTime Date { get; private set; }
        public int QuestionNumber { get; private set; }
        public string  Description { get; set; }
        public User User { get; set; }

        /// <summary>
        /// Bütün questionlar bir IQuestiondur.
        /// </summary>
        ///
        
        //Liste içerisinde Question base class ı da tutulabilirdi. Tüm soru tipleri o sınıftan kalıtım alıyor.
        private List<IQuestion> questions = new List<IQuestion>();
        public IReadOnlyList<IQuestion> Questions => questions;

        //public List<IQuestion> questions = new List<IQuestion>();

        private void CheckSurvey(string title, DateTime date, int questionNumber)
        {
            if (title =="")
            {
                throw new Exception("Anket başlığı boş bırakılamaz.");
            }
            if (date == default(DateTime))
            {
                throw new Exception("Tarih alanı boş bırakılamaz.");
            }
            if (questionNumber == 0)
            {
                throw new Exception("Ankete soru girilmelidir.");
            }
        }

        public void SetDescription(string description)
        {
            if (String.IsNullOrEmpty(description))
            {
                throw new Exception("Description alanı boş geçilemez");
            }
            else
            {
                Description = description;
            }
        }
       public void AddQuestionsToTheSurvey(IQuestion question)
        {
            if (questions.Count < QuestionNumber)
            {
                bool isSameQuestion = questions.Any(x =>x.Text == question.Text);

                if (!isSameQuestion)
                {
                    questions.Add(question);
                }
                else
                {
                    throw new Exception("Aynı soru ankette yalnızca bir defa sorulabilir.");
                }
            }
            else
            {
                throw new Exception("Belirlenmiş soru sayısından daha fazla soru girilemez.");
            }
        }
    }
}
