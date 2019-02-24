using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTriple
{
    public class Users
    {
        public List<User> users = new List<User>() { new User{
                 login = "Leha",
                 password = "1"
             },new User {
                login = "Ivan",
                password = "12"
            },new User  {
                login = "Oleg",
                password = "123"
            }};

        public int currentId { get; set; }
        //public Users() {

        //users.Add(new User
        //     {
        //         login = "Leha",
        //         password = "1"
        //     });
        //    users.Add(new User
        //    {
        //        login = "Ivan",
        //        password = "12"
        //    });
        //    users.Add(new User
        //    {
        //        login = "Oleg",
        //        password = "123"
        //    });
        //}
    }

}
