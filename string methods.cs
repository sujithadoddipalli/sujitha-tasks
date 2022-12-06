
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
/*using System;

class clone
{
    static void Main(string[]args)
    {
        string a = "saathvika";
        string b = (String)a.Clone();
        Console.WriteLine(b);
    }
}
*/
/*
// Concat
using System;

class Concat
{
    static void Main(string[] args)
    {
        string a = "saathvika";
        string b = "reddy";
        string c = "k";
        Console.WriteLine(string.Concat(a,b,c));
    }
}
*/
/*
//contains
using System;

class contains
{
    static void Main(string[] args)
    {
        string a = "saathvika reddy";//it will check praticular substring is present inside in a given string or not.
        string b = "reddy";
       Console.WriteLine(a.Contains(b));
    }
}
*/
/*
using System;

class copy1
{
    static void Main(string[] args)
    {
        string a = "saathvika";
        Console.WriteLine(string.Copy(a));
        //string b = string.Copy(a);
        //      Console.WriteLine(b);

    }
}
*/
/*
using System;

class Equals1
{
    static void Main(string[] args)
    {
        string a = "saathvika"; //its a and b steing is equal o/p is true or not equal o/p is false
        string b = "reddy";
        Console.WriteLine(a.Equals(b));
    }
}
*/


/*
using System;

class indexof1
{
    static void Main(string[] args)
    {
        string a = "saathvika"; //it will count the index is start with '0'(zero). 
        Console.WriteLine(a.IndexOf("a"));
        Console.WriteLine(a.IndexOf("h"));
    }
}
*/

/*
using System;

class insert
{
    static void Main(string[] args)
    {
        string a = "k.reddy";
        string b = a.Insert(2,"_saathvika_");
        Console.WriteLine(b);
       
    }
}
*/
/*
using System;

class replace1
{
    static void Main(string[] args)
    {
        string a = "k.reddy";
        string b = a.Replace("k.", "saathvika");
        Console.WriteLine(b);

    }
}
*/
/*
using System;

class substring1
{
    static void Main(string[] args)
    {
        string a = "k.saathvika";
        Console.WriteLine(a.Substring(2));

    }
}
*/
/*
using System;

class toupper1
{
    static void Main(string[] args)
    {
        string a = "saathvika";
        Console.WriteLine(a.ToUpper());
        Console.WriteLine(a.ToLower());
     }
}
*/
/*
using System;

class trim
{
    static void Main(string[] args)
    {
        string a = "   saathvika";
      // Console.WriteLine("enter the name"+ a.Trim());
       Console.WriteLine(a.Trim());
    }
}
*/
/*
using System;

class compare1
{
    static void Main(string[] args)
    {
        string a = "saathvika";
        string b = "saathvika";
        if(a == b)
        {
            Console.WriteLine("it will be true");
        }
        else
        {
            Console.WriteLine("it will be false");
        }
    }
}
*/
/*
//CompareTo Method
using System;

class CompareTo1
{
    static void Main(string[] args)
    {
        string a = "saathvika";
        string b = "sharan";
      //  if (a == b)
              // {
       //     Console.WriteLine("it will be true");
             // }
       // else
             //{
         //   Console.WriteLine("it will be false");
             // }
       Console.WriteLine(string.Compare(a, b));
     }
}
*/
/*
using System;
    class compareordinal1
    {
        static void Main(string[] args)
        {
            string str1 = "apple";
            string str2 = "cat";
        //Console.WriteLine(String.CompareOrdinal(str2, str1));
        int res = String.CompareOrdinal(str2, str1);
        Console.WriteLine("Difference is {0}", res);
    }
    }

*/
/*
using System;


    class endswith1
    {
        static void Main(string[] args)
        {
            string s1 = "sujitha reddy";
            string s2 = "reddy";
            string s3 = "D";

            Console.WriteLine(s1.EndsWith(s2));
            Console.WriteLine(s1.EndsWith(s3));
        }
    }
*/
/*
using System;


    class GetHashCode
    {
        static void Main(string[] args)
        {
            string s = "sujitha";
            Console.WriteLine(s.GetHashCode());
        }
    }
*/
/*
using System;



    class stringgettype
    {
        static void Main(string[] args)
        {
            string s = "wikimass";
            float fnum = 1.5f;
            int inum = 13;
            char ch = 'G';
            short snum = 56;

            Console.WriteLine(s.GetType());
            Console.WriteLine(fnum.GetType());
            Console.WriteLine(inum.GetType());
            Console.WriteLine(ch.GetType());
            Console.WriteLine(snum.GetType());
        }
    }
*/
