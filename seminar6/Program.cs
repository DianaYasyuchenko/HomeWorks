// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*Console.Write($"Enter amount of numbers: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[number];

void InputNumbers(int number)
{
  for (int i = 0; i < number; i++)
  {
    Console.Write($"Enter {i+1} number: ");
    arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}
int Array(int[] arrayNumbers)
{
  int count = 0;
  for (int i = 0; i < arrayNumbers.Length; i++)
  {
    if(arrayNumbers[i] > 0 ) count += 1; 
  }
  return count;
}
InputNumbers(number);
Console.WriteLine($"Numbers greater than zero: {Array(arrayNumbers)} ");*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*double[,] coefficient = new double[2, 2];
double[] crossPoint = new double[2];

InputCoefficients();
ShowEquation(coefficient);

void InputCoefficients()
{
  for (int i = 0; i < coefficient.GetLength(0); i++)
  {
    for (int j = 0; j < coefficient.GetLength(1); j++)
    {
      if (j == 0)
      {
        Console.Write($"Enter coefficient k{i+1}: ");
      }
      else
      {
        Console.Write($"Enter coefficient b{i+1}: ");
      }
      
      coefficient[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}
double[] Decision(double[,] coefficient)
{
  crossPoint[0] = (coefficient[1,1] - coefficient[0,1]) / (coefficient[0,0] - coefficient[1,0]);
  crossPoint[1] = crossPoint[0] * coefficient[0,0] + coefficient[0,1];
  return crossPoint;
}
void ShowEquation(double[,] coefficient)
{
  if (coefficient[0,0] == coefficient[1,0] && coefficient[0,1] == coefficient[1,1]) 
  {
    Console.Write($"Coincidence");
  }
  else if (coefficient[0,0] == coefficient[1,0] && coefficient[0,1] != coefficient[1,1]) 
  {
    Console.Write($"Straight lines are parallel");
  }
  else 
  {
    Decision(coefficient);
    Console.Write($"Intersection points: ({crossPoint[0]}, {crossPoint[1]})");
  }
}*/