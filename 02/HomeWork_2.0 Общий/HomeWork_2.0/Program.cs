using System;

namespace HomeWork_2._0
{
    class Program
    {
		/// <summary>
		/// Начало программы. Обычнй вывод, форматированный вывод, интерполярный вывод в консоль.
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

			// Вывод названия.
			Console.WriteLine("Решение задачи с использованием обычного вывода.");

			Console.ReadKey(); Console.Clear();

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

			Console.ReadKey(); Console.Clear();

			// Вывод названия.
			Console.WriteLine("Решение задачи с использованием форматированного вывода.");

			Console.ReadKey(); Console.Clear();

			// Вывод в консоль значений переменных: имя, возраст, рост.
			Console.WriteLine(" Имя - {0} \n Возраст - {1} \n Рост - {2} ",
							  name,
							  age,
							  height);

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

			Console.ReadKey(); Console.Clear();

			// Вывод названия.
			Console.WriteLine(" Решение задачи с использованием интерполяции строк.");

			Console.ReadKey(); Console.Clear();

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
