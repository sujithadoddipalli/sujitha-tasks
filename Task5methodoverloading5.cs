using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class persion
    {
        public void add(int a, int b,int c)
        {
            Console.WriteLine("adding three integer parameters");
            Console.WriteLine(a + b + c);
        }
        public void add(float a, float b)
        {
            Console.WriteLine("adding two float parameters");
            Console.WriteLine(a + b);
        }
        public void add(string s1, string s2)
        {
            Console.WriteLine("adding two string parameters");
            Console.WriteLine(s1 + s2);
        }
        public static void Main()
        {
            persion persion = new persion();    
            persion.add(1, 2, 3);
            persion.add(2.5f, 3.5f);
            persion.add("Accion", "labs");

        }

        }
    
