using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleclasstask
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Bele yas yoxdur");
                }
                age = value;
            }
        }

        public Human(string name, string surname, string gender, int age)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
        }

        public string GetInfo()
        {
            return $"Name: {Name}\nSurname:{Surname}\nGender:{Gender}\nAge:{Age}";
        }

        public void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }
    }
}
