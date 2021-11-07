//10. Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1000 && n > 99)
{
    n = n % 100 / 10;
    Console.WriteLine("Вторая {0}", n);
}
else
    Console.WriteLine("Введено неверное значение");