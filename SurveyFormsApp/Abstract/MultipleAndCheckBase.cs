using SurveyFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Abstract
{
    //abstract yerine interface kullanılabilirdi.
    public abstract class MultipleAndCheckBase : Question
    {
        public MultipleAndCheckBase(string text, QuestionType questionType) : base(text, questionType)
        {

        }

        protected HashSet<Option> options = new HashSet<Option>();
        public IReadOnlySet<Option> Options => options;
        public abstract void AddNewOption(Option option);
    }
}
