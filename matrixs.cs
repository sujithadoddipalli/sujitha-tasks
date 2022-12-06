using System;
class Mathoperatingsystem
{
    int a = 20;
    int b = 10;
    int result1, result2, result3, result4;

    public static void Main(string[] args)
    {

        Mathoperatingsystem m = new Mathoperatingsystem();
        Mathoperatingsystem n = new Mathoperatingsystem();
        Mathoperatingsystem o = new Mathoperatingsystem();
        Mathoperatingsystem p = new Mathoperatingsystem();

        Console.WriteLine("addition of two numbers" + n.result2);
        Console.WriteLine("subtraction of two numbers" + n.result2);
        Console.WriteLine("multipulication of two numbers" + o.result3);
        Console.WriteLine("division of two numbers" + p.result4);

    }
    public Mathoperatingsystem()
    {

        result1 = a + b;
        result2 = a - b;
        result3 = a * b;
        result4 = a / b;

    }