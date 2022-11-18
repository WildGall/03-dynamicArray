using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_dynamic_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Sum = "sum";
            const string Exit = "exit";
            bool isWorkProgram = true;            
            List<int> userNumbers = new List<int>();

            while (isWorkProgram)
            {
                Console.Write("Введите число или команду: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {                   
                   default:
                        userNumbers.Add(int.Parse(userInput));
                        break;
                    case Sum:
                        int sumNumbers = 0;

                        for (int i = 0; i < userNumbers.Count; i++)
                        {
                            sumNumbers += userNumbers[i];
                        }
                        Console.WriteLine(sumNumbers);
                        break;
                    case Exit:
                        isWorkProgram = false;
                        break;
                }                
            }
        }
    }
}
