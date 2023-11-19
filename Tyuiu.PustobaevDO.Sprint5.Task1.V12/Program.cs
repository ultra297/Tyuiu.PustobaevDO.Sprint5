﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PustobaevDO.Sprint5.Task1.V12.Lib;

namespace Tyuiu.PustobaevDO.Sprint5.Task1.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Пустобаев Д.О. | ИСПб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Запись набора данных в текстовый файл.                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Пустобаев Дмитрий Олегович| ИСПб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция,                                                           *");
            Console.WriteLine("*        5x + 2,5                                                         *");
            Console.WriteLine("* y =  ------------ + 2                                                   *");
            Console.WriteLine("*        sinx - 2                                                         *");
            Console.WriteLine("* на заданном диапазоне [-5;5] с шагом 1. Произвести проверку деления на  *");
            Console.WriteLine("* 0. Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести   *");
            Console.WriteLine("* консоль в таблицу.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}

