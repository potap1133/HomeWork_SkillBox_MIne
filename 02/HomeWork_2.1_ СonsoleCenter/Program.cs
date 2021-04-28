using System;

namespace HomeWork_2._1__СonsoleCenter
{
	class Program
	{
		static void Main(string[] args)
		{
			// Создание переменной, строкового типа - имя.
			string name = " Владимир ";

			// Создание переменной целочисленного типа - возраст.
			int age = 21;

			// Создание переменной целочисленного типа - рост.
			int growth = 183;

			// Создание переменной вещественного типа - балл по истории.
			double historyScore = 3;

			// Создание переменной вещественного типа - балл по математике.
			double mathScore = 2;

			// Создание переменной вещественного типа - балл по русскому языку.
			double russianLanguageScore = 3;

			// Создание переменной вещественного типа - вычисление среднего балла.
			double averageScore = (historyScore + mathScore + russianLanguageScore) / 3;

			// Присваиваем переменной значение.
			var valueName = "  Имя - " + name ;

			// Указывает расположение курсора в консоле.
			Console.SetCursorPosition((Console.WindowWidth - valueName.Length) / 2,                                             Console.WindowHeight / 2 );
			// Вывод в консоль переменной.
			Console.WriteLine( valueName );

			// Присваиваем переменной значение.
			var valueAge = " Возраст - " + age ;

			// Указывает расположение курсора в консоле.
			Console.SetCursorPosition((Console.WindowWidth - valueAge.Length) / 2,                                              (Console.WindowHeight + 2 ) / 2);

			// Вывод в консоль переменной.
			Console.WriteLine( valueAge );

			// Присваиваем переменной значение.
			var valueGrowth = "Рост" + growth;

			// Указывает расположение курсора в консоле.
			Console.SetCursorPosition((Console.WindowWidth - valueGrowth.Length) / 2,                                          (Console.WindowHeight + 4) / 2);

			//Вывод в консоль переменной.
            Console.WriteLine(valueGrowth);

			// Присваиваем переменной значение.
			var valueHistoryScore = " Балл по предмету История :" + historyScore;

			// Указывает расположение курсора в консоле.
			Console.SetCursorPosition((Console.WindowWidth - valueHistoryScore.Length) / 2,                                    (Console.WindowHeight + 8) / 2);

			// Вывод в консоль переменной.
			Console.WriteLine(valueHistoryScore);

			// Присваиваем переменной значение.
			var valueMathScore = " Балл по предмету Математика :" + mathScore;

			// Указывает расположение курсора в консоле.
			Console.SetCursorPosition((Console.WindowWidth - valueMathScore.Length) / 2,                                       (Console.WindowHeight + 10) / 2);

			// Вывод в консоль переменной.
			Console.WriteLine(valueMathScore);

			// Присваиваем переменной значение.
			var valueRussianLanguageScore = " Балл по предмету Русский язык :" + russianLanguageScore;

			// Указывает расположение курсора в консоле.
			Console.SetCursorPosition((Console.WindowWidth - valueRussianLanguageScore.Length) / 2,                            (Console.WindowHeight + 12) / 2);

			// Вывод в консоль переменной.
			Console.WriteLine(valueRussianLanguageScore);

			// Присваиваем переменной значение.
			var valueAverageScore = " Средний балл - " + averageScore.ToString("#.##");

			// Указывает расположение курсора в консоле.
			Console.SetCursorPosition((Console.WindowWidth - valueAverageScore.Length) / 2,                                    (Console.WindowHeight + 16) / 2);

			// Вывод в консоль переменной.
			Console.WriteLine(valueAverageScore);

			Console.ReadKey();

		}
	}
}
