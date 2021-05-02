using System;

namespace HomeWork_4_02
{
    class Program
    {
        /// <summary>
        /// Вход в программу по расчету прибыльных месяцев и убыточных
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Random randomiz = new Random();                                                 // Генератор псевдо случайеых чисел

            var counterZero = 0;
            var n = 0;
            var counter = 0;
            var counterAll = 0;
            var monthNumber = 1;                                                            // Инициализация переменных
            var randomNumber = 0;
            var threeSmallerProfits = 0;
            var numberOfMonthsWithAPositiveProfit = 0;

            int[] month = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };                        // Создание массивов 

            int[] incomeOfMonthMassiv = new int[12];

            int[] expensesOfMonthMassiv = new int[12];

            int[] profitOfMonthMassiv = new int[12];

            int[] profitOfMonthMassivSecond = new int[12];

            int[] profitOfMonthMassivAnd = new int[12];

            int[] smallestNumbers = new int[3];

            
                   
            Console.WriteLine(" {0,1} {1,5} {2,5} {3,5} "  , "Месяц",                       // Вывод оглавлений столбцов
                                                             " Доход, тыс. руб. ",
                                                             " Расход, тыс. руб. ",
                                                           " Прибыль, тыс. руб.");

            for (int i = 0; i < 12; i++)                                                    // Цикл в котором массивы получают рандомные значени
            {
                incomeOfMonthMassiv[i] = randomiz.Next(0, 1_000_000);                               // Присваивание переменной случайных значений

                expensesOfMonthMassiv[i] = randomiz.Next(0, 1_000_000);                             // Присваивание переменной случайных значений

                profitOfMonthMassiv[i] = incomeOfMonthMassiv[i] - expensesOfMonthMassiv[i]; //Вычисление прибыли


                Console.WriteLine($"{month[i],6:### ##0} " +                                // Вывод на в консоль заполненых данными массивов
                                  $"{incomeOfMonthMassiv[i],16:### ##0} " +
                                  $"{expensesOfMonthMassiv[i],19:### ##0} " +
                                  $"{profitOfMonthMassiv[i],20:### ##0}");

                if (incomeOfMonthMassiv[i] == 0 && expensesOfMonthMassiv[i] == 0)           // Проверка равны ли данные нулю
                {
                    counterZero++;

                    if (counterZero == 12)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($" Прибыль и рсход равны нулю ");
                        Console.ReadKey();
                        Environment.Exit(counterZero);
                    }
                    else
                    {
                        continue;
                    }

                }

            }

            Array.Sort(profitOfMonthMassiv,month);                                          // Сортировка массива прибыли 
                       
            Console.WriteLine();
            Console.WriteLine();

            for (int s = 0; s <= 12; s++)                                                    // Цикл основного счетчика 
            {
                if (s == 11) break;

                if (profitOfMonthMassiv[s] != profitOfMonthMassiv[s + 1])
                {
                    counterAll++;
                }

            }

            if (counterAll == 1)
            {
                for (int q = 0; q < 12; q++)                                                // Цикл выявления одного наименьших чисел
                {
                    if (profitOfMonthMassiv[q] != profitOfMonthMassiv[q + 1])               // Проверка и избавление от повторяющихся чисел
                    {
                        smallestNumbers[n] = profitOfMonthMassiv[q];                        // Заполнение массива наименьшими числами 
                        smallestNumbers[1] = profitOfMonthMassiv[q + 1];
                        counter++;

                        if (counter == 1) break;                                            // Условие выхода из цикла
                    }
                    else
                    {
                        if (q == 10) break;
                        continue;                                                           // Возврат к началу цикла
                    }

                }

            }
            else
            {
                for (int m = 0; m < 12; m++)                                                // Цикл выявления трёх наименьших чисел
                {
                    if (profitOfMonthMassiv[m] != profitOfMonthMassiv[m + 1])               // Проверка и избавление от повторяющихся чисел
                    {
                        counter++;
                        smallestNumbers[n++] = profitOfMonthMassiv[m];                      // Заполнение массива наименьшими числами 
                        smallestNumbers[2] = profitOfMonthMassiv[m + 1];


                        if (counter == 2) break;                                            // Условие выхода из цикла
                    }
                    else
                    {
                        if (m == 10) break;
                        continue;                                                           // Возврат к началу цикла
                    }

                }
            }

            //else if (counterAll == 2)
            //{
            //    for (int o = 0; o < 12; o++)                                                // Цикл выявления двух наименьших чисел
            //    {
            //        if (profitOfMonthMassiv[o] != profitOfMonthMassiv[o + 1])               // Проверка и избавление от повторяющихся чисел
            //        {
            //            smallestNumbers[n++] = profitOfMonthMassiv[o];                      // Заполнение массива наименьшими числами 
            //            smallestNumbers[2] = profitOfMonthMassiv[o + 1];
            //            counter++;

            //            if (counter == 3) break;                                            // Условие выхода из цикла
            //        }
            //        else
            //        {
            //            if (o == 10) break;
            //            continue;                                                           // Возврат к началу цикла
            //        }

            //    }

            //}

            if (counter == 1)
            {
                Console.WriteLine($" Количество месяцев с минимальной прибылью : 2");   // Вывод в консоль текста
                Console.Write($" Номера месяцев с минимальной прибылью : ");                    // Вывод в консоль текста

                for (int g = 0; g <= counter; g++)                                               // Цикл выявления наименьших значений 
                {                                                                               // с повторениями
                    for (int a = 0; a < 12; a++)
                    {
                        if (smallestNumbers[g] == profitOfMonthMassiv[a])                       // Условие выявления наименьших значений
                        {
                            Console.Write($"{month[a]},");                                      // Вывод выявления наименьших значений
                        }
                    }
                }

                Console.Write($"\n Два нименьших показателя прибыли : ");                        // Вывод в консоль текста

                for (int f = 0; f <= counter; f++)                                               // Цикл перебора массива с наименьшими значениями 
                {
                    Console.Write($" {smallestNumbers[f]:### ##0}, ");
                }

                Console.WriteLine();                                                            // Пустая строка

                for (int z = 0; z < 12; z++)                                                    // Цикл подсчета месяцев с положительной прибылью
                {
                    if (profitOfMonthMassiv[z] > 0)                                             // Условие вычисления положительной прибыли
                    {
                        numberOfMonthsWithAPositiveProfit++;                                    // Счетчик месяцев с положительной прибылью 

                    }
                }
                // Вывод кол-ва месяцев с положительной прибылью
                Console.Write($" Количество месяцев с положительной прибылью : {numberOfMonthsWithAPositiveProfit}");

                Console.WriteLine();                                                            // Пустая строка

                Console.ReadKey();

            }
            else
            {
                Console.WriteLine($" Количество месяцев с минимальной прибылью : 3");   // Вывод в консоль текста
                Console.Write($" Номера месяцев с минимальной прибылью : ");                    // Вывод в консоль текста

                for (int g = 0; g <= counter; g++)                                               // Цикл выявления наименьших значений 
                {                                                                               // с повторениями
                    for (int a = 0; a < 12; a++)
                    {
                        if (smallestNumbers[g] == profitOfMonthMassiv[a])                       // Условие выявления наименьших значений
                        {
                            Console.Write($"{month[a]},");                                      // Вывод выявления наименьших значений
                        }
                    }
                }

                Console.Write($"\n Три нименьших показателя прибыли : ");                        // Вывод в консоль текста

                for (int f = 0; f <= counter; f++)                                               // Цикл перебора массива с наименьшими значениями 
                {
                    Console.Write($" {smallestNumbers[f]:### ##0}, ");
                }

                Console.WriteLine();                                                            // Пустая строка

                for (int z = 0; z < 12; z++)                                                    // Цикл подсчета месяцев с положительной прибылью
                {
                    if (profitOfMonthMassiv[z] > 0)                                             // Условие вычисления положительной прибыли
                    {
                        numberOfMonthsWithAPositiveProfit++;                                    // Счетчик месяцев с положительной прибылью 

                    }
                }
                // Вывод кол-ва месяцев с положительной прибылью
                Console.Write($" Количество месяцев с положительной прибылью : {numberOfMonthsWithAPositiveProfit}");

                Console.WriteLine();                                                            // Пустая строка

                Console.ReadKey();

            }
        }
    }
}
