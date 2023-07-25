Console.Clear();
Console.WriteLine("Зададим размер исходного массива.");
Console.Write("Введите количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию искомого элемента");
Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
Random random = new Random();
int[,] array = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write("|");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(10, 99);
        Console.Write($"{array[i, j]} \t");
    }
    Console.Write("|");
    Console.WriteLine();
}
if (pos1 < 0 || pos1 > array.GetLength(0) - 1 || pos2 < 0 || pos2 > array.GetLength(1) - 1)
{
    Console.WriteLine("Искомый элемент не существует.");
}
else
{
    Console.WriteLine($"Значение элемента массива = {array[pos1, pos2]}");
}
Console.WriteLine();
