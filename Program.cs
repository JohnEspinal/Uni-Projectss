using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionForPractice
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] input = new int[5];
            string[] inputString = new string[5];
            int[] inputFirst = new int[5];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());

                inputString[i] = input[i].ToString();
            }


            


            foreach (string element in inputString)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    inputFirst[i] = Convert.ToInt32(element[i].ToString());
                }


            }
        }


    
    }
}
