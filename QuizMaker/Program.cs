﻿using System;
namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UiMethods.WelcomeMessage();          

            QnA Question = new QnA();

            
            List <QnA> QuestionList = LogicMethods.GenerateQnAList();

           
            var random = new Random();                               
            int index = random.Next(QuestionList.Count);             
            Console.WriteLine(QuestionList[index]);                  
            UiMethods.DisplayAnswers(QuestionList[index]);                      

            UiMethods.DisplayQuestion(Question.Question);

            int SelectedAnswer = UiMethods.SelectAnswer();
            
            bool result = LogicMethods.VerifyAnswer(SelectedAnswer, Question);
            
            UiMethods.DisplayResultInfo(result);

        }
    }
}
