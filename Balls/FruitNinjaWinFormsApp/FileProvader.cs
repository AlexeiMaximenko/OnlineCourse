using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace FruitNinjaWinFormsApp
    {
    public static class FileProvader
        {
        private static string path = "maxScore.json";
        public static void SetScore(int score)
            {
            var serializeScore = JsonConvert.SerializeObject(score.ToString(), Formatting.Indented);
            SaveFile(serializeScore);
            }
        public static string GetScore()
            {
            if (!CheckHaveFile())
                {
                return null;
                }
            var streamReader = new StreamReader(path, Encoding.UTF8);
            var score = streamReader.ReadToEnd();
            streamReader.Close();
            return JsonConvert.DeserializeObject(score).ToString();
            }
        public static bool CheckHaveFile()
            {
            return File.Exists(path);
            }
        private static void SaveFile(string text)
            {
            var streamWriter = new StreamWriter(path, false, Encoding.UTF8);
            streamWriter.WriteLine(text);
            streamWriter.Close();
            }
        }
    }

