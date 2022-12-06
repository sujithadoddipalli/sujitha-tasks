using System;

namespace MyApplication
{
    class persion   // class
    {
        string name = "saathvika reddy";
        int age = 7;

        static void Main(string[] args)
        {
            persion myObj = new persion(); // object
            Console.WriteLine(myObj.name);
            Console.WriteLine(myObj.age);
        }
    }
}


