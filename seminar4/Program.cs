//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*int exponentiationOfNumber(int numberA, int numberB)
{
    int result = 1;
    
    for(int i=1; i <= numberB; i++)
        result = result * numberA;
    
    return result;
  
}
Console.Write("Enter number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = exponentiationOfNumber(numberA, numberB);
Console.WriteLine($"The number {numberA} in {numberB} degree is {result}");*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*int SumOfDigits (int number)
{
    int sum = 0; 
    while (number > 0)
    {
        sum = sum + number%10;  
        number = (number - number % 10) / 10;
    }         
    return sum;
}
Console.Write("Enter integer number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int result = SumOfDigits(numberA);
Console.WriteLine($"Sum of the digits in the number {numberA} is {result}");*/


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*Console.Write("Input size for array: ");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray (sizeOfArray);
ShowArray(myArray);

int[] CreateArray(int size)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i} element of the array: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());    
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}*/