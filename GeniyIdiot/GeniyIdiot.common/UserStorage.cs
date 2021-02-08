using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace GeniyIdiot.common
    {
    public class UserStorage
        {
        private static string path = "result.json";
        public static void SaveUserData(User user, string writePath)
            {
            var saveText = $"{user.FirstName};{user.LastName};{user.ThirdName};{user.CountRightAnswers};{user.Diagnosis}";
            FileSystem.Save(writePath, saveText);
            }
        public static List<User> GetAllUserData()
            {
            var userList = new List<User>();
            if (FileSystem.CheckHaveFile(path))
                {
                var fullFile = FileSystem.Get(path);
                userList = JsonConvert.DeserializeObject<List<User>>(fullFile);
                return userList;
                }
            return userList;
            }

        public static void SaveUser(User user)
            {
            var users = GetAllUserData();
            users.Add(user);
            var serializeUsers = JsonConvert.SerializeObject(users, Formatting.Indented);
            FileSystem.Replace(path, serializeUsers);
            }
        }
    }
