using System;
using System.Diagnostics;

namespace HomeWork_2._1
{
	class Program
	{
		/// <summary>
		/// Начало программы - точка входа. Решение задачи с использованием обычного вывода.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{

			// Создание переменной, строкового типа - имя.
			string name = " Владимир ";

			// Создание переменной целочисленного типа - возраст.
			int age = 21;

			// Создание переменной целочисленного типа - рост.
			int height = 183;

			// Создание переменной вещественного типа - балл по истории.
			double historyScore = 3;

			// Создание переменной вещественного типа - балл по математике.
			double mathScore = 2;

			// Создание переменной вещественного типа - балл по русскому языку.
			double russianLanguageScore = 3;

			// Создание переменной вещественного типа - вычисление среднего балла.
			double averageScore = (historyScore + mathScore + russianLanguageScore) / 3;


			// Вывод в консоль имя.
			Console.WriteLine(" Имя - " + name);
			
			// Вывод в консоль возроста.
			Console.WriteLine(" Возраст - " + age);

			// Вывод в консоль роста.
			Console.WriteLine(" Рост - " + height);

			// Вывод в консоль пустой строки.
			Console.WriteLine();

			// Вывод в консоль балл по истори.
			Console.WriteLine(" Балл по предмету История : " + historyScore);

			// Вывод в консоль балл по математике.
			Console.WriteLine(" Балл по предмету Математика : " + mathScore);

			// Вывод в консоль балл по русскому языку.
			Console.WriteLine(" Балл по предмету Русский язык :" + russianLanguageScore);

			// Вывод в консоль пустой строки.
			Console.WriteLine();

			// Вывод в консоль средний балл.
			Console.WriteLine(" Средний балл - " + averageScore.ToString("#.##"));
			
			Console.ReadKey();
			
		}	
	}
}
