using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    internal class Dog:Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age,string sound, string breed) : base(name , age, sound)
        {
            Breed = breed;
        }
        public void GetInfo()
        { 
            Console.WriteLine($"Name: {Name}, Age: {Age}, Sound: {Sound}, Breed: {Breed}");
        }
    }

}
