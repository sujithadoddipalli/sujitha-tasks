using System;

class matrix
{
    int a = 40;
    int b = 20;
    int w, x, y, z;

    public static void Main(string[] args)
    {
        matrix matrix m = new matrix();
    }
    public matrix()
    {
        w = a + b;
        Console.WriteLine(w);
        x = a - b;
        Console.WriteLine(x);
        y = a * b;
        Console.WriteLine(y);
        z = a / b;
        Console.WriteLine(z);
    }
}
