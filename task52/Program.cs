Console.Clear();
Random random = new Random();
int[,] array = new int[random.Next(1, 10), random.Next(1, 10)];
Console.WriteLine("Сгенерированный массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write("|");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write($"{array[i, j]} \t");
    }
    Console.Write("|");
    Console.WriteLine();
}
Console.WriteLine($"Количество элеметов в каждом столбце: {array.GetLength(0)}");
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.WriteLine($"Среднее арифметическое в {j + 1} столбце = {Math.Round(sum / array.GetLength(0), 3)} ");
}
Console.WriteLine();
