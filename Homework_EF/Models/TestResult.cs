using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_EF.Models
{
    class TestResult
    {
        [Key]
        [ForeignKey("Test")]
        public int TestId { get; set; }
        public int TimeTaken { get; set; }
        public int Result { get; set; }
        public virtual Test Test { get; set; }
        public virtual ICollection<Answer> CorrectAnswers { get; set; } 
        public virtual User User { get; set; }
    }
}
