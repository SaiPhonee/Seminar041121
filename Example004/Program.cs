// 3. По введенному номеру дня недели вывести его название
Console.WriteLine("Введите число от 1 до 7");
int a =Convert.ToInt32(Console.ReadLine());
if (a<=0 && a >=7)
    Console.WriteLine("Вы  ввели некоректное число");
else 
    if (a == 1)
    Console.WriteLine("Понедельник");
    if (a == 2)
    Console.WriteLine("Вторник");
    if (a == 3)
    Console.WriteLine("Среда");
    if (a == 4)
    Console.WriteLine("Четверг");
    if (a == 5)
    Console.WriteLine("Ура !!! Пятница");
    if (a == 6)
    Console.WriteLine("Суббота");
    if (a == 7)
    Console.WriteLine("Воскресенье");
