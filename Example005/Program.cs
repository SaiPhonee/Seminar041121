// 4. Найти максимальное из трех чисел
int a = 69;
int b = 34;
int c = 9;
int max = a;
if (b>max)
    max = b;
if(c>max)
    max=c;
Console.WriteLine("Максимальное число {0}", max);