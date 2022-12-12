using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpTask.ClassObject;

namespace CsharpTask.ClassObject
{
    public class Fruits
    {
        //data member
        
        public string? FruitsName;
        public string? CityName;
        public void FruitsDetails()
        {
            Console.WriteLine("Different type of Fruites");
            Console.WriteLine("FruiteDetails:{0}", FruitsName);
        }
        public void AvailabeFruitesCity()
        {
            Console.WriteLine("available of fruits city");
            Console.WriteLine("city name is : {0} and Friitname is:{1}", CityName, FruitsName);

        }
    public static void Main()
        {
            Fruits fruits = new();
            fruits.FruitsName = "apple";
            fruits.CityName = "andra";
            fruits.AvailabeFruitesCity();
        }
    }


}
