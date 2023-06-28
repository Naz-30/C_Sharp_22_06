Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int Number = number % 2;

if(Number == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

