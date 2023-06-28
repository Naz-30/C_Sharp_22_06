Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int Number = 2;

if(number > 1)
{
    while(Number <= number)
    {
        Console.Write(Number + " ");
        Number = Number + 2;
    }
}