// программа показывает выходной

Console.WriteLine("Введите число: ");
int a= int.Parse(Console.ReadLine()!);
if (a==6 || a==7)
{
    Console.Write("Да,выходной");
}
else
{

    if (a<1 && a>5)
{
    Console.Write("Нет, не выходной");
}
}