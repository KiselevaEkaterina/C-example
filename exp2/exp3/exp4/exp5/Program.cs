// на вход принимает 3 числа и выдает второе число в нем

Console.Write($"Ведите трехзначное число: ");
int x=int.Parse(Console.ReadLine()!);
int x1= x / 10 % 10;
Console.WriteLine($"Веденое число - {x}, вторая цифра числа - {x1}");
