Console.WriteLine("Выбор одежды по погоде");
Console.Write("Введите текущую погоду");
int temp = Convert.ToInt32(Console.ReadLine());

if (temp >= 20){
    Console.WriteLine("Наденьте легкую одежду");
}
else{
    Console.WriteLine("Наденьте текплую одежду");
}

Console.WriteLine("Хорошего дня");
