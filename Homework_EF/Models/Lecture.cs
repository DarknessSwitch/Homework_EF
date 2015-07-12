using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_EF.Models
{
    class Lecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Category Category { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
