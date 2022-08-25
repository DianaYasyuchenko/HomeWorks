//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*Console.Write("Enter size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a);

ShowArray(myArray);

int result = CountEvenElements(myArray);
Console.WriteLine($"Number of even numbers {result}");

int[] CreateRandomArray(int size)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int CountEvenElements(int[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*Console.Write("Enter size for array: ");
int array_size = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(array_size, min, max);

ShowArray(myArray);

int result = FindSumOddNumbers(myArray);
Console.WriteLine($"Sum of all odd is {result}");

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int FindSumOddNumbers(int[] array)
{
    int sum = 0;
  
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 > 0 || i % 2 < 0) 
            sum = sum + array[i];
    }
    return sum;
}*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*double[] arrayRandomNumbers = new double[10];
for (int i = 0; i < arrayRandomNumbers.Length; i++ )
{
    arrayRandomNumbers[i] = new Random().Next(1, 100);
    Console.Write(arrayRandomNumbers[i] + " ");
}

double maxNumber = arrayRandomNumbers[0];
double minNumber = arrayRandomNumbers[0];

for (int i = 1; i < arrayRandomNumbers.Length; i++)
{
    if (maxNumber < arrayRandomNumbers[i])
    {
        maxNumber = arrayRandomNumbers[i];
    }
    if (minNumber > arrayRandomNumbers[i])
    {
        minNumber = arrayRandomNumbers[i];
    }
}

double result = maxNumber - minNumber;

Console.WriteLine($"The difference between max ({maxNumber}) и min ({minNumber}) elements: {result}");*/