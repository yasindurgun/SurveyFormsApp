using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormsApp.Abstract
{
    /// <summary>
    /// Questionların hepsini işaretlemek için kullanılır.
    /// </summary>
    public interface IQuestion
    {
        public string Text { get; set; }
    }
}
