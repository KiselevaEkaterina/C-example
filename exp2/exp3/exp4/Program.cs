// на вход принимает число N,а на выходе показывает все четные числа (от 1 до 10)

Console.Write("Ведите любое число: ");
int namber=int.Parse(Console.ReadLine()!);
int count=1;
while (count<=namber)
{
    if (count%2==0)
    {
        Console.WriteLine($"{count}");
        
    }
        count++; 
}
