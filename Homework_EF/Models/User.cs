using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_EF.Models
{
    class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string University { get; set; }
        public virtual ICollection<TestResult> TestResults { get; set; }
        public virtual Category Category { get; set; }
    }
}
