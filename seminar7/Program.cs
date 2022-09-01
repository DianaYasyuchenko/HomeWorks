// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*Console.Write("Enter number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandomArray(m, n, min, max);
double[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for(int i = 0; i < rows; i++)
    for(int j = 0; j < columns; j++)
        newArray[i,j] = Math.Round(Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) + new Random().NextDouble(), 1);
    return newArray;
}
void ShowArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*Console.Write("Enter number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter position of the row: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter position of the column: ");
int column1 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(m, n, min, max);
ShowArray(myArray);
FindElementByCoordinats(myArray, row1, column1);

int[,] CreateRandomArray(int rows, int columns,int minValue, int maxValue)
{ int[,] newArray = new int[rows, columns];
   
    for(int i = 0; i < rows; i++) 
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}  
void ShowArray(int[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine();
    }
}                               
void FindElementByCoordinats (int[,] array, int indexOfRow, int indexOfColumn)
{
    if(indexOfRow > array.GetLength(0) || indexOfColumn > array.GetLength(1)) 
    {
        Console.WriteLine($"This element doesn't exist.");
    }
    else 
        Console.WriteLine($"{array[indexOfRow - 1, indexOfColumn - 1]} is the element of array under your coordinates");
}*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*Console.Write("Enter number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
CreatRandom2dArray(numbers);
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
ShowArray(numbers);
void CreatRandom2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}*/