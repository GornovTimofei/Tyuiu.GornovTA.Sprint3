using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GornovTA.Sprint3.Task3.V28.Lib;

namespace Tyuiu.GornovTA.Sprint3.Task3.V28
{
    class Program
    {
        static void Main()
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №3 | Выполнил: Горнов Т. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание №3                                                              *");
            Console.WriteLine("* Вариант №28                                                             *");
            Console.WriteLine("* Выполнил: Горнов Тимофей Анатольевич | АСОиУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву r в строке:              *");
            Console.WriteLine("* f35hyt t4j 3gkg45                                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = "f35hyt t4j 3gkg45";
            char item = 'r';
            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Полученная строка = " + ds.ReplaceNumOnChar(value, item));
            Console.ReadKey();
        }
    }
}
