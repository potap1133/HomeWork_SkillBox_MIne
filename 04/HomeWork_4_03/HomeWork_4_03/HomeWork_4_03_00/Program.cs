using System;namespace HomeWork_4_03{	class Program	{		
		static void Main(string[] args)		{			var randomNumber = 0;                                    // Инициализация переменной
			var numberOfMatrixRows = 0;                              // Инициализация переменной
			var numberOfMatrixColumns = 0;                           // Инициализация переменной
			var multiplier = 0;                                      // Инициализация переменной
			var i = 0;                                               // Инициализация переменной
			var j = 0;											     // Инициализация переменной

			Random randomiz = new Random();                          // Генератор псевдо случайных чисел

			while(true)                                                    // Цикл запроса и введения параметров массива
			{
				try													 // Блок выявления ошибок при вводе
				{
					// Запрос о вводе количества строк
					Console.Write($" Введите количество строк матрицы : ");
					// Присваивание переменной введенного значения
					numberOfMatrixRows = int.Parse(Console.ReadLine());
					                    
					Console.Clear();                                // Очищение консоли от предыдущих данных
					break;                                          // Выход из цикла

				}
				catch ( FormatException )                           // Наименование ошибки для исправления
				{
					// Вывод сообщения об ошибке
					Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");

					Console.ReadKey();                              // Ожидание нажатия любой клавиши
					Console.Clear();								// Очистка консоли
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
					
					Console.Clear();								// Очистка экрана консоли
					break;											// Выход из цикла
				}
				catch ( FormatException)                            // Наименование ошибки для исправления
				{
					// Вывод сообщения об ошибке
					Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");

					Console.ReadKey();                              // Ожидание нажатия любой клавиши
					Console.Clear();                                // Очистка экрана консоли
					continue;										// Возврат в начало цикла
				}

			}

			while (true)
			{
				try                                                 // Блок выявления ошибок при вводе
				{
					// Запрос о вводе множетеля
					Console.Write($" Введите множетель матрицы : ");
					// Присваивание переменной введенного значения
					multiplier = int.Parse(Console.ReadLine());

					Console.Clear();                                // Очистка экрана консоли
					break;                                          // Выход из цикла
				}
				catch ( FormatException)                            // Наименование ошибки для исправления
				{

					// Вывод сообщения об ошибке
					Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");

					Console.ReadKey();                              // Ожидание нажатия любой клавиши
					Console.Clear();                                // Очистка экрана консоли
					continue;                                       // Возврат в начало цикла

				}

			} 
			
			Console.WriteLine($" Количество строк матрицы : {numberOfMatrixRows}"); // Вывод введенных значений
			Console.WriteLine($" Количество столбцов матрицы : {numberOfMatrixColumns}"); // Вывод введенных значений
			Console.WriteLine($" Множетель матрицы : {multiplier}");  // Вывод введенных значений

			Console.WriteLine();                                      // Пропуск строки

			int[,] massivMatrici = new int[numberOfMatrixRows, numberOfMatrixColumns];       // Создание массива
			int[,] massivMatriciSecond = new int[numberOfMatrixRows, numberOfMatrixColumns]; // Создание массива

			Console.SetCursorPosition(0, (numberOfMatrixRows / 2) + 4); // Координаты позиции курсора
			Console.Write($" {multiplier} X");                          // Вывод множетеля


			for (i = 0; i < numberOfMatrixRows; i++)                // Цикл заполнения матрицы множетеля
			{
				Console.SetCursorPosition(5, 4 + i);                   // Координаты позиции курсора
				Console.Write("|");                                     // Вывод прямого слеша

				Console.SetCursorPosition(6, 4 + i);                   // Координаты позиции курсора 

				for (j = 0; j < numberOfMatrixColumns; j++)         // Цикл заполнения матрицы множетеля
				{
					// Присвоение случайного числа элементу матрицы
					massivMatrici[i, j] = randomiz.Next(0, 100);

					// Вычисление произведения матрицы и множетель, присваивание значения элементу матрицы
					massivMatriciSecond[i, j] = massivMatrici[i, j] * multiplier;

					Console.Write($"{massivMatrici[i, j],4}");          // Вывод матрицы в консоль

				}

				Console.Write(" |");                                    // Вывод прямого слеша 

				Console.WriteLine();                                    // Пропуск строки
			}

			// Координаты позиции курсора 
			Console.SetCursorPosition(9 + (numberOfMatrixColumns * 4), 4 + (numberOfMatrixRows / 2));
			Console.Write("=");                                         // Вывод знака равенство

			for (i = 0; i < numberOfMatrixRows; i++)                // Цикл заполения матрицы 
			{
				Console.SetCursorPosition(11 + (numberOfMatrixColumns * 4), 4 + i); // Координаты позиции курсора 
				Console.Write("|");

				Console.SetCursorPosition(12 + (numberOfMatrixColumns * 4), 4 + i); // Координаты позиции курсора 

				for (j = 0; j < numberOfMatrixColumns; j++)         // Цикл заполения матрицы 
				{

					Console.Write($"{massivMatriciSecond[i, j],4}");    // Вывод в консоль результата умножения

				}

				Console.Write(" |");                                    // Вывод прямого слеша 

				Console.WriteLine();                                    // Пустая строка

			}

			Console.ReadLine();		}	}}