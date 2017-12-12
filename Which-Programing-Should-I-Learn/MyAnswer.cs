using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Which_Programing_Should_I_Learn
{
    class MyAnswer
    {
        public int QuestionIndex { get; set; }
        public String Answer { get; set; }

        public MyAnswer(int i, String a)
        {
            this.QuestionIndex = i;
            this.Answer = a;
        }
    }
}
