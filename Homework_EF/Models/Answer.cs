using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_EF.Models
{
    class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual Question Question { get; set; }
        public virtual TestResult TestResult { get; set; }
    }
}
