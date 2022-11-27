using Domain.Models;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWithException.AccountController
{
    public class AccountController
    {
        public static void Login()
        {
            try
            {
                AccountService account = new AccountService();
                
                    Console.WriteLine("Enter Username :");

                    string? username = Console.ReadLine();

                    Console.WriteLine("Enter Email :");

                    string? email = Console.ReadLine();

                    Console.WriteLine("Enter Password :");

                    string? password = Console.ReadLine();

                    var result = account.CheckLogin(new User(username, email, password));

                    if (result == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Successful entry .");
                    }
                    else
                    {
                        Console.WriteLine("Girish Ugursuzdur");
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
