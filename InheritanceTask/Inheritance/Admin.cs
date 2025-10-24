using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Inheritance
{
    internal class Admin : User
    {
        private bool IsSuperAdmin;

        public Admin(string username, string password,  bool isSuperAdmin, string section, string email = null) : base(username, password, email)
        {
            this.isSuperAdmin = isSuperAdmin;
            this.Section = section;
        }
        public bool isSuperAdmin { get; set; }
        public string Section { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"IsSuperAdmin: {IsSuperAdmin}");
            Console.WriteLine($"Section: {Section}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
