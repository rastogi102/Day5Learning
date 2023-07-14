using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int noc, nos;
            //    Console.WriteLine("Enter number of classes");
            //    noc = int.Parse(Console.ReadLine());
            //    string[][] students = new string[noc][];
            //    for (int i = 0; i < noc; i++)
            //    {
            //        Console.WriteLine("Enter number of students");
            //        nos = int.Parse(Console.ReadLine());
            //        students[i] = new string[nos];
            //        for (int j = 0; j < nos; j++)
            //        {
            //            Console.WriteLine($"Enter studen{j + 1}\'s name");
            //            students[i][j] = Console.ReadLine();

            //        }
            //    }
            //    for (int i = 0; i < students.Length; i++)
            //    {
            //        Console.WriteLine($"Students list of class{i + 1}");
            //        Console.WriteLine("*************************************");
            //        for (int j = 0; j < students[i].Length; j++)
            //        {
            //            Console.WriteLine(students[i][j]);
            //        }
            //        Console.WriteLine("***************************************");

            //    }
            //    Console.ReadKey();


            int[][,] myJArray = new int[3][,];
            myJArray[0]=new int[2,2] { {1,2 } ,{2,3 } };
            myJArray[1] = new int[3, 2] { { 1, 2 }, { 2, 3 }, { 5, 4 } };
            myJArray[2]= new int[3, 3] { {1,2,6 } ,{2,3,7 } ,{5,4,8 } };
            Console.WriteLine("Stored values are");
            for (int i = 0; i < myJArray.Length; i++)
            {
                for (int j = 0; j < myJArray[i].GetLength(0); j++)
                {
                    for (int k = 0; k < myJArray[i].GetLength(1); k++)
                    {
                        Console.Write(myJArray[i][j, k] + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("***************************");

            }
            Console.ReadKey();



        }

    }
}
