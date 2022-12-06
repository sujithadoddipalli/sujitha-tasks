//Enumeration
/*
using System;
namespace ConsoleApplication1
{
    enum month
    {
        jan,
        feb,
        mar,
        apr,
        may
     }

    class enumeration1
    {

        
        static void Main(string[] args)
        {

            Console.WriteLine("The value of jan in month " + "enum is " + (int)month.jan);
            Console.WriteLine("The value of feb in month " + "enum is " + (int)month.feb);
            Console.WriteLine("The value of mar in month " + "enum is " + (int)month.mar);
            Console.WriteLine("The value of apr in month " + "enum is " + (int)month.apr);
            Console.WriteLine("The value of may in month " + "enum is " + (int)month.may);
        }

    }
}
*/
/*
using System;
namespace ConsoleApplication1
{
    enum days { sun =2, mon, tue, wed, thu, fri, sat }

    class enumeration2
    {
        static void Main(string[] args)
        {
            int mynumber=(int)days.fri;
            Console.WriteLine(mynumber);
        }
    }
}
*/

//interface

using System;


interface book1
{
    void display();
}
class textbook : book1
{

    public void display()
    {
        Console.WriteLine("number of pages in book");
    }
    class Program
    {
        static void Main(string[] args)
        {

            textbook t = new textbook();
            t.display();
        }
    }
}



