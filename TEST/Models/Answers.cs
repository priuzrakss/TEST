using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST.Models
{
    internal class Answer
    {
        public List<int> answer = new List<int>();
        public void AddAnswer(int answ)
        {
            answer.Add(answ);
        }
    }
}
