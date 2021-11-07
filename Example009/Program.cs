//8. Показать четные числа от 1 до N
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
if (n <= 1)
    Console.WriteLine("Введено неверное значение");
else
    for (int i = 2; i <= n;)
    {
        Console.Write(i + " ");
        i = i + 2;
    }