using System;
namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UiMethods.WelcomeMessage();
                       

            UiMethods.PromptToSelectGameChoice();



            //List <QnA> QuestionList = LogicMethods.GenerateQnAList();
            List <QnA> QuestionList = UiMethods.CreateQuestions();


            string path = @"C:\tmp\QuestionList.xml";

            UiMethods.WriteQnAList(QuestionList, path);
            UiMethods.LoadQnAList(path);                 
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
