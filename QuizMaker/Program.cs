using System;
namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UiMethods.WelcomeMessage();
            QnA Question = new QnA();
            UiMethods.DisplayQuestion(Question.Question);

            
            int SelectAnswer = UiMethods.SelectAnswer();

            if(SelectAnswer == Question.CorrectAnswerIndex)
            {
                Console.WriteLine("Correct answer!");
            }
        }
    }
}
