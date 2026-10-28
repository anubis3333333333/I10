Console.WriteLine("Определение оценки по баллам");
Console.Write("Введите количество баллов (0-100)");

int score = Convert.ToInt32(Console.ReadLine());

string grade;
int numericGrade;

if (score >= 91 && score <= 100){
    grade = "Отлично";
    numericGrade = 5;
}
else if (score >= 71 && score <= 90){
    grade = "Хорошо";
    numericGrade = 4;
}
else if (score >= 51 && score <= 70){
    grade = "Удовлетворительно";
    numericGrade = 3;
}

else if (score >= 0 && score <= 50){
    grade = "Неудовлетворительно";
    numericGrade = 2;
}

else{
    grade = "Ошибка";
    numericGrade = 0;
    Console.WriteLine("Ошибка (баллы от 0 до 100)");
    return;
}

Console.WriteLine("Результат");
Console.WriteLine($"{score} баллов");
Console.WriteLine($"{grade} {numericGrade}");