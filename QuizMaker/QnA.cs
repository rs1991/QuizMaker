﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class QnA
    {
        public string Question;
        public List<string> Answers = new List<string>();
        public int CorrectAnswerIndex; 
    }

    public class QuestionList
    {
       public List<string> QuestionBank = new List<string>();
    }
}
