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
                    double Total = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        List<QnA> QuestionList1 = GenerateQnAList();
                        var random = new Random();
                        int index = random.Next(QuestionList1.Count);
                        DisplayQnA(QuestionList1[index]);
                        int SelectedAnswer = SelectAnswer();
                        bool result = VerifyAnswer(SelectedAnswer, QuestionList1[index]);
                        
                        if (result == true)
                        {
                            Total++;
                        
                        Console.WriteLine("Your result: " + Total);
                        }

                    }

                    if (gm == GameMode.AddQuestion)
                    {
                        //do question adding stuff
                        List<QnA> QuestionList = CreateQuestions();
                        WriteQnAList(QuestionList, path);
                        LoadQnAList(path);
                    }
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