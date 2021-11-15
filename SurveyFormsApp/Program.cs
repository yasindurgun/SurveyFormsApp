using SurveyFormsApp.Models;
using System;

namespace SurveyFormsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ahmet","Yılmaz");
            Survey survey = new Survey(user,"Genel Kültür",DateTime.Now,3);

            //Question1
            ShortQuestion s = new ShortQuestion("Hngi şehirde yaşıyorsunuz?");
            //s.AnswerTheShortQuestion("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            s.AnswerTheShortQuestion("İstanbul");

            survey.AddQuestionsToTheSurvey(s);

            //Question2
            MultipleChoiceQuestion m = new MultipleChoiceQuestion("Türkiye'nin başkenti hangi şehirdir?");
            Option o1 = new Option("Ankara");
            Option o2 = new Option("İstanbul");
            Option o3 = new Option("İzmir");
            Option o4 = new Option("Bursa");
            m.AddNewOption(o1);
            m.AddNewOption(o2);
            m.AddNewOption(o3);
            m.AddNewOption(o4);
            //m.AddNewOption(o4);
            m.AnswerTheMultipleChoiceQuestion(o1);
            //m.AnswerTheMultipleChoiceQuestion(o1);

            survey.AddQuestionsToTheSurvey(m);

            //Question3
            YesNoQuestion yn = new YesNoQuestion("Okuyor musunuz?");
            yn.AnswerTheYesNoQuestion(yes: false, no: true);
            survey.AddQuestionsToTheSurvey(yn);


            YesNoQuestion ynt = new YesNoQuestion("Okuyor musunuz?");
            yn.AnswerTheYesNoQuestion(yes: false, no: true);
            survey.AddQuestionsToTheSurvey(ynt);
            Console.ReadKey();
        }
    }
}
