//Strings
/*

//1) string vs String

using System;  

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

//2) String Compare()


using System;    
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "hello";
        string s2 = "hello";
        string s3 = "jave";
        string s4 = "csharp";

        Console.WriteLine(string.Compare(s1, s2));
        Console.WriteLine(string.Compare(s2, s3));
        Console.WriteLine(string.Compare(s3, s4));
    }
}
*/
/*
//3) String CompareOrdinal()
 
using System;    
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "hello";
        string s2 = "hello";
        string s3 = "csharp";
       
        Console.WriteLine(string.CompareOrdinal(s1, s2));
        Console.WriteLine(string.CompareOrdinal(s1, s3));
   
    }
}
*/
/*

//4) String CompareTo()

using System;    
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "hello";
        string s2 = "hello";
        string s3 = "csharp";
        Console.WriteLine(s1.CompareTo(s2));
        Console.WriteLine(s2.CompareTo(s3));
    }
}
*/
/*
//5) String Concat()

using System;
class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello ";
        string s2 = "C#";
        Console.WriteLine(string.Concat(s1, s2));
    }
}
*/
/*
//6) String Contains()

using System;    
    public class StringExample
{
    public static void Main(string[] args)
    {
        string s1 = "Hello ";
        string s2 = "He";
        string s3 = "Hi";
        Console.WriteLine(s1.Contains(s2));
        Console.WriteLine(s1.Contains(s3));
    }
}
*/
/*
//7) String Copy()

using System;    
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello ";
        string s2 = string.Copy(s1);
        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}
*/
/*
//8) String CopyTo()

using System;    
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello C+, How Are You?";
        char[] ch = new char[15];
        s1.CopyTo(10, ch, 0, 12);
        Console.WriteLine(ch);
    }
}
*/
/*
//9) create string


using System;  
 class Test
    {
       static void Main(string[] args)
        {

            // create string
            string str1 = "C# Programming";
            string str2 = "program";

            // print string
            Console.WriteLine(str1);
            Console.WriteLine(str2);
       }
    }
*/
/*

//10) String EndsWith()

using System;    
class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello";
        string s2 = "llo";
        string s3 = "CC";
        Console.WriteLine(s1.EndsWith(s2));
        Console.WriteLine(s1.EndsWith(s3));
    }
}
*/
/*
//11) String Equals()

using System;    
   class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello";
        string s2 = "Hello";
        string s3 = "Bye";
        Console.WriteLine(s1.Equals(s2));
        Console.WriteLine(s1.Equals(s3));
    }
}
*/
/*
//12) String Format()

using System;    
public class StringExample
{
    public static void Main(string[] args)
    {

        string s1 = string.Format("{0:D}", DateTime.Now);
        Console.WriteLine(s1);
    }
}
*/
/*
//13) String GetEnumerator()
using System;    
class StringExample
{
    static void Main(string[] args)
    {
        string s2 = "Hello sir";
        CharEnumerator ch = s2.GetEnumerator();
        while (ch.MoveNext())
        {
            Console.WriteLine(ch.Current);
        }
    }
}
*/
/*
//14)String GetHashCode()
using System;    
class StringExample
{
    static void Main(string[] args)
    {
        string s2 = "Hello sir";
        CharEnumerator ch = s2.GetEnumerator();
        while (ch.MoveNext())
        {
            Console.WriteLine(ch.Current);
        }
    }
}
*/
/*
//15) String GetType()

using System;    
class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello sir";
        Console.WriteLine(s1.GetType());
    }
}
*/
/*
//16) String GetTypeCode()

using System;    
     class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello sir";
        Console.WriteLine(s1.GetTypeCode());
    }
}
*/
/*
//17) String IndexOf()
using System;    
class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello C#";
        int index = s1.IndexOf('e');
        Console.WriteLine(index);
    }
}
*/
/*
//17) String Insert()

using System;    
     class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello how are you";
        string s2 = s1.Insert(5, "-");
        Console.WriteLine(s2);
    }
}
*/
/*
//18) String Intern(String str)

using System;   
          
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello friend";
        string s2 = string.Intern(s1);
        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}
*/
/*
//19) String IsInterned()

using System;   
          
    class StringExample
{
    static void Main(string[] args)
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
/*

//20) String IsNormalized()
using System;   
using System.Text;  
          
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hi friend";
        bool b1 = s1.IsNormalized();
        Console.WriteLine(s1);
        Console.WriteLine(b1);
    }
}
*/
/*
//21) String Normalize()

using System;   
using System.Text;  
 class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hi sir";
        string s2 = s1.Normalize();
        Console.WriteLine(s2);
    }
}
*/
/*
//22) String IsNullOrEmpty()

using System; 
    
    class StringExample

    {
        static void Main(string[] args)
        {
            string s1 = "Hello C#";
            string s2 = "";
            bool b1 = string.IsNullOrEmpty(s1);
            bool b2 = string.IsNullOrEmpty(s2);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
    }


*/
/*
//23) String IsNullOrWhiteSpace()

using System;   
     class StringExample
{
     static void Main(string[] args)
    {
        string s1 = "Hello";
        string s2 = "";
        string s3 = " ";
        bool b1 = string.IsNullOrWhiteSpace(s1);
        bool b2 = string.IsNullOrWhiteSpace(s2);
        bool b3 = string.IsNullOrWhiteSpace(s3);
        Console.WriteLine(b1);       // returns False   
        Console.WriteLine(b2);       // returns True   
        Console.WriteLine(b3);       // returns True   
    }
}
*/
/*
//24) String Join()

using System;   
    class StringExample
{
    static void Main(string[] args)
    {
        string[] s1 = { "Hello", "sir", "how are ", "you" };
        string s3 = string.Join("-", s1);
        Console.WriteLine(s3);
    }
}
*/
/*
//25) String LastIndexOf()

using System;   
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello sir";
        int index = s1.LastIndexOf('l');
        Console.WriteLine(index);
    }
}
*/
/*
//26) String LastIndexOfAny()
using System;   
class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "sujithareddy";
        char[] ch = { 'r', 'd' };
        int index = s1.LastIndexOfAny(ch);//Finds 'r' at the last  
        Console.WriteLine(index);
    }
}
*/
/*
//27) String PadLeft()
using System;   
              
    class StringExample
{
     static void Main(string[] args)
    {
        string s1 = "hi sir how are you";
        string s2 = s1.PadLeft(10);  
        Console.WriteLine(s2);
    }
}
*/
/*
//28)String PadRight()

using System;   
              
    public class StringExample
{
    public static void Main(string[] args)
    {
        string s1 = "Hello sir";
        string s2 = s1.PadRight(15);
        Console.Write(s2); 
        Console.Write("JavaTpoint");
    }
}
*/
/*
//29)String Remove()

using System;   
    public class StringExample
{
    public static void Main(string[] args)
    {
        string s1 = "Hello";
        string s2 = s1.Remove(2);
        Console.WriteLine(s2);
    }
}
*/
/*
//30) String Replace()

using System;   
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello sar";
        string s2 = s1.Replace('a', 'i');
        Console.WriteLine(s2);
    }
}
*/
/*
//31) String Split()

using System;   
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "welcome to office";
        string[] s2 = s1.Split(' ');
        foreach (string s3 in s2)
        {
            Console.WriteLine(s3);
        }
    }
}
*/
/*
//32) String StartsWith()

using System;   
          
 class StringExample
{
     static void Main(string[] args)
    {
        string s1 = "Hi";
        bool b1 = s1.StartsWith("h");
        bool b2 = s1.StartsWith("H");
        Console.WriteLine(b1);
        Console.WriteLine(b2);
    }
}
*/
/*
//33) String SubString()
using System;   
              
    class StringExample
{
     static void Main(string[] args)
    {
        string s1 = "ravi reddy";
        string s2 = s1.Substring(5);
        Console.WriteLine(s2);
    }
}
*/
/*
//34) String ToCharArray()
using System;   
          
class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "welcome to india";
        char[] ch = s1.ToCharArray();
        foreach (char c in ch)
        {
            Console.WriteLine(c);
        }
    }
}
*/
/*
//35) String ToLower()

using System;   
              
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "WELL COME";
        string s2 = s1.ToLower();
        Console.WriteLine(s2);
    }
}
*/
/*
//36) String ToLowerInvariant()

using System;   
  
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "HELLO WELCOME TO INDIA";
        string s2 = s1.ToLowerInvariant();
        Console.WriteLine(s2);
    }
}
*/
/*
//36) String ToString()

using System;   
          
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "WELL COME";
        int a = 123;
        string s2 = s1.ToString();
        string s3 = a.ToString();
        Console.WriteLine(s2);
        Console.WriteLine(s3);
    }
}
*/
/*
//37) String ToUpper()

using System;   
          
class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello ";
        string s3 = s1.ToUpper();
        Console.WriteLine(s3);
    }
}
*/
/*
//38) String ToUpperInvariant()

using System;   
              
    class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello";
        string s3 = s1.ToUpperInvariant();
        Console.WriteLine(s3);
    }
}
*/
/*
//39) String Trim()

using System;   
      
class StringExample
{
    static void Main(string[] args)
    {
        string s1 = "Hello   C#";
        string s2 = s1.Trim();
        Console.WriteLine(s2);
    }
}
*/
/*
//40) tring TrimEnd()

using System;   
          
    public class StringExample
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C+";
        char[] ch = { '+' };
        string s2 = s1.TrimEnd(ch);
        Console.WriteLine(s2);
    }
}
*/
/*
//41) String TrimStart()
using System;   
    public class StringExample
{
    public static void Main(string[] args)
    {
        string s1 = "Hello C#";
        char[] ch = { 'H' };
        string s2 = s1.TrimStart(ch);
        Console.WriteLine(s2);
    }
}
*/

/*
//42) GetEnumerator() Method

using System;
class GetEnumeratorMethod
{
        static void Main(string[] args)
        {
            string s = "happy";
            CharEnumerator ch = s.GetEnumerator();

            while (ch.MoveNext())
            {
                Console.WriteLine(ch.Current);
            }
        }
    }
*/