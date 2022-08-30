/*
//56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int [,] MyArray(int [,] array)
{
    for ( int i = 0; i < array.GetLength(0); i ++)
    {
         for ( int j = 0; j < array.GetLength(1); j ++)
            array[i, j] = new Random().Next(1,10);
    }
    return array;
}
int Sum(int [,] array, int i)
{
    int result = array[i,0];

    for(int j = 0; j < array.GetLength(1); j ++)
    {
        result += array[i,j];
    }
    return result;
}
void MinRows (int [,] array)
{
    int minI = 1;
    int result1 = Sum(array, 0);
    for(int i = 0; i < array.GetLength(0); i ++)
    {
        int result2 = Sum(array, i);
        if(result1 > result2)
        {
            result1 = result2;
            minI = i + 1;
        }
        
    }
    Console.WriteLine(minI);
}

void ShowAaray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();

    }
    Console.WriteLine();
}

int[,] arrayy = new int[5, 4];
int i = 0;
Sum(arrayy, i);
MinRows(arrayy);
ShowAaray(MyArray(arrayy));



//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Numbers (int [,]array)
{
        for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
}

void DcreasingElements(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
      {

        for (int j = 0; j < array.GetLength(1) - 1 ; j++)
        {
                    
            for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            if (array[ i, k + 1] > array[ i, k ] )
            {
            int temp = array[ i, k + 1];
            array[ i  ,k + 1]= array[   i, k  ];
            array[   i, k] = temp;
            }
            }
        }
      }
        
}
void ShowAaray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = new int[4, 4];
Numbers(myArray);
ShowAaray(myArray);
DcreasingElements(myArray);
ShowAaray(myArray);

//60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] NewArray(int[,,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            for (int k = 0; k < array.GetLength(2) ; k++)
            {
                
               int max=array[0,0,0];
               if (array[i,j,k] == array[i + 1, j + 1, k +1])
               {
                max ++;
                array[i + 1, j + 1, k + 1] = max;
               }


            }
        }

    }
    return array;
}
void MyArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            for (int k = 0; k < array.GetLength(2) ;k++)
            {
                    array[i, j, k] = new Random().Next(10, 99);
                Console.Write($"{array[i, j, k]} {(i, j, k)} ");

            }
             Console.WriteLine(); 
        }
      
    }

}
void ShowAaray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i, j, k] + i + j + k + " ");
            Console.WriteLine();
        }

    }
    Console.WriteLine();
}
int[,,] myArray = new int[2, 2, 2];
MyArray(myArray);
ShowAaray(NewArray(myArray));
*/



// 62. Заполните спирально массив 4 на 4.
void Spiral(int[,] array, int num)
{
    int i = 1;
    int x = 0;
    int y = -1;
    int row = 0;
    int column = 1;
    while (i <= num * num)
        if (0 <= x + row)
            if (x + row < num && 0 <= y + column)
                if(y + column < num)
                { 
                    x += row;
                    y += column;
                    array[x, y] = i;
                    i += 1;
                }
        else
        if (column == 1)
        {
            column = 0;
            row  = 1;
        }
    else
    if (row == 1)
    {
        row = 0;
        column = 1;
    }
    else
    if (column == 1)
    {
        column = 0;
        row = -1;
    }
    else
    if(row == - 1)
    {
        row = 0;
        column= 0;
    }
}
int[,] myArray = new int[4, 4];
int num = 4;
Spiral(myArray, num);
