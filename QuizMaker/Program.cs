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

            const string path = @"C:\tmp\QuestionList.xml";

            WelcomeMessage();
            GameMode gm = GetGameMode();
            DisplayGameMode(gm);

            bool playMore = true;

            while (playMore)
            {
                if (gm == GameMode.Play)
                {
                    double TotalScore = 0;
                    List<QnA> QuestionList1 = GenerateQnAList();

                    int count = 0;
                   
                    while(QuestionList1.Count != count) {
                        
                          
                        
                        var random = new Random();
                        int index = random.Next(QuestionList1.Count);
                        DisplayQnA(QuestionList1[index]);
                        int SelectedAnswer = SelectAnswer();
                        bool answerIsCorrect = VerifyAnswer(SelectedAnswer, QuestionList1[index]);
                        DisplayResultInfo(answerIsCorrect);
                        if (answerIsCorrect == true)
                        {
                            TotalScore++;
                        }
                        ScoreTotal(TotalScore);
                        
                        
                            QuestionList1.RemoveAt(index);
                        


                    }
                }

                if (gm == GameMode.AddQuestion)
                {
                 
                    GenerateQuestions();
                    List<QnA> QuestionList = GenerateQnAList();
                    WriteQnAList(QuestionList, path);
                    LoadQnAList(path);
                    if (AddMoreQuestions())
                    {
                      GenerateQuestions();
                    }
                    AddMoreQuestionsEndMessage();
                 
                }


                if (PlayAgain())
                {
                    playMore = true;
                }
                else
                {
                    EndMessage();
                    break;
                }


            }
        }
    }
}