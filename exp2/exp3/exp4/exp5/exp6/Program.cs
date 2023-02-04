// выдает третье число заданного числа или что его нет.

Console.WriteLine("Ведите любое число: ");
int x= int.Parse(Console.ReadLine()!);
int x1=x/100;
x1= Math.Abs(x1);
if (x1 < 1)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
    x1 %= 10;
    Console.WriteLine($"Введеное число {x},третье число {x1}");
}