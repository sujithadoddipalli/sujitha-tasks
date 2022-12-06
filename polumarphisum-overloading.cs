/*// Abstract class
abstract class employee
{
   
    public abstract void softwarejob();
       public void coding()
    {
        Console.WriteLine("java");
    }
}


class persion : employee
{
    public override void softwarejob()
    {
        
        Console.WriteLine("job domain is");
    }
}

class Program
{
    static void Main(string[] args)
    {
       persion persion = new persion();
        persion.softwarejob();
        persion.coding();
       
    }
}


 */




/*
//Polymorphism
using System;

class program //class classname
{
    static void Main(string[] args)  //main method}
    {
        int a = 10;
        int b = 20;
        persion p = new persion(); //object
        p.Display();
        p.Display(a);
        p.Display(a,b);

    }

    public class persion
    {
     public void Display() //method
        {
            Console.WriteLine("display A and B");
        }
        public void Display(int a) //1st  method
        {
            Console.WriteLine("display values");
        }
        public void Display(int a, int b) //2nd method
        {
            Console.WriteLine("display A and B values");
        }
    }
}
*/

// Polymorphism

using System;


    class Polymorphism1
    {
        void display(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        void display(double f)
        {
            Console.WriteLine("Printing float: "+ f);
        }
        void display(string s)
        {
            Console.WriteLine("Printing string: "+ s);
        }
        static void Main(string[] args)
        {
            
        Polymorphism1 P = new Polymorphism1();
            
           P.display(500);
           P.display(500.263);
           P.display("power bi");
        }
    }
