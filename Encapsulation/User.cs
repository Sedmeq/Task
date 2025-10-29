using System;
using System.Linq;

namespace Encapsulation
{
    internal class User
    {
        private static int _idCounter = 0;
        public int Id { get; }
        public string Fullname { get; set; }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Email bos ola bilmez!");
                }
                else
                {
                    _email = value;
                }
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password sertlerini odemir! Yeniden daxil edin:");
                }
            }
        }

        public int Age { get; set; }

        public User(string email, string password)
        {
            Id = _idCounter++;
            
            Email = email;
            Password = password;
            
        }

        public bool PasswordChecker(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsDigit) &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Email: {Email}");
        }
    }
}
