using System;

namespace ClassTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            //var Fred = new Student();
            //Fred.Name = "Fred";
            //Fred.SAT = 1000;
            //var Wilma = new Student();
            //Wilma.Name = "Wilma";
            //Wilma.SAT = 2000;
            //var Barney = new Student();
            //Barney.Name = "Barney";
            //Barney.SAT = 1200;
            //Wilma.Print(1);
            //Fred.Print(2);
            //Barney.Print(3);
            //Barney.SAT += 20;
            //Console.WriteLine(Barney.Print(4));

            var a = 4;
            var b = 3;
            var mathlib = new MathLib();
            var addResult = mathlib.Add(a,b);
            var subResult = mathlib.Sub(a,b);
            var multResult = mathlib.Mult(a,b);
            var divResult = mathlib.Div(a,b);
            Console.WriteLine($"Answer is {addResult}");
            Console.WriteLine($"The Answer is {subResult}");
            Console.WriteLine($"The Answer is {multResult}");
            Console.WriteLine($"The Answer is {divResult}");
            var modResult = mathlib.Mod(a, b);
            Console.WriteLine($"The Remainder is {modResult}");

        }
    }
}
