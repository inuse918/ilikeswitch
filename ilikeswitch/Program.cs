using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilikeswitch
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("학년을 입력하세요: ");
            int level = int.Parse(Console.ReadLine());

            string print(int printLevel)
            {
                return ("수강해야 하는 전공 학점: " + printLevel + "학점");
            }
            
            switch (level)
            {
                case 1:
                    Console.WriteLine(print(12));
                    break;
                case 2:
                    Console.WriteLine(print(18));
                    break;
                case 3:
                    Console.WriteLine(print(10));
                    break;
                case 4:
                    Console.WriteLine(print(18));
                    break;
                default:
                    Console.WriteLine("==========");
                    break;
            }
        }
    }
}
