using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalANDnamedParameters
{
   public class parametersON
    {
       public static void Main(string[] args)
        {
            parametersON P = new parametersON();
            P.NamedParameterFunction("James", "Bond");
            P.OptionalParameterFunction(20,10);
            P.OptionalParameterFunction(50);
        }
        //named parameter
        public void NamedParameterFunction(string firstName, string lastName)
        {
            Console.WriteLine($"FullName: {firstName} {lastName}");
            
        }
        //optionalParameter
        public void OptionalParameterFunction(int a, int b=10)
        {
            Console.WriteLine(a + b);
        }
    }
}
