Console.WriteLine("Калькулятор Индекса Массы Тела (ИМТ)");


Console.Write("Введите ваш вес в килограммах (например, 75): ");
if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0)
{
Console.WriteLine("Ошибка: Введено некорректное значение веса.");
return;
}

Console.Write("Введите ваш рост в метрах (например, 1.75): ");
if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0)
{
Console.WriteLine("Ошибка: Введено некорректное значение роста.");
return;
}


double bmi = weight / (height * height);
Console.WriteLine($"\nВаш ИМТ: {bmi:F1}");


string category;
string recommendation;

if (bmi < 18.5)
{
category = "Недостаточный вес";
recommendation = "Рекомендуется усиленное сбалансированное питание и консультация со специалистом.";
}
else if (bmi >= 18.5 && bmi <= 24.9)
{
category = "Нормальный вес";
recommendation = "Отлично! Поддерживайте текущий образ жизни, правильное питание и физическую активность.";
}
else if (bmi >= 25 && bmi <= 29.9)
{
category = "Избыточный вес";
recommendation = "Рекомендуется обратить внимание на диету и увеличить уровень ежедневной физической активности.";
}
else 
{
category = "Ожирение";
recommendation = "Рекомендуется проконсультироваться с врачом-диетологом и составить план снижения веса.";
}

Console.WriteLine($"Категория: {category}");
Console.WriteLine($"Рекомендация: {recommendation}");