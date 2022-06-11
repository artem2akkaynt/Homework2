using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Добрый день. ");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 7; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ");
                Console.WriteLine(" 1-Задача номер 1. ");
                Console.WriteLine("   2-Задача номер 2. ");
                Console.WriteLine("     3-Задача номер 3. ");
                Console.WriteLine("       4-Задача номер 4. ");
                Console.WriteLine("         5-Задача номер 5.");
                Console.WriteLine("           6-Задача номер 6.");
                Console.WriteLine("             7-Задача номер 7.");
                Console.WriteLine("               0-Выход. ");
                Console.ForegroundColor = ConsoleColor.White;
                int taskNum = Convert.ToInt32(Console.ReadLine());
                switch (taskNum)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6(1, 1000000000);
                        break;
                    case 7:
                        Task7(5, 55);
                        break;
                    case 0:
                        Console.WriteLine("Удачного дня.");
                        Console.WriteLine("=============");
                        i += 7;
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод, попробуйте снова");
                        i--;
                        break;
                         
                }
            }
            
        }


        static void Task1()
        {
            Min();
            //Console.Write("Введите 1 число: ");
            //int chislo1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите 2 число: ");
            //int chislo2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите 3 число");
            //int chislo3 = Convert.ToInt32(Console.ReadLine());
            //int min = Math.Min(chislo1, chislo2, chislo3);
            //сначала, я хотел решить так, но Min не принимает 3 значение, есть какие- то похожие способы решения?
            //Console.Write("Введите 1 число: ");
            void Min()
            {
                Console.Write("Введите 1 число: ");
                long chislo1 = Convert.ToInt64(Console.ReadLine());
                Console.Write("Введите 2 число: ");
                long chislo2 = Convert.ToInt64(Console.ReadLine());
                Console.Write("Введите 3 число: ");
                long chislo3 = Convert.ToInt64(Console.ReadLine());
                long minChislo;
                if (chislo1 < chislo2)
                {
                    if(chislo1 < chislo3)
                    {
                        minChislo = chislo1;
                        Console.WriteLine("Минимальное число: " + minChislo);
                    }
                    else if(chislo3 < chislo1)
                    {
                        minChislo = chislo3;
                        Console.WriteLine("Минимальное число: " + minChislo);
                    }
                }
                else if (chislo2 < chislo1)
                {
                    if(chislo2 < chislo3)
                    {
                        minChislo = chislo2;
                        Console.WriteLine("Минимальное число: " + minChislo);
                    }
                }
                else if (chislo3 < chislo1)
                {
                    if(chislo3 < chislo2)
                    {
                        minChislo = chislo3;
                        Console.WriteLine("Минимальное число: " + minChislo);
                        
                    }
                }
                
            }


        }
        static void Task2()
        {
            //int c1 = 238;
            //int res2;
            //int res3;
            //res2 = c1 / 10;
            //res3 = res2 / 10;
            //Console.WriteLine(res2 + " " + res3 );
            //Console.ReadKey();
            //разбирал код из методички.

                Console.WriteLine("Введите число для нахождения суммы цифр: ");
                int chislo = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int i = 5  ; i >= 0; i--)
                {
                    sum += chislo / (int)Math.Pow(10.0, i);
                    chislo = chislo % (int)Math.Pow(10.0, i);
                }
                Console.WriteLine(sum);
            

        }
        static void Task3()
        {
            //можно использовать uint, тоже самое, что и int только включает в себя только положительные 
            int Sum = 0;
            bool c = true;
            while (c)
            {
                Console.Write("Введите число: ");
                int Vvod = Convert.ToInt32(Console.ReadLine());
                if (Vvod <= 0)
                {
                    if(Vvod == 0)
                    {
                        Console.WriteLine(Sum);
                        break;
                    }
                }
                else
                {
                    Sum += Vvod;
                }
            }
            



        }
        static void Task4()
        {
            string login = "root";
            string pasword = "GeekBrains";
            int count = 0;
            while (count < 3)
            {


                Console.Write("Введите логин: ");
                string loginVvod = Convert.ToString(Console.ReadLine());
                Console.Write("Введите пароль: ");
                string paswordVvod = Convert.ToString(Console.ReadLine());
                if( login == loginVvod & pasword == paswordVvod)
                {
                    Console.WriteLine("Вход выполнен успешно . . .");
                    Console.Write("Ваш баланс ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("4568 рублей");
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вход не выполнен ");
                    Console.WriteLine("Попробуйте снова");
                    Console.ForegroundColor = ConsoleColor.White;
                    count++;
                }
                if(count == 3)
                {
                    Console.WriteLine("Вы первысили лимит попыток . . .");
                }
                
            }


        }
        static void Task5()
        {
            bool c = true;
            while (c)
            {


                Console.Write("Введите свой вес в кг: ");
                int massa = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите свой рост в метрах: ");
                double height = Convert.ToDouble(Console.ReadLine());
                double IMT = massa / (height * height);
                Console.Write("Введите свой пол муж/жен: ");
                string pol = Console.ReadLine();
                if (pol == "жен")
                {
                if(IMT > 20 && IMT < 22)
                    {
                        Console.WriteLine("У Вас все в норме, ваш ИМТ = " + IMT + ".");
                        c = false;
                    }
                else
                    {
                        if (IMT < 20)
                        {
                           double recomendation = (20 - IMT) * height * height;
                           Console.WriteLine("Для нормализации ИМТ, Вам нужно набрать " + recomendation + ".");
                            c = false;
                        }
                        else
                        {
                            double recomendation = (IMT - 22) * height * height;
                            Console.WriteLine("Для нормализации ИМТ, Важ нужно похудеть на" + recomendation + ".");
                            c = false;
                        }
                    }
                }
                else if (pol == "муж")
                {
                    if(IMT > 23 && IMT < 25)
                    {
                        Console.WriteLine("У Вас все в норме, ваш ИМТ = " + IMT + ".");
                        c = false;
                    }
                    else
                    {
                        if(IMT < 23)
                        {
                            double recomendation = (23 - IMT) * height * height;
                            Console.WriteLine("Для нормализации ИМТ, Вам нужно набрать " + recomendation + ".");
                            c = false;
                        }
                        else
                        {
                            double recomendation = (IMT - 25) * height * height;
                            Console.WriteLine("Для нормализации ИМТ, Важ нужно похудеть на" + recomendation + ".");
                            c = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                    Console.WriteLine("Попробуйте снова");
                }
            }
            
        }
        static void Task6(int x, int y)
        {
            DateTime start = DateTime.Now;
            int count = 0;
            for (int i = x; i <= y; i++)
            {
                int sum = 0;
                int temp = i;
                while (temp != 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }

                if (i % sum == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество хороших чисел: {0}", count);
            Console.WriteLine("Время выполнения программы: {0}", DateTime.Now - start);
        }
            static void Task7(int a, int b)
        {   
            ; if (a > b)
            {
                Console.WriteLine("Ошибка, a > b. Программа завершена.");
            }
            else
            {
                Console.WriteLine(a);
                if (b > a)
                {
                    Task7 (a + 1, b);
                }
            }
        }
    }
}
