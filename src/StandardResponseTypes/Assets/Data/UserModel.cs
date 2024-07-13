using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardResponseTypes.Assets.Data
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<UserModel> ListUsers()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel { Id = 1, Name = "User Name1" });
            users.Add(new UserModel { Id = 2, Name = "User Name2" });
            users.Add(new UserModel { Id = 3, Name = "User Name3" });

            return users;
        }
    }
}
