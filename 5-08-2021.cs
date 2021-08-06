using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_08_2021
{
    class Program
    {
          static void Main(string[] args)
          {
              Console.Write("Vvedite pervuy peremennu:");
              int A = Convert.ToInt32(Console.ReadLine());
              Console.Write("Vvedite vtoruy  peremennu:");
              int B = Convert.ToInt32(Console.ReadLine());
              if (A==B)
              {
                A = B = 0;
                    Console.WriteLine($" {A }");
                    Console.WriteLine($"  {B}"); 
               
               }
             else if(A>B)  
                {
                B = A;
                    Console.WriteLine($" {B}");
                    Console.WriteLine($"  {A}");
                 }
              else if(B>A)
              {
                A = B; 
                Console.WriteLine($"{A}");
                Console.WriteLine($"{B}");
              }
              Console.ReadKey();
          }
       /* static void Main(string[] args)
        {
            Console.Write("PERVOE CHISLO: ");
            string operanD1 = Console.ReadLine();
            int operand1 = Int32.Parse(operanD1);
            Console.Write("DRUGOE CHISLO: ");
            string operanD2 = Console.ReadLine();
            int operand2 = Int32.Parse(operanD2);
            Console.Write("VVEDITE ZNAK ARIMETICHNOE OPERATSII: ");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    {
                        Console.WriteLine(operand1 + operand2);
                    break;
                    }
                case "-":
                    {
                        Console.WriteLine(operand1-operand2);
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(operand1 * operand2);
                        break;
                    }
                case "/":
                    {

                        if (operand2 == 0)
                        {
                            Console.WriteLine("NELZYA DELIT NA 0");
                        }
                        else
                        { 
                            Console.WriteLine(operand1 / operand2);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("VI VELI NEKOREKTNIY ZNAK");
                        break;
                    }
                   
                        
            }
           
            Console.ReadKey();
            

        }*/
       /*static  void Main(string[] args)
        {
            byte b = Convert.ToByte(Console.ReadLine());
            if (b<15)
            {
                Console.WriteLine("[0-14]");
            }
            else if (b < 36)
            {
                Console.WriteLine("[15-35]");
            }
            else if(b<51)
            {
                Console.WriteLine("[36-50]");
            }
            else if (b < 101)
            {
                Console.WriteLine("[50-100]");
            }
            Console.ReadKey();
        }*/
    }
}
