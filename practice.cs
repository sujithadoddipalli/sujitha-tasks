using System;
class Programs
{
    static void Main(string[] args)
    {
        Int32 val1 = 20, val2 = 10;
        bool status = true;
        //arthmetic operator
        Console.WriteLine(val1 + val2);
        Console.WriteLine(val1 - val2);
        Console.WriteLine(val1 * val2);
        Console.WriteLine(val1 / val2);
        Console.WriteLine(val1 % val2);
        Console.WriteLine(++val1);//increment operator
        Console.WriteLine(--val2);//decement operator
        //relational operator
        Console.WriteLine(val1 == val2);
        Console.WriteLine(val1 != val2);
        Console.WriteLine(val1 < val2);
        Console.WriteLine(val1 > val2);
        Console.WriteLine(val1 <= val2);
        Console.WriteLine(val1 >= val2);
        //logical operator
        Console.WriteLine(!status);
        
    }
}