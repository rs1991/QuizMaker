﻿using System;
namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            UiMethods.WelcomeMessage();
            QnA Question = new QnA();
            
            UiMethods.DisplayQuestion(Question.Question);
            int SelectedAnswer = UiMethods.SelectAnswer();
            UiMethods.VerifyAnswer(SelectedAnswer);




        }
    }
}
