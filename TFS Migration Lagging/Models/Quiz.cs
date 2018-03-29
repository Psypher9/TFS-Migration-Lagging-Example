using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFSMigrationLagging.Models
{
    public class Quiz
    {
        [Key]
        public int Id { get; private set; }
        public string Title { get; set; }
        public virtual List<Question> Questions { get; set; }
    }
}
