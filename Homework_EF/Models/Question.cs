using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_EF.Models
{
    class Question
    {
        public int Id { get; set; }
        public virtual Category Category { get; set; }
        public string Text { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
