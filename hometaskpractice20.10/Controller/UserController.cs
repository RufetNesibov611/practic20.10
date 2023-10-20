using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace hometaskpractice20._10.Controller
{
    public class UserController
    {
        private readonly UserService _userService;
        public UserController()
        {
            _userService = new UserService();

        }
        public void LoginUsers()
        {
            Console.WriteLine("Add email : ");
            string email = Console.ReadLine();

            Console.WriteLine( "Add password : ");
            string password = Console.ReadLine();

            var result = _userService.LoginUsers(email,password);
            Console.WriteLine(result);




        }
    }
}
