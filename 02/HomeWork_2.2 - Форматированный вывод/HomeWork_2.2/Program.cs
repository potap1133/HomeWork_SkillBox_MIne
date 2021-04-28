using System;

namespace HomeWork_2._2
{
    class Program
    {
		/// <summary>
		/// Начало программы - точка входа. Решение задачи с использованием формативного вывода.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
        {

			// Создание переменной, строкового типа - имя.
			string name = "Генадий";

			// Создание переменной целочисленного типа - возраст.
			int age = 21;

			// Создание переменной целочисленного типа - рост.
			int height = 183;

			// Создание переменной вещественного типа - балл по истории.
			double historyScore = 3;

			// Создание переменной вещественного типа - балл по математике.
			double mathScore = 3;

			// Создание переменной вещественного типа - балл по русскому языку.
			double russianLanguageScore = 2;

			// Создание переменной вещественного типа - вычисление среднего балла.
			double averageScore = (historyScore + mathScore + russianLanguageScore) / 3;

			// Вывод в консоль значений переменных: имя, возраст, рост.
			Console.WriteLine(" Имя - {0} \n Возраст - {1} \n Рост - {2} ",
				              name ,
							  age ,
							  height );

            // Вывод в консоль пустой строки.
            Console.WriteLine();

            // Вывод в консоль баллов по: истории, математике, русскому языку.
            Console.WriteLine(" Балл по предмету История - {0} " +
				           " \n Балл по предмету Математика - {1} " +
				           " \n Балл по предмету Русский язык {2} ", 
						      historyScore,
							  mathScore,
							  russianLanguageScore);

			// Вывод в консоль пустой строки.
			Console.WriteLine();

			// Вывод в консоль средний балл.
			Console.WriteLine(" Средний балл - {0:#.##} ", averageScore);

			Console.ReadKey();

		}
	}
}
