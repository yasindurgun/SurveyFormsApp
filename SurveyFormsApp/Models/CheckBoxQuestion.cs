using SurveyFormsApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class CheckBoxQuestion : MultipleAndCheckBase, IQuestion
    {
        public Option None;
        public string Text { get; set; }
        public int NumberOfCheckBox { get; set; }
        //constructor oluştuğunda none seçeneğinin instanceı oluşturulur. AddNewOption metodu içerisinde seçenekler eklenirken
        //tüm seçenekler eklendiğinde en son bu instance seçenekler listesine eklenir.
        public CheckBoxQuestion(string text, int numberOfCheckBox) :base (text, QuestionType.CheckBox)
        {
            Text = text;
            None = new Option("None");
            CheckTheNumberOfCheckBox(numberOfCheckBox);
        }

        private void CheckTheNumberOfCheckBox(int number)
        {
            if (number>5)
            {
                throw new Exception("Seçenek sayısı 5 ten fazla olamaz.");
            }
            else
            {
                this.NumberOfCheckBox = number;
            }
        }
        public override void AddNewOption(Option option)
        {
            bool isSameOptions = options.Any(x => x.Text == option.Text); ;

            if (options.Count < NumberOfCheckBox-1)
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
                options.Add(None);
            }
        }

        private HashSet<Option> answeredList = new HashSet<Option>();
        public IReadOnlySet<Option> AnswewredList => answeredList;

        public void AnswerTheCheckBoxQuestion(Option option)
        {
            bool none = options.Any(x => x.Text == "None");
            if (!none)
            {
                answeredList.Add(option);
            }
            else
            {
                answeredList.Clear();
                throw new Exception("Hiçbiri seçili olduğu için diğer seçenekleri seçemezsiniz.");
            }
            
            //answeredList.Add(option);

            //aynı seçenek tekrar tıklandığında check ifadesinin kaldırıldığı kısım.
            /*
            bool sameOption = answeredList.Any(x => x.Text == option.Text);
            string text = option.Text;
            if (sameOption)
            {
                var opt = from op in options
                          where option.Text == text
                          select op;
                int index = 0;
                foreach (var item in answeredList)
                {
                    if (item.Text.Contains(opt.ToString()))
                    {
                        answeredList.Remove((Option)opt);
                    }
                }
            */
                //var index = answeredList.IndexOf(opt);
                //answeredList.Remove(opt);
            }
        }
    }

