
// ChTask47 Задайте 2-х мерный массив размером mхn, заполненный случайными вещественными 
// числами


/* using System;
using static System.Console;

Clear();

Write("Введите колличество строк массива:  ");
int rows = int.Parse(ReadLine());

Write("Введите колличество столбцов массива:  ");
int columns = int.Parse(ReadLine());

double [,] array  = GetArray(rows, columns, 0, 10);
PrintArray(array);

double [,] GetArray (int m, int n, int min, int max)
{
double [,] result = new double [m, n];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < m; j++)
{
    result[i, j] = new Random().NextDouble()*(max - min);
}
}
return result;
}

void PrintArray(double[,] inArray)
{
for(int i = 0; i < inArray.GetLength(0); i++)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
 {
    Write($"{inArray[i,j]:f1} ");
 }
WriteLine();
}
}



 */
// ChTask52 Задайте 2-х мерный массив из целых чисел. Найдите среднее арифметическое элементов в
// каждом столбце

/* 


using System;
using static System.Console;
Clear();

Write("Введите колличество строк массива:  ");
int rows = int.Parse(ReadLine());
Write("Введите колличество столбцов массива:  ");
int columns = int.Parse(ReadLine());
int [,] array  = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[] averageColumns=GetResultArray(array);
WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ",averageColumns)}");


int [,] GetArray (int m, int n, int min, int max)
{
int [,] result = new int [m, n];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < m; j++)
{
    result[i, j] = new Random().Next(min, max + 1);
}
}
return result;
}

void PrintArray(int[,] inArray)
{
for(int i = 0; i < inArray.GetLength(0); i++)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
 {
    Write($"{inArray[i,j]} ");
 }
WriteLine();
}
}

double[] GetResultArray(int[,] array)
{
   double[] result = new double[array.GetLength(1)];
   for (int i = 0; i < array.GetLength(1); i++) 
   {
    double sum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum+=array[j, i];
    }
    result[i]=Math.Round(sum/array.GetLength(0),2);
   }
   return result;
} 


*/










// ChTask50 Напишите программу, которая на вход принимает позицию элемента в 2-х мерном массиве и
// возращает значение этого элемента или указание, что такого элемента нет.

/*


using System;
using static System.Console;

Clear();

Write("Введите колличество строк массива:  ");
int rows = int.Parse(ReadLine());
Write("Введите колличество столбцов массива:  ");
int columns = int.Parse(ReadLine());
int [,] array  = GetArray(rows, columns, 0, 10);
PrintArray(array);
Write("Введите значение элемента:  ");
int element = int.Parse(ReadLine());
if(FindElement(array, element))
{
 WriteLine("Элемент найден");   
}
else
{
 WriteLine("Элемент не найден");     
}

int [,] GetArray (int m, int n, int min, int max)
{
int [,] result = new int [m, n];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < m; j++)
{
    result[i, j] = new Random().Next(min, max + 1);
}

}
return result;
}

void PrintArray(int[,] inArray)
{
for(int i = 0; i < inArray.GetLength(0); i++)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
 {
    Write($"{inArray[i,j]} ");
 }
WriteLine();
}
}

bool FindElement(int[,] array, int el)
{
for(int i = 0 ;i > array.GetLength(0); i++)
{
    for(int j = 0 ;j > array.GetLength(1); j++)
    {
        if (array[i, j]==el) return true;
    }
} 
return false;   
} 


*/


// ЕЩЕ ОДИН ВАРИАНТ ИЗ НЕТА:

// static void Main(string[] args) (опубликован в данной функции, но вызвать фнукцию не получилось т.к. времени не хватило, поэтому код разделен и часть без функции в принципе работает, но из выполненения выходит через Ctrl + C)
/* 

Console.Write("Введите первой число для определения позиции поиска  элемента :");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите второе число для определения позиции поиска  элемента:");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5; // размер массива
int m = 7; // размер массива
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив:");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(10, 99);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}
if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}
Console.ReadLine();
 
    
 



 */