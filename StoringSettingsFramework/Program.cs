﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringSettingsFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.Title = Properties.Settings.Default.ApplicationNameDebug;
#else
            Console.Title = Properties.Settings.Default.ApplicationName;

#endif
            if (string.IsNullOrEmpty(Properties.Settings.Default.LongName) || Properties.Settings.Default.Age <= 0)
            {
                Console.Write("Введите ФИО: ");
                Properties.Settings.Default.LongName = Console.ReadLine();

                Console.Write("Укажите ваш возраст: ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    Properties.Settings.Default.Age = age;
                }
                else
                {
                    Properties.Settings.Default.Age = 0;
                }
                Properties.Settings.Default.Save();
            }

            Console.WriteLine($"ФИО: {Properties.Settings.Default.LongName}");
            Console.WriteLine($"Возраст: {Properties.Settings.Default.Age}");


            Console.ReadKey(true);

        }
    }
}