using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_числа_на_простоту
{
    public class Program
    {
        public static bool IsPrimeNumber(int n)
        {
            double sred = Math.Sqrt(n);
            for (int i = 2; i <= sred; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для проверки на простоту в диапозоне (0,10):");
             try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n==0)
                    Console.WriteLine("Недопустимое значение числа. Число не является натуральным");
                else 
                    if (n < 0)
                        Console.WriteLine("Недопустимое значение числа. Число является отрицательным");
                    else
                    {
                        if (IsPrimeNumber(n) == true)
                            Console.WriteLine("Результат: число {0} является простым.", n);
                        else
                            Console.WriteLine("Результат: число {0} не является простым.", n);
                    }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введенное значение не соответствует формату числа");
            }
            Console.ReadKey();
        }
    }
}
