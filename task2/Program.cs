Random random = new Random();
bool playAgain = true;

while (playAgain)
{
    Console.Clear();
    Console.WriteLine("Игра Угадай число");
    Console.WriteLine("Компьютер загадал число от 1 до 100. Попробуйте его угадать!");

    int targetNumber = random.Next(1, 101); 
    int attempts = 0;
    bool hasGuessed = false;

    while (!hasGuessed)
    {
        Console.Write("\nВведите ваш вариант: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int userGuess) || userGuess < 1 || userGuess > 100)
        {
            Console.WriteLine("Ошибка! Пожалуйста, введите целое число от 1 до 100.");
            continue;
        }

        attempts++; 

        if (userGuess < targetNumber)
        {
            Console.WriteLine("Загаданное число БОЛЬШЕ.");
        }
        else if (userGuess > targetNumber)
        {
            Console.WriteLine("Загаданное число МЕНЬШЕ.");
        }
        else
        {
            Console.WriteLine($"\nПоздравляем! Вы угадали число {targetNumber}!");
            Console.WriteLine($"Количество затраченных попыток: {attempts}");
            hasGuessed = true;
        }
    }

    Console.Write("\nХотите сыграть ещё раз? (да/нет): ");
    string answer = Console.ReadLine()?.Trim().ToLower();
    if (answer != "да" && answer != "y")
    {
        playAgain = false;
    }
}

Console.WriteLine("\nСпасибо за игру! До свидания!");