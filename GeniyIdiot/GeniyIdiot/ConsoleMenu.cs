using System;

namespace GeniyIdiot
    {
    public class ConsoleMenu
        {
        public static void GetPrimary()
            {
            Console.WriteLine("Добро пожаловать в игру-тест \"Гений - Идиот!\"");
            Console.WriteLine("Чтобы начать игру напишите \"play\"");
            Console.WriteLine("Чтобы посмотреть результаты предыдущих игр напишите \"data\"");
            Console.WriteLine("Для добавления своего вопроса напишите \"add\"");
            Console.WriteLine("Если хотите удалить какой-либо вопрос напишите \"remove\"");
            }

        public static void InputPrimary()
            {
            for (; ; )
                {
                Console.Clear();
                GetPrimary();
                string textMenuSet = Console.ReadLine();
                if (textMenuSet == "data")
                    {
                    Console.Clear();
                    ConsoleData.Show();
                    Console.WriteLine("\nДля продолжени нажмите любую кнопку.");
                    Console.ReadKey();
                    continue;
                    }
                if (textMenuSet == "play")
                    {
                    Console.Clear();
                    break;
                    }
                if (textMenuSet == "add")
                    {
                    QuestionsAdd();
                    continue;
                    }

                if (textMenuSet == "remove")
                    {
                    QuestionsRemove();
                    Console.Clear();
                    continue;
                    }
                else
                    {
                    Console.WriteLine("Не правильный ввод!");
                    Console.WriteLine("Для продолжени нажмите любую кнопку.");
                    Console.ReadKey();
                    }
                }
            }

        public static void GetFinal()
            {
            Console.WriteLine("Хотите еще раз пройти тест? Введите \"restart\" для рестарта.");
            Console.WriteLine("Если вы хотите вернуться в меню введите \"menu\".");
            Console.WriteLine("Для того, чтобы выйти из игры напишите \"close\".");
            }

        public static bool InputFinal()
            {
            GetFinal();
            for (; ; )
                {
                var inputClose = Console.ReadLine();
                if (inputClose == "restart")
                    {
                    Program.user.ResetUserResult();
                    Console.Clear();
                    return true;
                    }
                if (inputClose == "menu")
                    {
                    Program.user.ResetUserResult();
                    return false;
                    }
                if (inputClose == "close")
                    {
                    Environment.Exit(0);
                    }
                else
                    {
                    Console.WriteLine("Не правильный ввод.");
                    continue;
                    }
                }
            }

        public static void QuestionsAdd()
            {
            for (; ; )
                {
                Console.Clear();
                Console.WriteLine("ДОБАВЛЕНИЕ ВОПРОСА");
                Console.WriteLine("для выхода напишите \"0\"\n");
                Console.WriteLine("Список имеющихся вопросов:");
                var numberQuestion = 1;
                var questionsList = QuestionsStorage.GetQuestions();
                foreach (var item in questionsList)
                    {
                    Console.WriteLine($"{numberQuestion}. {item.Text}");
                    numberQuestion++;
                    }
                Console.WriteLine("\nВведите ваш вопрос:");
                var question = ConsoleInputHelper.NotEmpty();
                if (question == "0")
                    {
                    break;
                    }
                Console.WriteLine("Теперь введите правильный ответ на вопрос:");
                var answers = ConsoleInputHelper.ProtectedNumber();
                if (answers == 0)
                    {
                    break;
                    }
                var newQuestion = new Question(question, answers);
                QuestionsStorage.Add(newQuestion);
                Console.Clear();
                Console.WriteLine("Хотите добавить еще вопрос? (y/n)");
                for (; ; )
                    {
                    var cancelCheck = ConsoleInputHelper.NotEmpty();
                    if (cancelCheck == "y")
                        {
                        Console.Clear();
                        break;
                        }
                    if (cancelCheck == "n")
                        {
                        Console.Clear();
                        return;
                        }
                    else
                        {
                        Console.WriteLine("Не правильный ввод!");
                        }
                    }
                }
            }

        public static void QuestionsRemove()
            {
            for (; ; )
                {
                Console.Clear();
                Console.WriteLine("УДАЛЕНИЕ ВОПРОСА");
                Console.WriteLine("для выхода напишите \"0\"\n");
                Console.WriteLine("Список имеющихся вопросов:");
                var numberQuestion = 1;
                var questionsList = QuestionsStorage.GetQuestions();
                foreach (var item in questionsList)
                    {
                    Console.WriteLine($"{numberQuestion}. {item.Text}");
                    numberQuestion++;
                    }

                Console.WriteLine("\nЧтобы удалить вопрос укажите его порядковый номер в строке ниже:");
                var userInput = ConsoleInputHelper.ProtectedNumber();
                for (; ; )
                    {
                    if (userInput == 0)
                        {
                        return;
                        }

                    if (userInput > QuestionsStorage.GetQuestions().Count || userInput < 1)
                        {
                        Console.WriteLine("Вопроса под этим номером не существует!");
                        userInput = ConsoleInputHelper.ProtectedNumber();
                        }
                    else
                        {
                        break;
                        }
                    }
                QuestionsStorage.Remove(userInput);
                Console.Clear();
                Console.WriteLine($"Вопрос под номером {userInput} успешно удален!");

                Console.WriteLine("Хотите удалить еще вопрос? (y/n)");
                for (; ; )
                    {
                    var cancelCheck = ConsoleInputHelper.NotEmpty();
                    if (cancelCheck == "y")
                        {
                        Console.Clear();
                        break;
                        }
                    if (cancelCheck == "n")
                        {
                        Console.Clear();
                        return;
                        }
                    else
                        {
                        Console.WriteLine("Не правильный ввод!");
                        }
                    }
                }
            }
        }
    }