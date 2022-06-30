using System;
using static QuizMaker.UiMethods;
using static QuizMaker.LogicMethods;
using static QuizMaker.Modes;
namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            GameMode gm = GetGameMode();
            DisplayGameMode(gm);
            if (gm == GameMode.Play)
            {
                //do gameplay stuff
                List<QnA> QuestionList1 = GenerateQnAList(); 
                var random = new Random();
                int index = random.Next(QuestionList1.Count);
                DisplayQuestion(QuestionList1[index]);
                DisplayAnswers(QuestionList1[index]);
                int SelectedAnswer = SelectAnswer();
                bool result = VerifyAnswer(SelectedAnswer, QuestionList1[index]);
                
                if (result == true)
                {
                    TotalScore();
                }
                
                DisplayResultInfo(result);
            }
            if (gm == GameMode.AddQuestion)
            {
                //do question adding stuff
                List<QnA> QuestionList = CreateQuestions();
                string path = @"C:\tmp\QuestionList.xml";
                WriteQnAList(QuestionList, path);
                LoadQnAList(path);
            }
        }
    }
}
