using Domain.Models;
using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTraining.Controllers
{
    public class AccountController
    {
        public void Register()
        {
            try
            {
                Console.WriteLine("Add Username : ");

                string username = Console.ReadLine();

                Console.WriteLine("Add Email : ");

                string email = Console.ReadLine();

                if (email.Contains("@")) throw new Exception("Email doesn't have symbol @.");

                Console.WriteLine("Add password : ");

                string password = Console.ReadLine();

                IAccountService service = new AccountService();

                User newUser = new()
                {

                    Username = username,
                    Email = email,
                    Password = password

                };

                var result = service.Register(newUser);

                if(!result) throw new Exception("Email doesn't have symbol @.");

                Console.WriteLine("Succes");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetUserById()
        {
            try
            {
                IAccountService service = new AccountService();

                var result = service.UserGetById(null);

                Console.WriteLine(result.Username);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
