using System.IO;
using System.Text;

namespace GeniyIdiot
    {
    public class FileSystem
        {
        public static void Save(string writePath, string text)
            {
            var streamWriter = new StreamWriter(writePath, true, Encoding.UTF8);
            streamWriter.WriteLine(text);
            streamWriter.Close();
            }
        public static void Replace(string writePath, string text)
            {
            var streamWriter = new StreamWriter(writePath, false, Encoding.UTF8);
            streamWriter.WriteLine(text);
            streamWriter.Close();
            }

        public static string Get(string writePath)
            {
            var streamReader = new StreamReader(writePath, Encoding.UTF8);
            var value = streamReader.ReadToEnd();
            streamReader.Close();
            return value;
            }
        public static bool CheckHaveFile(string path)
            {
            return File.Exists(path);
            }
        }
    }