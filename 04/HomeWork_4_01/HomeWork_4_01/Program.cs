using System;

namespace HomeWork_4_01
{
    class Program
    {
        /// <summary>
        /// Вход в программу построение пирамиды Паскаля.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            double j = 0;
            double result = 0;
            double number_K = 0;


            double number_N_Minus_K_Factorial = 0;
            double number_N_Factorial = 0;
            double number_K_Factorial = 0;

            double number_N_Minus_K_FactorialSecond = 1;
            double number_K_FactorialSecond = 1;
            double number_N_FactorialSecond = 1;

            Console.Write($" Введите число : ");            // Просьба ввести число
            double number_N = double.Parse(Console.ReadLine());   // Считываем введеное число

            double t = number_N;
            double[,] sizeOfMasiv = new double[(int)number_N +20000,(int)t + 20000 ];

            for (double i = 0; i <= number_N; i++)        //Открываем цикл вычисления бинома Ньютона.
            {
                number_N_Factorial = i;                   // Присваивание значения переменной

                if ((number_N_Factorial == 0) | (number_N_Factorial == 1) ) // Условие для расчета
                {                                                           // факториала числа "N"
                    number_N_Factorial = 1;               //Присваивание значения переменной
                }
                else if (number_N_Factorial <= number_N) // Условие для расчета факториала числа "N"
                {
                    number_N_FactorialSecond = 1;        // Приведение переменной к исходному значению

                    for (double a = 2; a <= i; a++)      // Вычисление факториала числа "N"
                    {

                        number_N_FactorialSecond *= a;
                        number_N_Factorial = number_N_FactorialSecond;
                    }
                }

                
                number_K_FactorialSecond = 1;           // Приведение переменной к исходному значению

                number_N_Minus_K_FactorialSecond = 1;   // Приведение переменной к исходному значению

                for ( j = 0; j <= i; j++)               // Цикл вычисления факториалов чисел:
                {                                       // "K" и "(N - K)"
                   
                    number_K_Factorial = j;             // Присваивание значения числу "K"

                    if ((number_K_Factorial == 0) | (number_K_Factorial == 1)) // Условия вычисления
                    {                                                          // факториала числа "K"
                        number_K_Factorial = 1;         // Присвоение значения факториала числа "K"
                    }
                    else if (number_K_Factorial <= i)   // Условия вычисления факториала числа "K"
                    {
                        number_K_Factorial = 0;         // Обнуление значения числа "K"
                        number_K_FactorialSecond = 1;   // Приведение переменной к исходному значению
                        for (double b = 2; b <= j; b++) // Вычисление факториала числа "K"
                        {
                            number_K_FactorialSecond *= b;
                            number_K_Factorial = number_K_FactorialSecond;
                        }
                    }

                    
                    number_N_Minus_K_Factorial = i - j;  // Вычисление значения разницы чисел "N" и "k"

                    if ((number_N_Minus_K_Factorial == 0) | (number_N_Minus_K_Factorial == 1)) // Условия вычисления
                    {                                                                         // факториала разн. чисел
                        number_N_Minus_K_Factorial = 1;  // Присваивание значения факториала разницы чисел "N" и "k"
                    }
                    else if (number_N_Minus_K_Factorial <= i)  // Условия вычисления факториала разницы чисел "N" и "k"
                    {
                        number_N_Minus_K_Factorial = 0;       // Обнуление значения разницы чисел "N" и "k
                        number_N_Minus_K_FactorialSecond = 1; // Приведение переменной к исходному значению

                        for (double z = 2; z <= (i - j); z++)  // Вычисление факториала разницы чисел "N" и "k
                        {
                            number_N_Minus_K_FactorialSecond *= z;
                            number_N_Minus_K_Factorial = number_N_Minus_K_FactorialSecond;
                        }
                    }

                    // Итоговое вычисление бинома Ньютона
                    result = number_N_Factorial / (number_K_Factorial * number_N_Minus_K_Factorial);

                    //Console.SetCursorPosition((Console.WindowWidth - sizeOfMasiv.Length) / 2, Console.WindowHeight + (int)i);

                    sizeOfMasiv[(int)i,(int)j] = (int)result;      // Присваивание значений элементам массива.
                    Console.Write($" {sizeOfMasiv[(int)i, (int)j]} ");  // Вывод в консоль.
                }
                Console.WriteLine();                              // Пропуск строки 
                continue;                                         // Возвращение к началу решения
            }

            Console.ReadKey();
        }
    }
}
