using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class QnA
    {
        public string Question;
        public List<string> Answers = new List<string>(4);
        public int CorrectAnswerIndex;

        

        
        public override string ToString()
        {
            return $"{Question}";
        }


        //public override string ToString()
        //{
        //    string retVal = "";
        //    retVal += Question + "?";
        //    foreach (string answer in Answers)
        //    {
        //        retVal += answer;
        //    }
        //    return retVal;
        //}
    }

}
