using System;
namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UiMethods.WelcomeMessage();

            

            //
            //GameMode m = UiMethods.GamePlayChoice();
            //
            //if(m == GameMode.Play)
            //{

            //            }
            //          else
            //        {
            //
            //      }


            QnA Question = new QnA();
           
            List <QnA> QuestionList = LogicMethods.GenerateQnAList();
            
            string path = @"C:\tmp\QuestionList.xml";

            LogicMethods.WriteQnAList(QuestionList, path);
            LogicMethods.LoadQnAList(path);                 
            var random = new Random();                               
            int index = random.Next(QuestionList.Count);                           
            UiMethods.DisplayQuestion(QuestionList[index]);
            UiMethods.AnswerDisp(QuestionList[index]);
            int SelectedAnswer = UiMethods.SelectAnswer();

            while (SelectedAnswer > 4 || SelectedAnswer < 1)
            {
                Console.WriteLine("Please select a valid option");
                SelectedAnswer = UiMethods.SelectAnswer();
            }

            bool result = LogicMethods.VerifyAnswer(SelectedAnswer, QuestionList[index]);
            UiMethods.DisplayResultInfo(result);

        }
    }
}
