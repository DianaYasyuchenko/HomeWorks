//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*Console.Write("Enter three-digit number: ");
int currentNumber = Convert.ToInt32(Console.ReadLine());
int secondDigit = getSecondDigit(currentNumber);

int getSecondDigit(int number)
{
    int des = number / 10 % 10;
    return des;
}

Console.WriteLine($"Second digit is {secondDigit}");*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberToString = Convert.ToString(number);
{
    if (numberToString.Length > 2)
    {
        Console.WriteLine("Third digit: " + numberToString[2]);
    }
    else
    {
        Console.WriteLine("The number does not have a third digit"); 
    }
}*/


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
/*Console.Write("Enter the number of the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber < 6 && dayNumber > 0)
{
    Console.WriteLine("This day is a working day");
} else if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("This day is a holiday");
}
else if (dayNumber <= 0 || dayNumber > 7)
{
    Console.WriteLine("The entered number is out of range from 1 to 7");
}*/