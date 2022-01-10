using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            byte code = 0;
            bool fl = false;
            Console.WriteLine("Вас приветствует калькулятор");
            Console.Write("Введите целое число. X=");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Console.Write("Введите целое число. Y=");
                    y = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        Console.WriteLine("Введите код операции:");
                        Console.WriteLine("1 - сложение");
                        Console.WriteLine("2 - вычитание");
                        Console.WriteLine("3 - произведение");
                        Console.WriteLine("4 - частное");
                        Console.Write("Ваш выбор: ");
                        code = Convert.ToByte(Console.ReadLine());
                        if ((code < 1) || (code > 4))
                        {
                            Console.WriteLine("Нет операции с указанным номером");
                        }
                        else fl = true;
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Входная строка имела неверный формат");
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка! Входная строка имела неверный формат");
                }

            }
            catch
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат");
            }

            

            if (fl)
            {
                if (code == 1)
                {
                    Console.WriteLine("Результат = {0}", x + y);
                }
                if (code == 2)
                {
                    Console.WriteLine("Результат = {0}", x - y);
                }
                if (code == 3)
                {
                    Console.WriteLine("Результат = {0}", x * y);
                }
                if (code == 4)
                {
                    try
                    {
                        double d = (double)x / y;
                        Console.WriteLine("Результат = {0:F2}", d);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
