using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racov_csharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("'Консольные работы Ракова Дениса за 3 курс'\n");
            Console.WriteLine("Актуальное наличие: первое задание с 11 задачами\n");
           
            menu_zadaniya1:
            Console.WriteLine("ЗАДАНИЕ 1");
            Console.WriteLine("Введите номер задачи чтобы его проверить: ");
            string nomer = Console.ReadLine();
            Console.WriteLine("\n");
            nomer1 nomer1 = new nomer1();

            switch (nomer)
            {
                case ("1"): nomer1.zadacha1();
                    break;

                case ("2"): nomer1.zadacha2();
                    break;

                case ("3"): nomer1.zadacha3457();
                    break;

                case ("4"): goto case ("3");
                case ("5"): goto case ("3");
                case ("7"): goto case ("3");

                case ("6"): nomer1.zadacha6();
                    break;

                case ("8"): nomer1.zadacha8();
                    break;

                case ("9"): nomer1.zadacha9();
                    break;

                case ("10"): nomer1.zadacha10();
                    break;

                case ("11"): nomer1.zadacha11();
                    break;

                default:
                    Console.WriteLine("\nТакого задания еще нет :)\n");
                    goto menu_zadaniya1;
            }

            Console.WriteLine("\n\nЧтобы вернуться к выбору задания введите 1, для выхода из программы любую другую клавишу");
            string exit = Console.ReadLine();

            if (exit == "1")
            {
                Console.WriteLine("\n");
                goto menu_zadaniya1;
            }
            else
                Environment.Exit(0);
        }
        
        
    }
    class nomer1
    {
        public void zadacha1()
        {
            double a = 101, b = 0, c = 3, g = 3.0e-6, h = 10000000.1;
            Console.WriteLine("Задача 1: \n");
            double y = (a + b) / c;
            double k = g * h;
            bool z = true && true;
            bool p = false && true;
            bool f = (false && false) || (true && true);
            bool q = (false || false) && (true && true);

            Console.WriteLine($"a){y:n3}\nb){k}\nb){z}\nd){p}\ne){f}\nf){q}.");
        }

        public void zadacha2()
        {
            again: 
            try
            {
                Console.WriteLine("Задача 2: \n");
                Console.Write("Введите первое число: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Введите третье число: ");
                int c = int.Parse(Console.ReadLine());
                Console.Write("Введите четвертное число: ");
                int d = int.Parse(Console.ReadLine());

                if (a == b && b == c && c == d) Console.WriteLine($"Значения переменных равны: {a}{b}{c}{d}");
                else Console.WriteLine("Значения не равны");

            }
            catch (Exception a)
            {
                Console.WriteLine("\n" + a.Message + "\n");
                goto again;
            }
        }

        public void zadacha3457()
        {
            again:
            try
            {
                Console.WriteLine("Задачи номер 3,4,5,7\n");
                Console.Write("Введите размер массива: ");
                int el = int.Parse(Console.ReadLine());

                int[] arr = new int[el];
                Random rnd = new Random();
                int summ = 0;
                int kolvo = 0;

                Console.WriteLine("Желаете сами ввести значения или ввод рандомных чисел? (1/2)");
                int q = int.Parse(Console.ReadLine());

                if (q == 1)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"Введите значение массива под индексом {i}: ");
                        arr[i] = int.Parse(Console.ReadLine());
                        summ += arr[i];
                        kolvo++;
                    }
                }
                else
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = rnd.Next(15);
                        summ += arr[i];
                        kolvo++;
                    }
                }
                int max = arr[0];
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (arr[i] > max)
                        max = arr[i];
                }

                int min = arr[0];
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (arr[i] < min)
                        min = arr[i];
                }

                Console.WriteLine("\nВывод массива");
                for (int k = 0; k < arr.Length; k++)
                {
                    Console.Write(arr[k] + " ");
                }

                Console.WriteLine("\n\nРезультаты вычислений");
                Console.WriteLine("\nСумма: " + summ);
                Console.WriteLine("\nСреднее значение: " + (double)summ / kolvo);
                Console.WriteLine($"\nМаксимальное число массива: " + max);
                Console.WriteLine($"Минимальноее число массива: " + min);

                Console.Write("\nЧисла больше среднего значения:");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > summ / kolvo)
                        Console.Write(" " + arr[i]);
                }

                Console.Write("\n\nЧетные:");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                        Console.Write(" " + arr[i]);
                }

                Console.Write("\nНечетные:");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                        Console.Write(" " + arr[i]);
                }
            }
            catch (Exception a)
            {
                Console.WriteLine("\n" + a.Message + "\n");
                goto again;
            }
        }

        public void zadacha6()
        {
            again:
            try
            {
                Console.WriteLine("Задача номер 6\n");
                Console.Write("Введите первое число: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int b = int.Parse(Console.ReadLine());

                int res = 0;
                for (int i = 0; i < a; i++)
                    res = res + b;

                Console.WriteLine(res);
            }
            catch(Exception a)
            {
                Console.WriteLine("\n" + a.Message + "\n");
                goto again;
            }
        }

        public void zadacha8()
        {
            again:
            try
            {
                Console.WriteLine("Задача номер 8\n");
                Console.WriteLine("В какое значение будете преобразовывать C в F или F в C? (1/2)");
                int variant = int.Parse(Console.ReadLine());

                double c, f;
                if (variant == 1)
                {
                    Console.Write("\nВведите значение градусов цельсия: ");
                    c = double.Parse(Console.ReadLine());
                    f = c * 9 / 5 + 32;
                    Console.WriteLine($"\n{c} ° цельсия = {f} ° фаренгейта\n\n");
                }
                else if (variant == 2)
                {
                    Console.Write("\nВведите значение градусов фаренгейта: ");
                    f = double.Parse(Console.ReadLine());
                    c = (f - 32) * 5 / 9;
                    Console.WriteLine($"\n{f} ° фаренгейта = {c} ° цельсия\n\n");
                }
                else
                {
                    Console.WriteLine("\nОшибка ввода, повторите попытку\n");
                    goto again;
                }
            }
            catch (Exception a)
            {
                Console.WriteLine("\n" + a.Message + "\n");
                goto again;
            }
        }

        public void zadacha9()
        {
            again:
            try
            {
                Console.WriteLine("Задача номер 9\n");
                Console.Write("Ваш рост в см: ");
                double cm = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ваш вес в кг: ");
                double kg = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nВаш индекс массы тела(ИМТ) = " + Math.Round(kg / Math.Pow((cm / 100), 2), 2));
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
                goto again;
            }
        }

        public void zadacha10()
        {
            again:
            try
            {
                Console.WriteLine("Задача номер 10\n");
                Console.Write("Введите число: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"\nКвадрат числа = {a * a}, куб = {a * a * a}, четвертая степень = {a * a * a * a}");
            }
            catch (Exception a)
            {
                Console.WriteLine("\n" + a.Message + "\n");
                goto again;
            }
        }

        public void zadacha11()
        {
            again:
            try
            {
                Console.WriteLine("Задача номер 11\n");
                Console.Write("Введите строну а: ");
                uint a = uint.Parse(Console.ReadLine());
                Console.Write("Введите строну b: ");
                uint b = uint.Parse(Console.ReadLine());
                Console.Write("Введите строну c: ");
                uint c = uint.Parse(Console.ReadLine());

                if ((a + b > c) && (b + c > a) && (a + c > b))
                {

                    Console.WriteLine("\nЭто треугольник");
                }
                else
                {
                    Console.WriteLine("\nЭто не треугольник");
                }
            }
            catch (Exception a)
            {
                Console.WriteLine("\n" + a.Message + "\n");
                goto again;
            }
        }
    }
}
