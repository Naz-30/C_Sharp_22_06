int max = 0;

Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine()!);

if(firstNumber > max)
{
    max = firstNumber;
}
if(secondNumber > max)
{
    max = secondNumber;
}
if(thirdNumber > max)
{
    max = thirdNumber;
}

Console.WriteLine("max = " + max);
