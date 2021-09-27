using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTutorial
{
   class Student
    {
        public string Name { get; set; }

        private int _SAT;
        public int SAT {
            get { return _SAT; }
            set {
                if(value <400 || value > 1600)
                {
                    Console.WriteLine("Invalid SAT Score");

                }
                else
                {
                    this._SAT = value;
                }
            } 
        }

        public void Print()
        {
            Console.WriteLine($"{this.Name}, {this.SAT}");
        }
    }
}
