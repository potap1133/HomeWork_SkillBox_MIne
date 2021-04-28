using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			var signOfAdditionOrSubtraction = 0;
			var numberOfMatrixRows = 0;                              // Инициализация переменной
			var numberOfMatrixColumns = 0;                           // Инициализация переменной
			var i = 0;                                               // Инициализация переменной
			var j = 0;                                               // Инициализация переменной

			Random randomiz = new Random();                          // Генератор псевдо случайных чисел

			while (true)                                                    // Цикл запроса и введения параметров массива
			{
				try                                                  // Блок выявления ошибок при вводе
				{
					// Запрос о вводе количества строк
					Console.Write($" Введите количество строк матрицы : ");
					// Присваивание переменной введенного значения
					numberOfMatrixRows = int.Parse(Console.ReadLine());

					Console.Clear();                                // Очищение консоли от предыдущих данных
					break;                                          // Выход из цикла

				}
				catch (FormatException)                           // Наименование ошибки для исправления
				{
					// Вывод сообщения об ошибке
					Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");

					Console.ReadKey();                              // Ожидание нажатия любой клавиши
					Console.Clear();                                // Очистка консоли
					continue;
				}

			}

			while (true)
			{
				try                                                 // Блок выявления ошибок при вводе
				{
					// Запрос о вводе количества столбцов
					Console.Write($" Введите количество столбцов матрицы : ");
					// Присваивание переменной введенного значения
					numberOfMatrixColumns = int.Parse(Console.ReadLine());

					Console.Clear();                                // Очистка экрана консоли
					break;                                          // Выход из цикла
				}
				catch (FormatException)                            // Наименование ошибки для исправления
				{
					// Вывод сообщения об ошибке
					Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");

					Console.ReadKey();                              // Ожидание нажатия любой клавиши
					Console.Clear();                                // Очистка экрана консоли
					continue;                                       // Возврат в начало цикла
				}

			}

			while (true)                                                    // Цикл запроса и введения параметров массива
			{
				try                                                  // Блок выявления ошибок при вводе
				{
					// Запрос о вводе количества строк
					Console.Write($" Выбберите операцию сложение/вычитание : ");
					// Присваивание переменной введенного значения
					signOfAdditionOrSubtraction = char.Parse(Console.ReadLine());

					Console.Clear();                                // Очищение консоли от предыдущих данных
					break;                                          // Выход из цикла

				}
				catch (FormatException)                           // Наименование ошибки для исправления
				{
					// Вывод сообщения об ошибке
					Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");

					Console.ReadKey();                              // Ожидание нажатия любой клавиши
					Console.Clear();                                // Очистка консоли
					continue;
				}

			}

			Console.WriteLine($" Количество строк матрицы : {numberOfMatrixRows}"); // Вывод введенных значений
			Console.WriteLine($" Количество столбцов матрицы : {numberOfMatrixColumns}"); // Вывод введенных значений	


			Console.WriteLine();                                      // Пропуск строки

			int[,] massivMatrici = new int[numberOfMatrixRows, numberOfMatrixColumns];       // Создание массива
			int[,] massivMatriciSecond = new int[numberOfMatrixRows, numberOfMatrixColumns]; // Создание массива
			int[,] summaMatric = new int[numberOfMatrixRows, numberOfMatrixColumns]; // Создание массива

			

            for ( i = 0; i < numberOfMatrixRows; i++)										// Цикл заполнения и вывода массива
            {
				Console.SetCursorPosition(1, 3 + i);										// Присваивание координат курсору
				Console.Write("|");															// Вывод прямого слеша

				Console.SetCursorPosition(2, 3 + i);                                        // Присваивание координат курсору

				for ( j = 0; j < numberOfMatrixColumns; j++)                                // Цикл заполнения и вывода массива
				{
					massivMatrici[i, j] = randomiz.Next(0, 10);								// Заполнение массива случайными числами
					Console.Write($"{massivMatrici[i, j], 4}");								// Вывод матрицы в консоль
                }
				Console.Write("|");                                                         // Вывод прямого слеша
				Console.WriteLine();														// Вывод пустой строки

			}
						
            switch (signOfAdditionOrSubtraction)
            {
				case '*':

					Console.SetCursorPosition(3 + (numberOfMatrixColumns * 4), 3 + (numberOfMatrixRows / 2));  // Присваивание координат курсору
					Console.Write("*");

					for (i = 0; i < numberOfMatrixRows; i++)                                        // Цикл заполнения и вывода массива
					{
						Console.SetCursorPosition(4 + (numberOfMatrixColumns * 4), 3 + i);          // Присваивание координат курсору
						Console.Write("|");                                                         // Вывод прямого слеша

						Console.SetCursorPosition(5 + (numberOfMatrixColumns * 4), 3 + i);          // Присваивание координат курсору

						for (j = 0; j < numberOfMatrixColumns; j++)                                 // Цикл заполнения и вывода массива
						{
							massivMatriciSecond[i, j] = randomiz.Next(0, 10);                      // Заполнение массива случайными числами
							Console.Write($"{massivMatriciSecond[i, j],4}");                       // Вывод матрицы в консоль
						}
						Console.Write("|");                                                         // Вывод прямого слеша
						Console.WriteLine();                                                        // Вывод пустой строки
					}

					Console.SetCursorPosition(6 + ((numberOfMatrixColumns * 4) * 2), 3 + (numberOfMatrixRows / 2));// Присваивание координат курсору
					Console.Write("=");

					for (i = 0; i < numberOfMatrixRows; i++)                                       // Цикл заполнения и вывода массива
					{
						Console.SetCursorPosition(7 + ((numberOfMatrixColumns * 4) * 2), 3 + i);    // Присваивание координат курсору
						Console.Write("|");                                                         // Вывод прямого слеша

						Console.SetCursorPosition(8 + ((numberOfMatrixColumns * 4) * 2), 3 + i);    // Присваивание координат курсору

						for (j = 0; j < numberOfMatrixColumns; j++)                                // Цикл заполнения и вывода массива
						{
							summaMatric[i, j] = massivMatrici[i, j] * massivMatriciSecond[i, j];  // Заполнение суммы двух матриц
							Console.Write($"{summaMatric[i, j],4}");                      // Вывод матрицы в консоль
						}
						Console.Write("|");                                                         // Вывод прямого слеша
						Console.WriteLine();                                                        // Вывод пустой строки
					}
					Console.ReadKey();
					break;

				case '-':

					Console.SetCursorPosition(3 + (numberOfMatrixColumns * 4), 3 + (numberOfMatrixRows / 2));  // Присваивание координат курсору
					Console.Write("-");

					for (i = 0; i < numberOfMatrixRows; i++)                                        // Цикл заполнения и вывода массива
					{
						Console.SetCursorPosition(4 + (numberOfMatrixColumns * 4), 3 + i);          // Присваивание координат курсору
						Console.Write("|");                                                         // Вывод прямого слеша

						Console.SetCursorPosition(5 + (numberOfMatrixColumns * 4), 3 + i);          // Присваивание координат курсору

						for (j = 0; j < numberOfMatrixColumns; j++)                                 // Цикл заполнения и вывода массива
						{
							massivMatriciSecond[i, j] = randomiz.Next(0, 10);                      // Заполнение массива случайными числами
							Console.Write($"{massivMatriciSecond[i, j],4}");                       // Вывод матрицы в консоль
						}
						Console.Write("|");                                                         // Вывод прямого слеша
						Console.WriteLine();                                                        // Вывод пустой строки
					}

					Console.SetCursorPosition(6 + ((numberOfMatrixColumns * 4) * 2), 3 + (numberOfMatrixRows / 2));// Присваивание координат курсору
					Console.Write("=");

					for (i = 0; i < numberOfMatrixRows; i++)                                       // Цикл заполнения и вывода массива
					{
						Console.SetCursorPosition(7 + ((numberOfMatrixColumns * 4) * 2), 3 + i);    // Присваивание координат курсору
						Console.Write("|");                                                         // Вывод прямого слеша

						Console.SetCursorPosition(8 + ((numberOfMatrixColumns * 4) * 2), 3 + i);    // Присваивание координат курсору

						for (j = 0; j < numberOfMatrixColumns; j++)                                // Цикл заполнения и вывода массива
						{
							summaMatric[i, j] = massivMatrici[i, j] - massivMatriciSecond[i, j];  // Заполнение разницы двух матриц
							Console.Write($"{summaMatric[i, j],4}");                      // Вывод матрицы в консоль
						}
						Console.Write("|");                                                         // Вывод прямого слеша
						Console.WriteLine();                                                        // Вывод пустой строки
					}
					Console.ReadKey();
					break;


			}
        }
    }
}
