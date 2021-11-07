// 5. Написать программу вычисления значения функции y=f(a)
Console.WriteLine("Введите а");
int x = Convert.ToInt32(Console.ReadLine());
// int x =  4;
void Funk (int x)
{
    int y = x*x  -1;
    Console.WriteLine("f({0}) = {1}",x,y);
}
Funk(x);
