using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RexQuiz.Models
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public string QuizTitle { get; set; }
        public string QuizType { get; set; }
        public string QuizLevel { get; set; }
        public int NoOfQuestion { get; set; }
    }
}
