using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    internal class Cat : Animal
    {
        public string Color { get; set; }
        public Cat(string name, int age, string sound, string color): base(name,age,sound)
        {
            this.Color = color;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Sound: {Sound}, Color: {Color}");
        }
    }
}
