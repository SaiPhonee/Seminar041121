//Показать числа от -N до N
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int a = n;
n = -n;
Console.WriteLine(" ");
for (int i = n; i <= a; i++)
{
    Console.Write(i + " ");
}