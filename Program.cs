//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*Console.WriteLine("Input first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
    Console.WriteLine($"{a} is max number");
else
    Console.WriteLine($"{b} is max number");*/
   

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*Console.WriteLine("Input first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number:");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if( b > max )
    max = b;
if ( c > max ) 
    max = c;
    
Console.WriteLine($"{max} is max number");*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*Console.WriteLine("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number%2 == 0) 
{
    Console.WriteLine($"{number} is an even number");
}
else
{
    Console.WriteLine($"{number} is an odd number");
}*/


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*Console.WriteLine("Input number starting with one: ");
int number = Convert.ToInt32(Console.ReadLine());
int for_even_validation = 2;
while(for_even_validation <= number)
{
    Console.Write(for_even_validation + " ");
    if(for_even_validation%2 == 0)    
        for_even_validation = for_even_validation + 2;
}*/