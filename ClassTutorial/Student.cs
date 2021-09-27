﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTutorial
{
   class Student
    {
        public string Name { get; set; }

        private int _SAT =800;
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

        public string Print(int code)
        {
            return ($"Code: {code} name: {this.Name}, SAT: {this.SAT}");
        }
    }
}
