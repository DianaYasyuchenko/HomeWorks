//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*void PalindromeFinder (int number)
{
    if(number >= 10000 && number <= 99999)
    {
        int first_digit = number /10000;
        int second_digit = (number % 10000) / 1000; 
        int forth_digit = (number % 100) / 10;
        int fifth_digit = number % 10;
        if(first_digit == fifth_digit && second_digit == forth_digit)
        {
            Console.WriteLine($"Number {number} is a palindrom");
        }
        else
        {
            Console.WriteLine($"Number {number} is not a palindrom");
        }             
    }
    else
        Console.WriteLine("Number out of range, should be 5 digits");
}
Console.Write("Enter 5 digits number: ");
int palindrom = Convert.ToInt32(Console.ReadLine());
PalindromeFinder(palindrom);*/


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*double DistanceFinder (double x1, double y1, double z1, double x2, double y2, double z2)
{
    return System.Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)),2);  
}
Console.Write("Enter x1: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter y1: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter z1: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter x2: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter y2: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter z2: ");
double zB = Convert.ToDouble(Console.ReadLine());
double coordinate = DistanceFinder(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Distance is {coordinate}");*/


//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*void BuildCube (int n)
{
    int current = 1;
    while(current <= n)
    {
        Console.WriteLine($"Cube number {current} = {current * current * current}");
        current++;
    }
}
Console.Write("Enter integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
BuildCube(number);*/