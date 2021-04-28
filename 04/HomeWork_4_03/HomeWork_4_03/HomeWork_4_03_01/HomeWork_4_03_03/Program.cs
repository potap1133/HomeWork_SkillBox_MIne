using System;

namespace HomeWork_4_03_03
{
    class Program
    {
        /// <summary>
        /// Программа вычисления произведения массивов.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int i = 0;                                  // Инициализация переменных
            int j = 0;                                  // Инициализация переменных
            int a = 0;                                  // Инициализация переменных
            int b = 0;                                  // Инициализация переменных

            int firstNumberOfColunsInTheArray = 0;      // Инициализация переменных
            int firstNumberOfRowsInTheArray = 0;        // Инициализация переменных 

            int matrixResultFirst = 0;                  // Инициализация переменных 
            int matrixResultSecond = 0;                 // Инициализация переменных             
                        
            Random randomiz = new Random();             // Генератор псевдо случайных чисел

            while (true)                                // Цикл запроса и введения параметров массива и определения исключений
            {
                try
                {

                    Console.Write($" Введите количество строк Первой Матрицы : ");      // Запрос ввода ьданнрых
                    firstNumberOfRowsInTheArray = int.Parse(Console.ReadLine());        // Запрос ввода ьданнрых
                    
                    if (firstNumberOfRowsInTheArray <= 0)
                    {
                        Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    break;                              // Прерывание цикла
                }
                catch (FormatException)
                {
                                                        // Вывод сообщения об ошибке
                    Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");

                    Console.ReadKey();                  // Ожидание нажатия любой клавиши
                    Console.Clear();                    // Очистка экрана консоли
                    continue;                           // Возврат в начало цикла
                }
                
            }

            while (true)                                // Цикл запроса и введения параметров массива и определения исключений
            {
                try
                {
                    Console.Write($" Введите количество столбцов Первой Матрицы : ");       // Запрос ввода ьданнрых
                    firstNumberOfColunsInTheArray = int.Parse(Console.ReadLine());          // Запрос ввода ьданнрых

                    if (firstNumberOfRowsInTheArray <= 0)
                    {
                        Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    break;                              // Прерывание цикла
                }
                catch (Exception)
                {
                                                        // Вывод сообщения об ошибке
                    Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");

                    Console.ReadKey();                  // Ожидание нажатия любой клавиши
                    Console.Clear();                    // Очистка экрана консоли
                    continue;                           // Возврат в начало цикла
                }

            }

            int secondNumberOfRowsInTheArray = firstNumberOfColunsInTheArray;  // Инициализация переменных
            int secondNumberOfColunsInTheArray = firstNumberOfRowsInTheArray;  // Инициализация переменных
            //Создание массивов            
            int[,] arrayOfTheFirstMatrix = new int[firstNumberOfRowsInTheArray, firstNumberOfColunsInTheArray];  
            int[,] arrayOfTheSecondMatrix = new int[secondNumberOfRowsInTheArray, secondNumberOfColunsInTheArray];
            int[,] productOfArrays = new int[firstNumberOfRowsInTheArray, firstNumberOfColunsInTheArray];

            Console.WriteLine();                                 // Пустая строка

            if (firstNumberOfRowsInTheArray == firstNumberOfColunsInTheArray)  // Условие выбора решения
            {

                for (i = 0; i < firstNumberOfColunsInTheArray; i++)     // Цикл заполнения массива
                {
                    Console.SetCursorPosition(1, 3 + i);        // Место положения курсора
                    Console.Write("|");                         // Вывод прямого слеша
                    Console.SetCursorPosition(2, 3 + i);        // Место положения курсора

                    for (j = 0; j < firstNumberOfRowsInTheArray; j++)   // Цикл заполнения массива
                    {

                        // Присвоение случайных чисел элементам массива
                        arrayOfTheFirstMatrix[i, j] = randomiz.Next(0, 10);
                        Console.Write($"{arrayOfTheFirstMatrix[i, j],4}");
                    }
                    Console.Write("|");                         // Вывод прямого слеша
                    Console.WriteLine();                        // Пустая строка
                }

                // Место положения курсора
                Console.SetCursorPosition(3 + (firstNumberOfRowsInTheArray * 4), 3 + (firstNumberOfRowsInTheArray / 2));  
                Console.Write("*");                             // Вывод в консоль знака умножения

                for (i = 0; i < secondNumberOfRowsInTheArray; i++)    // Цикл заполнения массива
                {
                    Console.SetCursorPosition(4 + (firstNumberOfRowsInTheArray * 4), 3 + i);    // Место положения курсора
                    Console.Write("|");                         // Вывод прямого слеша
                    Console.SetCursorPosition(5 + (firstNumberOfRowsInTheArray * 4), 3 + i);    // Место положения курсора

                    for (a = 0; a < secondNumberOfColunsInTheArray; a++)  // Цикл заполнения массива
                    {

                        // Присвоение случайных чисел элементам массива
                        arrayOfTheSecondMatrix[i, a] = randomiz.Next(0, 10);
                        Console.Write($"{arrayOfTheSecondMatrix[i, a],4}");
                    }
                    Console.Write("|");                         // Вывод прямого слеша
                    Console.WriteLine();                        // Пустая строка
                }

                // Место положения курсора
                Console.SetCursorPosition(6 + ((firstNumberOfRowsInTheArray * 4) * 2), 3 + (firstNumberOfRowsInTheArray / 2)); 
                Console.Write("=");                             // Вывод в консоль знака равенство


                for ( i = 0; i < firstNumberOfColunsInTheArray; i++)  // Цикл вычисления результата
                {
                    Console.SetCursorPosition(7 + ((firstNumberOfRowsInTheArray * 4) * 2), 3 + i);  // Место положения курсора
                    Console.Write("|");                         // Вывод прямого слеша
                    Console.SetCursorPosition(8 + ((firstNumberOfRowsInTheArray * 4) * 2), 3 + i);  // Место положения курсора

                    for ( j = 0; j < firstNumberOfRowsInTheArray; j++)
                    {
                        // Вычисление результата и заполнение элементов массива
                        productOfArrays[i, j] = arrayOfTheSecondMatrix[i, j] * arrayOfTheFirstMatrix[i, j];
                        Console.Write($"{productOfArrays[i, j], 4}");  // Вывод в консоль результата
                    }
                    Console.Write("|");                      // Вывод прямого слеша
                    Console.WriteLine();                     // Пустая строка
                }

            }

            Console.WriteLine();                            // Пустая строка

            if (firstNumberOfRowsInTheArray < firstNumberOfColunsInTheArray)        // Условие выбора решения
            {
                for (i = 0; i < firstNumberOfRowsInTheArray; i++)       // Цикл заполнения массива
                {
                    // Место положения курсора
                    Console.SetCursorPosition(1 , 3 + (((secondNumberOfRowsInTheArray - secondNumberOfColunsInTheArray )/ 2) + i));
                    
                    Console.Write("|");                     // Вывод прямого слеша

                    // Место положения курсора
                    Console.SetCursorPosition(2 , 3 + (((secondNumberOfRowsInTheArray - secondNumberOfColunsInTheArray) / 2) + i));


                    for (j = 0; j < firstNumberOfColunsInTheArray; j++) // Цикл заполнения массива
                    {

                        // Присвоение случайных чисел элементам массива
                        arrayOfTheFirstMatrix[i, j] = randomiz.Next(0, 10);
                        Console.Write($"{arrayOfTheFirstMatrix[i, j],4}");
                    }

                    // Место положения курсора
                    Console.SetCursorPosition(3 + (secondNumberOfRowsInTheArray * 4), 3 + (((secondNumberOfRowsInTheArray - secondNumberOfColunsInTheArray) / 2) + i));
                    Console.Write("|");                     // Вывод прямого слеша
                    Console.WriteLine();                    // Пустая строка
                }

                // Место положения курсора
                Console.SetCursorPosition(5 + (firstNumberOfColunsInTheArray * 4), 3 + (secondNumberOfRowsInTheArray / 2));
                Console.Write("*");                         // Вывод в консоль знака умножения

                for (i = 0; i < secondNumberOfRowsInTheArray; i++)      // Цикл заполнения массива
                {
                    Console.SetCursorPosition(7 + (firstNumberOfColunsInTheArray * 4), 3 + i);   // Место положения курсора
                    Console.Write("|");                     // Вывод прямого слеша
                    Console.SetCursorPosition(8 + (firstNumberOfColunsInTheArray * 4), 3 + i);   // Место положения курсора

                    for (a = 0; a < secondNumberOfColunsInTheArray; a++)    // Цикл заполнения массива
                    {

                        // Присвоение случайных чисел элементам массива
                        arrayOfTheSecondMatrix[i, a] = randomiz.Next(0, 10);
                        Console.Write($"{arrayOfTheSecondMatrix[i, a],4}");
                    }

                    // Место положения курсора
                    Console.SetCursorPosition(9 + (firstNumberOfColunsInTheArray * 4) + (secondNumberOfColunsInTheArray * 4), 3 + i);
                    Console.Write("|");                     // Вывод прямого слеша
                    Console.WriteLine();                            // Пустая строка
                }


                for (j = 0; j < firstNumberOfRowsInTheArray; j++)
                {
                    for (a = 0; a < firstNumberOfColunsInTheArray; a++)
                    {
                        // Вычисление результата
                        matrixResultFirst += arrayOfTheFirstMatrix[j, a] * arrayOfTheSecondMatrix[a, j];
                    }
                }

                // Место положения курсора
                Console.SetCursorPosition(11 + (firstNumberOfColunsInTheArray * 4) + (secondNumberOfColunsInTheArray * 4), 3 + (secondNumberOfRowsInTheArray / 2));         
                Console.Write("=");                                 // Вывод в консоль знака равенство

                // Место положения курсора
                Console.SetCursorPosition(13 + (firstNumberOfColunsInTheArray * 4) + (secondNumberOfColunsInTheArray * 4), 3 + (secondNumberOfRowsInTheArray / 2));         
                Console.WriteLine($"{matrixResultFirst}");          // Вывод в консоль результата
            }

            if (firstNumberOfRowsInTheArray > firstNumberOfColunsInTheArray)        // Условие выбора решения
            {

                for (i = 0; i < firstNumberOfRowsInTheArray; i++)     // Цикл заполнения массива
                {
                    Console.SetCursorPosition(1, 3 + i);             // Место положения курсора                    
                    Console.Write("|");                              // Вывод прямого слеша
                    Console.SetCursorPosition(2, 3 + i);             // Место положения курсора

                    for (a = 0; a < firstNumberOfColunsInTheArray; a++) // Цикл заполнения массива
                    {

                        // Присвоение случайных чисел элементам массива
                        arrayOfTheSecondMatrix[a, i] = randomiz.Next(0, 10);
                        Console.Write($"{arrayOfTheSecondMatrix[a, i],4}");
                    }

                    Console.Write("|");                             // Вывод прямого слеша
                    Console.WriteLine();                            // Пустая строка
                }

                // Место положения курсора
                Console.SetCursorPosition(4 + (secondNumberOfRowsInTheArray * 4), 3 + (secondNumberOfColunsInTheArray / 2));
                Console.Write("*");                                 // Вывод в консоль знака умножения


                for (i = 0; i < secondNumberOfRowsInTheArray; i++)  // Цикл заполнения массива
                {
                    // Место положения курсора
                    Console.SetCursorPosition(6 + (secondNumberOfRowsInTheArray * 4), 3 + (((secondNumberOfColunsInTheArray - secondNumberOfRowsInTheArray )/ 2) + i));
                    Console.Write("|");                             // Вывод прямого слеша

                    // Место положения курсора
                    Console.SetCursorPosition(7 + (secondNumberOfRowsInTheArray * 4), 3 + (((secondNumberOfColunsInTheArray - secondNumberOfRowsInTheArray) / 2) + i));   

                    for (j = 0; j < secondNumberOfColunsInTheArray; j++) // Цикл заполнения массива
                    {
                        // Присвоение случайных чисел элементам массива
                        arrayOfTheFirstMatrix[j, i] = randomiz.Next(0, 10);
                        Console.Write($"{arrayOfTheFirstMatrix[j, i],4}");  
                    }

                    // Место положения курсора
                    Console.SetCursorPosition(7 + ((secondNumberOfColunsInTheArray * 4)+ (secondNumberOfRowsInTheArray * 4) ), 3 + (((secondNumberOfColunsInTheArray - secondNumberOfRowsInTheArray) / 2) + i));
                    Console.Write("|");                             // Вывод прямого слеша
                    Console.WriteLine();                            // Пустая строка
                }

                for (a = 0; a < firstNumberOfColunsInTheArray; a++)
                {
                    for (j = 0; j < secondNumberOfColunsInTheArray; j++)
                    {
                        // Вычисление результата
                        matrixResultSecond += arrayOfTheFirstMatrix[j, a] * arrayOfTheSecondMatrix[a, j];
                    }
                }

                // Место положения курсора
                Console.SetCursorPosition(9 + (secondNumberOfColunsInTheArray * 4) + (secondNumberOfRowsInTheArray * 4), 3 + (secondNumberOfColunsInTheArray / 2));         
                Console.Write("=");                                 // Вывод в консоль знака равенство
                // Место положения курсора
                Console.SetCursorPosition(11 + (secondNumberOfColunsInTheArray * 4) + (secondNumberOfRowsInTheArray * 4), 3 + (secondNumberOfColunsInTheArray / 2));  
                Console.WriteLine($"{matrixResultSecond}");     // Вывод в консоль результата
            }


            Console.ReadKey();
        }
    }
}
