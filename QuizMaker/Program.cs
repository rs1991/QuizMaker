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

                    
                    List<QnA> QuestionList = LoadQnAList(path);


                    while (QuestionList.Count != 0) {
                        
                        var random = new Random();
                        int index = random.Next(QuestionList.Count);
                        
                        DisplayQnA(QuestionList[index]);
                        
                        
                        int SelectedAnswer = SelectAnswer();
                        bool answerIsCorrect = VerifyAnswer(SelectedAnswer, QuestionList[index]);
                        
                        DisplayResultInfo(answerIsCorrect);
                        
                        if (answerIsCorrect == true)
                        {
                            TotalScore++;
                        }
                        
                        ScoreTotal(TotalScore);
                        QuestionList.RemoveAt(index);
                    }
                }

                if (gm == GameMode.AddQuestion)
                {

                    List<QnA> QuestionList = new();
                    var qna = GenerateQuestion();
                    QuestionList.Add(qna);

                    WriteQnAList(QuestionList, path);
                    LoadQnAList(path);


                    if (AddMoreQuestion())
                    {
                      GenerateQuestion();
                    }
                    AddMoreQuestionsEndMessage();
                    break;
                 
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