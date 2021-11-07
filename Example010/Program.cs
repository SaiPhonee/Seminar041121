//9. Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1000 && n > 99)
{
    n = n % 10;
    Console.WriteLine("Последняя цифра {0}", n);
}
else
    Console.WriteLine("Введено неверное значение");