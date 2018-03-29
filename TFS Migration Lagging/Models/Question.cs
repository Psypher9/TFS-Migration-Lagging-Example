using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFSMigrationLagging.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string Text { get; set; } = string.Empty;

        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
        public TimeSpan? TimeLimit { get; set; }
        public virtual List<AnswerSelection> AnswerSelections { get; set; }
    }
}
