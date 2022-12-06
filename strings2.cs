/*using System;
class stringvsString
{  
    static void Main(string[] args)
{
    string s1 = "hello";

    char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };
    string s2 = new string(ch);

    Console.WriteLine(s1);
    Console.WriteLine(s2);
}  
}  
*/
/*
using System;
//class CompareandCompareOrdinal
class compareand
{
    public static void Main(string[] args)
    {
        string s1 = "hello";
        string s2 = "hello";
        string s3 = "happy";
        string s4 = "welcome";

        Console.WriteLine(string.Compare(s1, s2)); //s1==s2 -->0
        Console.WriteLine(string.Compare(s2, s3));//s1>s2 -->+ve
        Console.WriteLine(string.Compare(s3, s4));//s1<s2 -->-ve it will print
        Console.WriteLine(string.CompareOrdinal(s1, s2));
        Console.WriteLine(string.CompareOrdinal(s1, s3));
        Console.WriteLine(string.CompareOrdinal(s1, s4));
    }
}

*/
/*
using System;
class compareto1
{
    public static void Main(string[] args)
    {
        string s1 = "hi";
        string s2 = "hi";
        string s3 = "cs";
        Console.WriteLine(s1.CompareTo(s2));
        Console.WriteLine(s2.CompareTo(s3));
    }
}
*/
/*
using System;
class copyTo1
{
    public static void Main(string[] args)
    {
        string s1 = "Hello sir How Are You?";
        char[] ch = new char[15];
        s1.CopyTo(10, ch, 0, 12);
        Console.WriteLine(ch);
    }
}
*/
/*
using System;
class endswith
{
    public static void Main(string[] args)
    {
        string s1 = "reddy";
        string s2 = "ddy";
        string s3 = "ks";
        Console.WriteLine(s1.EndsWith(s2));
        Console.WriteLine(s1.EndsWith(s3));
    }
}

*/
/*
using System;
class gettypeandtpeofcode
{
    public static void Main(string[] args)
    {
        string s1 = "Hello  sir";
        Console.WriteLine(s1.GetType());
        Console.WriteLine(s1.GetTypeCode());
    }
}
*/
/*
using System;

class isinterned
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C#";
        string s2 = string.Intern(s1);
        string s3 = string.IsInterned(s1);
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
    }
}
*/
