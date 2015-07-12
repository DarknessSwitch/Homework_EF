using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_EF.Models
{
    class Test
    {
        public int TestId { get; set; }
        public string Name { get; set; }
        public virtual Category Category { get; set; }
        public int GivenTime { get; set; }
        public int PassingScore { get; set; }
        public virtual TestResult TestResult { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
