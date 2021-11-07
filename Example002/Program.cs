// 1. По двум введённым числам проверять является ли первое квадратом второго
// int a = 5;
//int b = 25;
Console.WriteLine("Введите а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
int b = Convert.ToInt32(Console.ReadLine());
if (b == a * a)
    Console.WriteLine("Является");
else
    Console.WriteLine("Не является");