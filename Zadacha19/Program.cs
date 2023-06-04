Console.Clear();
Console.WriteLine("Укажите число: ");
string number = Console.ReadLine();

if (number.Length <5 && number.Length >5)
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}
else
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}