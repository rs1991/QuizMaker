﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    internal class Modes
    {

        public enum GameMode
        {
            Play,
            AddQuestion
        }

        public static GameMode GetGameMode()
        {
            while (true) //until the input is valid
            {
                Console.WriteLine("Select the game mode to play [1 to play] or [2 to add questions]");
                int gameChoice = Convert.ToInt32(Console.ReadLine());

                if (gameChoice == 1)
                {
                    return GameMode.Play;
                }
                if (gameChoice == 2)
                {
                    return GameMode.AddQuestion;
                }

                Console.WriteLine("Please select a valid choice");

            }

        }

        public static void DisplayGameMode(GameMode mode)
        {
            switch (mode)
            {
                case GameMode.Play:
                    Console.WriteLine("Play");
                    break;
                case GameMode.AddQuestion:
                    Console.WriteLine("Add questions");
                    break;
            }
        }

    }
}