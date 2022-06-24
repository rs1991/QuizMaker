using System;
namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UiMethods.WelcomeMessage();

            
            Console.WriteLine("Select the game mode to play [P to play] or [A to add questions]");
            string gameChoice = Console.ReadLine().ToUpper();
            if (gameChoice == "P")
            {
                UiMethods.GamePlayChoice(UiMethods.GameMode.Play);
            }
            if (gameChoice == "A")
            {
                UiMethods.GamePlayChoice(UiMethods.GameMode.AddQuestion);
                UiMethods.CreateQuestions();

            }


            List <QnA> QuestionList = LogicMethods.GenerateQnAList();
            
            string path = @"C:\tmp\QuestionList.xml";

            LogicMethods.WriteQnAList(QuestionList, path);
            LogicMethods.LoadQnAList(path);                 
            var random = new Random();                               
            int index = random.Next(QuestionList.Count);                           
            UiMethods.DisplayQuestion(QuestionList[index]);
            UiMethods.AnswerDisp(QuestionList[index]);
            int SelectedAnswer = UiMethods.SelectAnswer();

            

            bool result = LogicMethods.VerifyAnswer(SelectedAnswer, QuestionList[index]);
            UiMethods.DisplayResultInfo(result);

        }
    }
}
