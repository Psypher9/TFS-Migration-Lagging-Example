using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFSMigrationLagging.Models
{
    public class AnswerSelection
    {
        [Key]
        public int AnswerId { get; set; }
        public string AnswerText { get; set; } = string.Empty;
        public bool CorrectAnswer { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
