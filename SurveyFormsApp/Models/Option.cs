using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class Option
    {
        public Option(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }
}
