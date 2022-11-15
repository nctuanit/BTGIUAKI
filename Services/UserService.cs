using BTGIUAKI.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTGIUAKI.Services
{
    public class UserService
    {
        private static UserService instance;
        private static string path = "user.txt";
        public static UserService gI()
        {
            if (instance == null)
            {
                instance = new UserService();
            }
            return instance;
        }
        public List<UserEntity> read()
        {
           return  FileService.ReadFile<List<UserEntity>>(path);
        }
        public UserEntity login(string userName, string password)
        {
            return read().FirstOrDefault(x => x.userName == userName && x.password == password);
        }
        public void Add(UserEntity user)
        {
            var list = read();
            list.Add(user);
            FileService.WriteFile(path, list);
        }
        public void Update(UserEntity user)
        {
            var list = read();
            var index = list.FindIndex(x => x.userId == user.userId);
            list[index] = user;
            FileService.WriteFile(path, list);
        }
        public void Delete(int userId)
        {
            var list = read();
            var index = list.FindIndex(x => x.userId == userId);
            list.RemoveAt(index);
            FileService.WriteFile(path, list);
        }
        
    }
}
