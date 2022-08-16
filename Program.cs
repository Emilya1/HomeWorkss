/*
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 double[,] myArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[ i, j] = new Random().Next(1, 10) + new Random().NextDouble();
           
    }
    return array;
}
void ShowwArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j ] + " ");
        }
       
    }
    Console.WriteLine();
}
Console.Write(" Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] num = new double[rows,columns];
myArray(num);
ShowwArray(num);
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void HaveIndex(int[,] array, int num1, int num2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[ i, j] = new Random().Next(1, 10);
        }
    }
    if (num1 > array.GetLength(0) && num2 > array.GetLength(1))
        Console.WriteLine($"{num1}{num2} - Такого индекса нет в массиве  ");
    else Console.WriteLine($" Значение элемента - {array[num1, num2]}");
    return ;
}
void ShowwdArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Input index of rows : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input index of columns: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[5, 5];
HaveIndex(array, num1, num2);
ShowwdArray(array);
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/
double[,] Arithmetic(double[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    int i  = 0;
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
           
    {
        for ( i = 0; i < array.GetLength(0); i++)
    {
        array[i, j] = new Random().Next(0, 10);
            result +=  array[ i, j];
       
    }
    result /= i;
    Console.WriteLine ( result + "  " );
  }
return array;
}
void ShowwArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine( );
    }
}
double[,] myArray = new double[4, 4];
Arithmetic(myArray);
ShowwArray(myArray);
