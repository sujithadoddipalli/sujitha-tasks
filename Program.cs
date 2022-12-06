using System;

namespace MyApplication
{
    class persion//class
    {
        string name = "rani";
        int age = 28;

        public static void main(string[] args)
        {
            persion p = new persion();
            Console.WriteLine(p.name);
            Console.WriteLine(p.age);
        }
    }
}