using System;

namespace GeniyIdiot
    {
    public class ConsoleInputHelper
        {
        public static int ProtectedNumber()
            {
            var input = Console.ReadLine();
            var defense = int.TryParse(input, out var correctAnswer);
            if (defense == false)
                {
                while (defense == false)
                    {
                    Console.WriteLine("Пожалуйста, введите число!");
                    Console.Write("Введите еще раз ответ: ");
                    input = Console.ReadLine();
                    defense = int.TryParse(input, out correctAnswer);
                    }

                }

            return correctAnswer;
            }

        public static string NotEmpty()
            {
            var readLine = Console.ReadLine();
            if (readLine == "")
                {
                while (readLine == "")
                    {
                    Console.WriteLine("Поле не может быть пустым!");
                    readLine = Console.ReadLine();
                    }
                }
            return readLine;
            }
        }
    }
