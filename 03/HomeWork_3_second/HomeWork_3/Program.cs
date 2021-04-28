using System;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            newGame:

            // Запрос имени игрока №1.
            Console.Write( " Здравствуйте. Введите свое имя, Игрок №1 : " );

            //Считывание имени, введеного играком № 1.
            var firstNameGamer = Console.ReadLine();

            // Запрос имени игрока №2.
            Console.Write( " Здравствуйте. Введите свое имя, Игрок №2 : " );

            //Считывание имени, Введеного играком № 2.
            var secondNameGamer = Console.ReadLine();

            // Создание переменной randomize для получения псевдослучайных чисел.
            Random randomize = new Random();

            // Получение случайного числа в диапозоне: от 12 до 120.
            int randomGamesNumber = randomize.Next( 12, 120);

            // Вывод  в консоль пустой строки
            Console.WriteLine(); 

            // Обращение к игрокам. Вывод числа для игры. 
            Console.WriteLine($" Игроки, {firstNameGamer} и {secondNameGamer} \n!" +
                              $" Компьютер предлогает вам для игры Число: {randomGamesNumber} \n\n ");


            // Создаем цикл для ввода и проверки чисел введеных игроками.
            while (randomGamesNumber > 0) 
            {

                if (randomGamesNumber >= 0)
                {
                    // Результаты вычетов. Число с которым будет работать первый игрок 
                    Console.WriteLine($" Число: {randomGamesNumber} ");

                }

                // Обращение к игроку № 1. Ввод числа
                Console.Write(" Ход User1 : ");

                // Считывание введеного числа Игроком №1
                var numberFirstGamer = int.Parse(Console.ReadLine());

                // Вывод пустой строки.
                Console.WriteLine();

                // Выполняется проверка введенного игроком числа.
                if (( numberFirstGamer >= 1) && (numberFirstGamer <= 4))
                {
                    // Выполняется ход игрока. Уменьшение предложенного компьютером числа на введеное.
                    randomGamesNumber -= numberFirstGamer; 
                                                            
                }
                else 
                {
                    // Сообщение об ошибке
                    Console.WriteLine(" Ведено не верное число!!!! Попробуйте еще раз ");

                    // Возврат к вводу игроком числа.
                    continue;
                }

               
                // Проверка числа на больше или равно нулю.
                if (randomGamesNumber <= 0 )
                {
                    // Вывод поздравления игроку информфции о победе.
                    Console.WriteLine($" Поздравляем, {firstNameGamer}, Вы ПОБЕДИТЕЛЬ!!!!!! ");

                    // Прерывание работы блока.
                    break;
                }

                if (randomGamesNumber >= 0)
                {
                    // Результаты вычетов. Число с которым будет работать первый игрок 
                    Console.WriteLine($" Число: {randomGamesNumber} ");

                }

                // Обращение к игроку № 2. Ввод числа
                Console.Write(" Ход User2 : ");

                // Считывание введеного числа Игроком №1
                var numberSecondGamer = int.Parse(Console.ReadLine());

                // Вывод пустой строки.
                Console.WriteLine();

                // Выполняется проверка введенного игроком числа.
                if ((numberSecondGamer >= 1) && (numberSecondGamer <= 4))
                {
                    // Выполняется ход игрока. Уменьшение предложенного компьютером числа на введеное.
                    randomGamesNumber -= numberSecondGamer;
                }
                else
                {
                    // Сообщение об ошибке
                    Console.WriteLine(" Ведено не верное число!!!! Попробуйте еще раз ");

                    // Возврат к вводу игроком числа.
                    continue;
                }

                // Проверка числа на больше или равно нулю.
                if (randomGamesNumber <= 0 )
                {
                    // Вывод поздравления игроку информфции о победе.
                    Console.WriteLine($" Поздравляем, {secondNameGamer}, Вы ПОБЕДИТЕЛЬ!!!!!! ");

                    // Прерывание работы блока.
                    break;
                }

            }

            // Вывод пустой строки.
            Console.WriteLine();

            // Ожидание нажатия любой клавиши
            Console.ReadKey();

            // Выводит вопрос о реванше.
            Console.Write(" Хотели бы вы провести РЕВАНШ? : \n 1 - да. \n 2 - нет. \n Ваш выбор: ");

            // Считывает ответ.
            int yesOrNot = int.Parse(Console.ReadLine());

            // Определение выбора по вводу данных игроком
            switch (yesOrNot)
            {
                case 1:
                    // Возвращает к началу игры.
                    goto newGame;
                    break;

                default:
                    // Вывод информации об окончании игры.
                    Console.WriteLine(" КОНЕЦ ИГРЫ \n");
                    break;                
            }

           
           

            

            
        }
    }
}
