using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Consoleclasstask
{


    public class Student : Person

    {
        public int StudentId;
        private int _point;
        public int Point
        {
            get { return _point; }
            set
            {


                if (value >= 0 && value<= 100)
                {
                    _point = value;
                }
                else
                {
                    Console.WriteLine("Eded uygun deyil");
                }


            }
        }
              

      
        public Student(string name, string surname, byte age, int studentId, int point) : base(name, surname, age)

        {
            StudentId = studentId;
            Point = point;
            
        }
       
        public void Showfullinfo()
        {
         Console.WriteLine($"Name:{Name}\nSurname:{Surname}\nAge:{Age}\nStudentId:{StudentId}\nPoint:{Point}");
        }
    }
    
    } 
    

