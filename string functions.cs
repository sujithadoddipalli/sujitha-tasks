//integer(int)  
using System;

class integer
{
    static void Main(string[]args)
    {
        int num = 10;//integer declaration(whole) //num- variable//int - data type
        double d = 10.99; //  double D ,(decimal number)
        Boolean bol = false; 
        string s = "Hello";
        Console.WriteLine(num);//write the integer value to the console
        Console.WriteLine(d);
        Console.WriteLine(bol);
        Console.WriteLine(s);
    }
}


////////////////////////////////////////////////////////////////////
/*
//oprators
using System;

class operators
{
    static void Main(string[] args)
    {
        int num = 30;
        int num2 = 20;
        bool b=true;
        Console.WriteLine(num+num2);//+,_,*,/,%,++,-- // artmetic operators
        Console.WriteLine(num>num2);//==,!=,>,<,>=,<= //relational operators
        //Console.WriteLine(num || num2);//&&,!,|| //logical operators

    }
}
*/
////////////////////////////////////////////////////////////////////
//If & else statements
/*using System;

class ifstatement
{
    static void Main(string[] args)
    {
        int i = 10;
        if (i < 9)
        {
            Console.WriteLine("value is less than 9");//stmt for if condition
        }
        else
        {
            Console.WriteLine("value is greater than 9"); //stmt for else condition
        }
     }
 }
 */
//////////////////////////////////////////////////////////////
//switch
/*
using System;

class switchstmt
{
    static void Main(string[]args)
    {
        int day = 4;
        switch (day)//switch stmt declaration
        {
            case 1: Console.WriteLine("Sunday");//code stmt
                break;
           case 2: Console.WriteLine("Monday"); //case-Case statements are used to set different conditions
                break;
            case 3:Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
                default: Console.WriteLine("differnt day");
                break;
        }
    }
}

*/
///////////////////////////////////////////////////////////////////////////////////
//for loop
/*
using System;

class forloop
{
    static void Main(string[]args)
    {
        int i = 5;
        for(int j = 0; j < i; j++)
        {
            Console.WriteLine(j);
        }
    }
}
    
*/
////////////////////////////////////////////////////
//for each
/*
using System;

class foreachstmt
{
static void Main(string[]arge)
    {
        int[] value = {1,2,3,4,5};
        foreach(int i in value)
        {
            Console.WriteLine(i);
        }
    }
}
    
*/
///////////////////////////////////////////////////////////////////////////////////////////
//while loop
/*
using System;

class whillloopstmt
{
    static void Main(string[] args)
    {
        int val = 3, i = 0;
        while(i < val)
            {
            Console.WriteLine(i);
            i++;
        }
    } 
    
}

*/
////////////////////////////////////////////////////////////////////////////////////
//revers
/*
using System;

class reverse
{
      static void Main(string[]args)
    {
        int rev = 0,r, n=179;
        while (n != 0) 
        {
            r = n % 10;//9
            rev = rev * 10 + r;//0*10+9=9
            n = n / 10; //179/10=17
        }
        Console.WriteLine(rev);

    }
}
*/
///////////////////////////////////////////////////////////////////////////////////
//string -storing the text
//string length

/*using System;

class stringlength
{
    static void Main(string[]args)
    {
        string txt = "hi this is sujitha";
        Console.WriteLine("length of the string is:"+txt.Length);
    }
}
*/
//////////////////////////////////////////////////////////////////////////////////////
//To upper and To lower
/*using System;

class touuperandlower
{
    static void Main(string[]args)
    {
        string txt = " HELLOW sujitha";
        Console.WriteLine(txt.ToUpper());
        Console.WriteLine(txt.ToLower());
    }
}
*/
/////////////////////////////////////////////////////////////////////////////////////////
//string concatenation
/*
using System;

class stringconcatenation
{
    static void Main(string[] args)
    {
        string firstname = "D";
        string lastname = "sujitha";
        string name = firstname + " " +lastname;
        Console.WriteLine(name);
    }
}

*/
/////////////////////////////////////////////////////////////////////
//string.concat
/*
using System;

class stringconcat
{
    static void Main(string[] args)
    {
        string firstname = "D";
        string lastname = "sujitha";
        string name = string.Concat(firstname+"." +lastname);
        Console.WriteLine(name);    
       
    }
}
*/
/////////////////////////////////////////////////////////////////////////////
//string interpolation
/*
using System;

class stringconcat
{
    static void Main(string[] args)
    {
        string firstname = "D";
        string lastname = "sujitha";
        string name = $"myfull name is :{firstname} {lastname}";
       
        Console.WriteLine(name);
     }
}
*/
//////////////////////////////////////////////////////////////////////////////
//Access string - its reffering to its index number inside square brackets[]
/*
using System;

class Accessstringstmt
{
    static void Main(string[]args)
    {
        string mystring = "madam";
        Console.WriteLine(mystring[3]);
     
    }
}
*/
///////////////////////////////////////////////////////////
//sub string -located of "m" position
/*
using System;

class substringstmt
{
    static void Main(string[] args)
    {
        string name = "MADAM";
        int charpos = name.IndexOf("D");
        Console.WriteLine(charpos);
    }
}
*/

////////////////////////////////////////////////////
//Arrays(1-D array)
/*
using System;

class substringstmt
{
static void Main(string[] args)
    {
        int size = 6;
        int[] arr = new int[size];
        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        arr[3] = 4;
        arr[4] = 5;
        arr[5] = 6;
        for(int i = 0; i < size; i++)
        {
            Console.WriteLine(arr[i]);
        }
             
    }

    }
/*
