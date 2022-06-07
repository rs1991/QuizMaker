using System;
namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {

                        
            QnA Question = new QnA();
            Question.Question = "Which country gifted America the statue of Liberty?";
            Question.Answers.Add("Belgium");
            Question.Answers.Add("France");
            Question.Answers.Add("Sweden");
            Question.Answers.Add("Denmark");
            Question.CorrectAnswerIndex = 1;

            

            UiMethods.WelcomeMessage();

            
            UiMethods.DisplayQuestion(Question.Question);
            UiMethods.DisplayAnswers(Question);
            








        }
    }
}
