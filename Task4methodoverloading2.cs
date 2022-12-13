using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodaverloadinh2
{
    public class persion2
    {
        public void Display(int a, string b)
        {
            Console.WriteLine("int: {0}", a);
            Console.WriteLine("string: " + b);
        }
        public void Display(string b, int a)
        {
            Console.WriteLine("string: " + b);
            Console.WriteLine("int: {0}", a);
        }
        public static void Main(string[] args)
        {
            persion2 persion2 = new persion2();
            persion2.Display(100, "AccionLabs");
            persion2.Display("Accion", 300);
        }

    }
}
