using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_college_1
{
    internal class Calculator1
    {
        static void Main()
        {
            double first, second, n;
            bool count = true;
            do
            {
                Console.WriteLine("Выберите операцию:\n" +
                    "1. Сложение\n" +
                    "2. Вычитание первого числа из второго\n" +
                    "3. Перемножить два числа\n" +
                    "4. Разделить первое на второе\r\n" +
                    "5. Возвести в степень N первое число\r\n" +
                    "6. Найти квадратный корень из первого числа\r\n" +
                    "7. Найти 1 процент от числа\r\n" +
                    "8. Найти факториал из числа\r\n" +
                    "9. Выйти из программы");
                int operatorCal = Convert.ToInt32(Console.ReadLine());
                switch (operatorCal)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите первое число:");
                            first = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второе число:");
                            second = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(first + second);
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите первое число:");
                            first = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второе число:");
                            second = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(second - first);
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите первое число:");
                            first = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второе число:");
                            second = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(second * first);
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите первое число:");
                            first = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите второе число:");
                            second = Convert.ToDouble(Console.ReadLine());
                            if (second == 0)
                            {
                                Console.WriteLine("Деление на ноль невозможно");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine(first / second);
                                Console.WriteLine();
                            }
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Введите первое число:");
                            first = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите показатель степени:");
                            n = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Math.Pow(first, n));
                            Console.WriteLine();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Введите первое число:");
                            first = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Math.Sqrt(first));
                            Console.WriteLine();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Введите первое число:");
                            first = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine((first * 0.01));
                            Console.WriteLine();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Введите первое число:");
                            first = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Factorial(Convert.ToInt32(first)));
                            Console.WriteLine();
                            break;
                        }
                    case 9:
                        {
                            count = false;
                            Console.WriteLine("Завершение программы");
                            Console.WriteLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Неизвестная команда");
                            Console.WriteLine();
                            break;
                        }
                }
            }
            while (count);
            Console.ReadKey();
        }
        public static int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
    }
}
