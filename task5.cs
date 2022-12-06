using System;

class matrix
{
    int w, x, y, z;
    public static void Main(string[] args)
    {
        matrix m = new matrix();
    }
    public matrix()

    {
        int a, b;
        Console.WriteLine("first number is");
        a=Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("second number is");
        b=Convert.ToInt32(Console.ReadLine());

        w = a + b;
        Console.WriteLine("additon of two numbers", +w);
        x = a + b;
        Console.WriteLine("subtraction of two numbers", +x);
        y = a + b;
        Console.WriteLine("multipulication of two numbers", +y);
        z = a + b;
        Console.WriteLine("divesion of two numbers", +z);
    }

}

