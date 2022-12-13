using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static_constracter;

namespace static_constracter
{

    public class SavindAccounts
    {
        public int Aid, Abalence;
        public string name;
        public static int Maxwithdraw, ALimit;
        public SavindAccounts(int aid, int abalence, string name)
        {
            Aid = aid;
            Abalence = abalence;
            this.name = name;
        }
        static SavindAccounts()
        {
            Maxwithdraw = 1000;
            ALimit = 1000;
        }
        public static void Demomethod()
        {
            Console.WriteLine("Demo method is called");
        }
        public void DisplyDetails()
        {
            Console.WriteLine(Aid + "\t" + name + "\t" + Abalence);
            Console.WriteLine("maximum withdraw limit per day :{0}", Maxwithdraw);
            Console.WriteLine("ALimit transaction perday:{0}", ALimit);
        }
        public static void main()
        {
            SavindAccounts savindAccount = new SavindAccounts(1, 500, "sujitha");
            savindAccount.DisplyDetails();
        }
    }
}
