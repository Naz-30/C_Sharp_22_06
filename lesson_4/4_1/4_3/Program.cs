int Prompt(string message)
{
    System.Console.Write(message);
    string ReadInput=System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}
int[] GenerateArray(int Lenght, int minValue, int MaxValue)
{
    int [] array = new int[Lenght];
    Random random = new Random();
    for(int i = 0; i<Lenght; i++)
    {
        array[i]=random.Next(minValue, maxValue+1);
    }
    return array;

}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i=0; i<array.Length-1; i++)
    {
        System.Console.Write($"{array[i]}");

    }
    System.Console.Write("]");
}
int lenght = Prompt("Длина массива:");
int min= Prompt("");
int max= Prompt("");
int[] Array= GenerateArray(Lenght, min,max);
PrintArray(array);