using System;
using System.IO;
using System.Linq;

namespace GeniyIdiot
    {
    public class ConsoleData
        {
        public static void Show()
            {
            var readPath = "..//result.txt";
            if (!File.Exists(readPath))
                {
                Console.WriteLine("Тест еще не был пройден!");
                return;
                }
            var hr = "_________________________________________________________________________";
            Console.WriteLine(hr);
            Console.Write("|{0,-40}", "Фамилия Имя Отчество");
            Console.Write("|{0,-21}", "Правильные ответы");
            Console.WriteLine("|{0,-9}|", "Диагноз");
            Console.WriteLine(hr);

            var line = FileSystem.Get(readPath).Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < line.Count(); i++)
                {
                var item = line[i].Split(';');
                Console.WriteLine(String.Format("|{0,-39} |{1,-20} |{2,-9}|", item[0], item[1], item[2]));
                }
            Console.WriteLine(hr);
            }
        public static void ShowListOfTxt(string path)
            {
            var items = FileSystem.Get(path).Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < items.Count(); i++)
                {
                Console.WriteLine($"{i + 1}) {items[i]}");
                }
            }
        }
    }