using GeniyIdiot.common;
using System;

namespace GeniyIdiot
    {
    internal class Program
        {
        public static User user = new User();

        private static void Main(string[] args)
            {
            for (; ; )
                {
                ConsoleMenu.InputPrimary();
                Console.WriteLine("Пожалуйста, введите ваше имя в строке ниже:");
                user.FirstName = ConsoleInputHelper.NotEmpty();
                Console.Clear();
                Console.WriteLine("Пожалуйста, введите вашу фамилию в строке ниже:");
                user.LastName = ConsoleInputHelper.NotEmpty();
                Console.Clear();
                Console.WriteLine("Пожалуйста, введите ваше отчество в строке ниже:");
                user.ThirdName = ConsoleInputHelper.NotEmpty();
                Console.Clear();

                var restartAppCheck = true;
                while (restartAppCheck == true)
                    {
                    var game = new Game(user);

                    while (!game.IsEnd())
                        {
                        var questions = game.PopRandomQuestion();
                        Console.WriteLine(game.GetNumberQuestionInfo());
                        Console.WriteLine(questions.Text);
                        Console.Write("Введите ответ: ");
                        var checkedReadLine = ConsoleInputHelper.ProtectedNumber();
                        game.SetUserAnswer(checkedReadLine);
                        Console.Clear();
                        }
                    game.SaveGameResult();
                    Console.WriteLine(game.GetUserCountRightAnswersInfo());
                    Console.WriteLine(game.GetEndGameInfo());

                    restartAppCheck = ConsoleMenu.InputFinal();
                    }
                }
            }
        }
    }