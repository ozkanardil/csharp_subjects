using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousPets
{
    internal class Pet
    {
        public string Name { get; set; }
        public PetTypes Type { get; set; }
        public int Age { get; set; }

        public Pet(string name, PetTypes type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
    }
}
