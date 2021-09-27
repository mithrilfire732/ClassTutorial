using System;

namespace ClassTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            var Fred = new Student();
            Fred.Name = "Fred";
            Fred.SAT = 1000;
            var Wilma = new Student();
            Wilma.Name = "Wilma";
            Wilma.SAT = 2000;
            var Barney = new Student();
            Barney.Name = "Barney";
            Barney.SAT = 1200;
            Wilma.Print();
            Fred.Print();
            Barney.Print();
        }
    }
}
