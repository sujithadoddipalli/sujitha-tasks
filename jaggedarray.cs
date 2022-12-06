//jageedArray

/* using System;
class jaggerarayyys
{
    public static void Main(string[] args)
    {
        string[] employeename = new string[3];
        employeename[0] = "sujitha";
        employeename[1] = "mahitha";
        employeename[2] = "saathvika";
        //jagged array to stored employee qualifications
        string[][] jaggedarray = new string[3][];

        jaggedarray[0] = new string[3];
        jaggedarray[1] = new string[1];
        jaggedarray[2] = new string[2];

        jaggedarray[0][0] = "batchelors";
        jaggedarray[0][1] = "masters";
        jaggedarray[0][2] = "doctorate";

        jaggedarray[1][0] = "batchelors";


        jaggedarray[2][0] = "batchelors";
        jaggedarray[2][1] = "masters";

        //loop through print out the elements of jaggred array

        for (int i = 0; i < jaggedarray.Length; i++)
        {

            Console.WriteLine(employeename[i]);
            Console.WriteLine("--------------");
            string[]innerarray=jaggedarray[i];
            for (int j = 0;j<innerarray.Length; j++)
            {
                Console.WriteLine(innerarray[j]);
            }
            Console.WriteLine();
        }

    }
}
*/

using System;

namespace MultiDArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] numbers = { { 2, 3, 9 }, { 4, 5, 9 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.Write("Row : " );

                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");

                }
                Console.WriteLine();

            }
        }
    }
}