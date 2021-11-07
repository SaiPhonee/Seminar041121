// 2. Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine("Большее {0}, меньшее {1}", a, b);
else if (a == b)
    Console.WriteLine("Числа a и b равны и их значение {0}", a);
else
    Console.WriteLine("Большее {0}, меньшее {1}", b, a);