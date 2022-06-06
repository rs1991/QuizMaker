using System;
namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string Question = "";


            QnA Question6 = new QnA();
            Question6.Question = "Which country gifted America the statue of Liberty?";
            Question6.Answers.Add("Belgium");
            Question6.Answers.Add("France");
            Question6.Answers.Add("Sweden");
            Question6.Answers.Add("Denmark");
            Question6.CorrectAnswerIndex = 1;

            UiMethods.WelcomeMessage();

            
            UiMethods.DisplayQuestion(Question6.Question);
            UiMethods.DisplayAnswers(Question6);








        }
    }
}
