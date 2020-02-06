using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tomar 5 inputs y devolver el mayor numero posible ordenando cada NUMERO sin alterar el orden de los digitos

            string[] input = new string[5];
            string temp = "";
            string element = "";
            string elementNext = "";
            string result = "";

            for (int i = 0; i < 5; i++)
            {
                input[i] = Console.ReadLine();
            }

            

            for (int i = 0; i < 4; i++)
            {


                element = input[i];
                elementNext = input[i + 1];

                if(element.Length >= elementNext.Length)
                {
                    for (int x = 0; x < elementNext.Length; x++)
                    {
                        //Comparar si el primer digito de un numero es mayor que el primer digito del otro

                        if (element[x] < elementNext[x])
                        {
                            temp = element;
                            input[i] = elementNext;
                            input[i + 1] = temp;
                            break;
                        }
                        else if(element[x] > elementNext[x])
                        {
                            break;
                        }
                        
                    }
                }

                if (element.Length < elementNext.Length)
                {
                    for (int x = 0; x < element.Length; x++)
                    {
                        if (element[x] < elementNext[x])
                        {
                            temp = element;
                            input[i] = elementNext;
                            input[i + 1] = temp;
                        }
                        else if (element[x] > elementNext[x])
                        {
                            break;
                        }
                    }
                }


            }

            foreach (string numero in input)
            {
                result += numero;
            }

            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
