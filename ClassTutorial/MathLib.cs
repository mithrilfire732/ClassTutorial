using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTutorial
{
    class MathLib
    {
        //public MathLib(int i)
        //{

        //}
        public int Add( int num1, int num2)
        {
            return num1 + num2;
        }
        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Div(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }
            return num1 / num2;
        }
        public int Inc(int num1)
        {
            return ++num1;
        }
        public int Mod(int num1, int num2)
        {
            var answer = num1 / num2;
            var mod = num1 - answer * num2;
            return mod;
        }
    }
}
