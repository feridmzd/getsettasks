using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleclasstask
{


    public class Doctor : Human
    {
        public string Speciality { get; set; }
        private int _experience;

        public int Experience
        {
            get { return _experience; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Tecrube olmalidir");
                    
                }
                _experience = value;
            }
        }

        public Doctor(string name, string surname, string gender, int age, string speciality, int experience)
            : base(name, surname, gender, age)
        {
            Speciality = speciality;
            Experience = experience;
        }

        public new string GetInfo()
        {
            return $"{base.GetInfo()} Speciality:{Speciality}\nExperience:{Experience}years";
        }

        public new void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }

    }
}
