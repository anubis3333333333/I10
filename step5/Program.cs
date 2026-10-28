Console.WriteLine("Подъем по лестницу");

Console.Write("На какой этаж нужно подняться?");
int targetfloor = Convert.ToInt32(Console.ReadLine());

int currentfloor = 1;
Console.WriteLine("Начинаем подъем");

while(currentfloor < targetfloor){
    currentfloor++;
    Console.WriteLine($"Поднялись на {currentfloor} этаж");
}

Console.WriteLine($"Вы достигли {targetfloor} этажа");
Console.WriteLine("Конец программы");
