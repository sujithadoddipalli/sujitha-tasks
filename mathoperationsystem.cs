using System;
class Mathoperatingsystem
{
    int a = 20;
    int b = 10;
    int result1, result2, result3, result4;

    public static void Main(string[] args)
    {

        Mathoperatingsystem m = new Mathoperatingsystem();
        m.Matrix();
        Mathoperatingsystem n = new Mathoperatingsystem();
        n.Matrix();
        Mathoperatingsystem o = new Mathoperatingsystem();
        o.Matrix();
        Mathoperatingsystem p = new Mathoperatingsystem();
        p.Matrix();
    }
    public static void Matrix()
    {
        Console.WriteLine("addition of two numbers"  );
        Console.WriteLine("subtraction of two numbers" );
        Console.WriteLine("multipulication of two numbers");
        Console.WriteLine("division of two numbers" );

        result1 = a + b;
        result2 = a - b;
        result3 = a * b;
        result4 = a / b;

    }

}