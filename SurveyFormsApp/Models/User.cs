using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Models
{
    public class User
    {
        public User(string name, string surName)
        {
            CheckNameAndSurname(name,surName);
            Name = name;
            SurName = surName;
        }

        public string Name { get;  private set; }
        public string SurName { get; private set; }

        private void CheckNameAndSurname(string name, string surname)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("İsim boş geçilemez.");
            }
            if (String.IsNullOrEmpty(surname))
            {
                throw new Exception("Soyisim boş geçilemez.");
            }
        }
    }
}
