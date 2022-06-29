using System;
using static QuizMaker.UiMethods;
using static QuizMaker.LogicMethods;

namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            WelcomeMessage();



            Modes.GameMode gm = Modes.GetGameMode();
                   

            Modes.DisplayGameMode(gm);

            if (gm == Modes.GameMode.Play)
            {
                //do gameplay stuff
                List<QnA> QuestionList1 = GenerateQnAList(); 
                var random = new Random();
                int index = random.Next(QuestionList1.Count);
                DisplayQuestion(QuestionList1[index]);
                DisplayAnswers(QuestionList1[index]);
                int SelectedAnswer = UiMethods.SelectAnswer();
                bool result = LogicMethods.VerifyAnswer(SelectedAnswer, QuestionList1[index]);
                UiMethods.DisplayResultInfo(result);

            }
            if (gm == Modes.GameMode.AddQuestion)
            {
                //do question adding stuff
                List<QnA> QuestionList = UiMethods.CreateQuestions();
                string path = @"C:\tmp\QuestionList.xml";
                WriteQnAList(QuestionList, path);
                LoadQnAList(path);
            }



            


            
            //var random = new Random();
            //int index = random.Next(QuestionList.Count);
            //DisplayQuestion(QuestionList[index]);
            //DisplayAnswers(QuestionList[index]);
            //int SelectedAnswer = UiMethods.SelectAnswer();



            //bool result = LogicMethods.VerifyAnswer(SelectedAnswer, QuestionList[index]);
            //UiMethods.DisplayResultInfo(result);




        }
    }
}
