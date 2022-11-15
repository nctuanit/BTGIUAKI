using BTGIUAKI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTGIUAKI.Entitys
{
    public class UserEntity
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public Role role { get; set; } 
        
    }
}
