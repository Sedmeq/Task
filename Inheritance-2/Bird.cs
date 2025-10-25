using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    internal class Bird : Animal
    {
        public float WingLength { get; set; }
        public Bird(string name, int age, string sound,float windLength): base(name,age,sound)
        {
            WingLength = windLength;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Sound: {Sound}, Wing Length: {WingLength}");
        }
    }
}
