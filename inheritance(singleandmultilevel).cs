//single inheritance
/*
using System;
class singleinheritance1
{
    
    public class A //base class
    {
        public int i = 10;
    }
    public class B :A //derived class
    {
        public int j = 10;
        public void n1()
        {
            Console.WriteLine(i+j);
        }
    }
    class C
    {
        public static void Main(string[] args)
        {
         B b1 = new B();
            b1.n1();
            Console.WriteLine();

        }
    }
}
*/



using System;

namespace mutilevelinheritance1
{
    class A : B
    {
        public void DisplayTwo()
        {
            Console.WriteLine("A-son");
        }
        static void Main(string[] args)
        {
            A a = new A();
            a.Display();
            a.DisplayOne();
            a.DisplayTwo();
            Console.Read();
        }
    }
    class C
    {
        public void Display()
        {
            Console.WriteLine("C-grandfather");
        }
    }
    class B : C
    {
        public void DisplayOne()
        {
            Console.WriteLine("B-father");
        }
    }
}