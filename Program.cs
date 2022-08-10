void Zadacha50()
{
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет. (перегрузка не получилась, поэтому пришлось вывести в отдельный файл)

    Random random = new Random(); 
    int rows = random.Next(2, 6);
    int columns = random.Next(4, 9);

    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    
    Console.WriteLine("Введите строку искомого элемента");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца искомого элемента");
    int column = Convert.ToInt32(Console.ReadLine());
    if (row >= 1 && row <= rows && column >= 1 && column <= columns)
    {
        Console.WriteLine($"Искомый элемент array[{row - 1}, {column - 1}] = {array[row - 1, column - 1]}");
    }
    else
    {
        Console.WriteLine("Искомый элемент не найден");
    }
        
}

void Zadacha52()
{
//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

    Random random = new Random(); 
    int rows = random.Next(2, 6);
    int columns = random.Next(4, 9);

    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);

    //Console.WriteLine();
    for(int j = 0; j < columns; j++)
    {
        double sum = 0;
        for(int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        Console.Write(sum/rows + "\t");
       
    }
    Console.WriteLine();

}
Zadacha50();
//Zadacha52();

static void FillArray(int[,] array)
{
    Random random = new Random(); 
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
       for(int j = 0; j < columns; j++)
       {
            array[i, j] = random.Next(0, 10);
       }
    }

}

static void PrintArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
       for(int j = 0; j < columns; j++)
       {
            Console.Write(array[i, j] + "\t");
       }
        Console.WriteLine();
    }
    Console.WriteLine();  

}
      
