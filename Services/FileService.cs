using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BTGIUAKI.Entitys;
using Newtonsoft.Json;
using BTGIUAKI.Enums;
namespace BTGIUAKI.Services
{
    public class FileService
    {
        private static string FILE_NAME_USER = "user.txt";
        private static string FILE_NAME_CONFIG = "config.txt";
        public static ConfigEntity ReadConfig()
        {
            return ReadFile<ConfigEntity>(FILE_NAME_CONFIG);
        }
        public static void WriteConfig(ConfigEntity config)
        {
            WriteFile(FILE_NAME_CONFIG, config);
        }
        public static void WriteFile<T>(string filePath,T users)
        {
            try
            {
                string data = JsonConvert.SerializeObject(users);
                File.WriteAllText(filePath, data);
            }
            catch (Exception)
            {
            }
        }
        public static T ReadFile<T>(string filePath)
        {
            try
            {
                string data = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T>(data);
            }
            catch (Exception)
            {
                return default(T);
            }
        }
        private static bool IsExistFile(string filePath)
        {
            return File.Exists(filePath);
        }
        public static void Init()
        {
            if (!IsExistFile(FILE_NAME_USER))
            {
                List<UserEntity> users = new List<UserEntity>();
                var user = new UserEntity();
                user.userId = 1;
                user.fullName = "Nguyễn Châu Tuấn";
                user.userName = "admin";
                user.password = "123456";
                user.role = Role.ADMIN;
                users.Add(user);
                WriteFile(FILE_NAME_USER, users);
            }
            if (!IsExistFile(FILE_NAME_CONFIG))
            {
                var config = new ConfigEntity();
                config.isSavePass = false;
                config.password = "";
                WriteFile(FILE_NAME_CONFIG, config);
            }
            
        }
    }
}
