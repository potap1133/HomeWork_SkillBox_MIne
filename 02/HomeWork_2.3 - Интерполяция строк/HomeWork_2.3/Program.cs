using System;

namespace HomeWork_2._3
{
    class Program
    {
        /// <summary>
        /// Начало программы - точка входа. Решение задачи с использованием интерполяции строк.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
			// Создание переменной, строкового типа - имя.
			string name = "Андрей";

			// Создание переменной целочисленного типа - возраст.
			int age = 33;

			// Создание переменной целочисленного типа - рост.
			int height = 167;

			// Создание переменной вещественного типа - балл по истории.
			double historyScore = 5;

			// Создание переменной вещественного типа - балл по математике.
			double mathScore = 2;

			// Создание переменной вещественного типа - балл по русскому языку.
			double russianLanguageScore = 5;

			// Создание переменной вещественного типа - вычисление среднего балла.
			double averageScore = (historyScore + mathScore + russianLanguageScore) / 3;

			Console.SetCursorPosition(Console./2, Console.WindowHeight/2);
			
			// Вывод в консоль значений переменных: имя, возраст, рост.
			Console.WriteLine($" Имя - {name} \n Возраст - {age} \n Рост - {height} ");

			// вывод в консоль пустой строки.
			Console.WriteLine();

			// Вывод в консоль баллов по: истории, математике, русскому языку.
			Console.WriteLine($" Балл по предмету История - {historyScore} " +
						   $" \n Балл по предмету Математика - {mathScore} " +
						   $" \n Балл по предмету Русский язык {russianLanguageScore} ");

			// Вывод в консоль пустой строки.
			Console.WriteLine();

			// Вывод в консоль средний балл.
			Console.WriteLine($" Средний балл - {averageScore: #.##} ");

			Console.ReadKey();
		}
	}
}
