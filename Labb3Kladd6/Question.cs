using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3Kladd6
{
    internal class Question
    {
        public string QuestionText { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> Options { get; set; }
    }
}
