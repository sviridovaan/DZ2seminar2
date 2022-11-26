//напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    while (number / 10 >= 100)
    {
        number = number/10;
    }
    if (number / 10 < 10)
    {
        Console.WriteLine($"Третьей цифры у числа нет");
    }
    else
    {
        Console.WriteLine($"Третья цифра заданного числа равна {number%10}");
    }
}
else
{
    while (number / 10 <= -100)
    {
        number = number/10;
    }
    if (number / 10 >- 10)
    {
        Console.WriteLine($"Третьей цифры у числа нет");
    }
    else
    {
        Console.WriteLine($"Третья цифра заданного числа равна {-number%10}");
    }
}