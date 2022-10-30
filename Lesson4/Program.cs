﻿
//СХЕМА ОПИСАНИЯ 2 МЕРНОГО МАССИВА


// 1 - тип данных
// 2 - квадратные скобки с запятой которая указыает на 2 мерность (м.м.т.к. разделяет пространство между скобок на 2 части)
// 3 - имя массива (индефикатор)
// 4 - оператор присваивания
// 5 - условие
// 6 - сколько используется строк (затем может использоваться альтернативный синтаксис matrix.GetLength(0) для получения (считывания) этих данных)
// 7 - сколько используется столбцов (затем может использоваться альтернативный синтаксис matrix.GetLength(1) для получения (считывания) этих данных)

//  1  2   3    4  5   1  6 7
// int[,]matrix = new int[5,8];

// Как обратиться к элементу массива:

/* string[,] table = new string[2,5];
// table[0,0] table[0,1] table[0,2]... table[0,4]
// table[1,0] table[1,1] table[1,2]... table[1,4]


table[1,2] = "слово";

for(int rows = 0; rows < 2; rows++ )
{
     for (int columns = 0; columns < 5; columns++) 
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
 */
/* // ЦИФРОВАЯ МАТРИЦА (ТАБЛИЦА )
 int[,] matrix = new int[3, 4];

 for (int i = 0; i < 3; i++) // i считывает в строчном направлении
 {
    for (int j = 0; j < 4; j++) // j считывает по-столбцам
    {
        Console.Write($"{matrix[i, j]} "); // пробел между фиг.скобой и закрывающими прямыми 
        // ковычками используем для выводу через пробел
    }
    Console.WriteLine(); // используем для вывода каждой следующей строки вывода с новой строки
 } */

 /* int[,] matrix = new int[3, 4];

 for (int i = 0; i < matrix.GetLength(0); i++) // i считывает в строчном напрвлении, используем новый функционал matrix.GetLength(0) (данная конструкция с использование 0 в скобках выводит данные матрицы в строчном направлении)
 {
    for (int j = 0; j < matrix.GetLength(1); j++) // j считывает по-столбцам, используем новый функционал matrix.GetLength(0) (данная конструкция с использование 1 в скобках выводит данные матрицы по столбцам)
    {
        Console.Write($"{matrix[i, j]} "); // пробел между фиг.скобой и закрывающими прямыми ковычками используем для выводу через пробел
    }
    Console.WriteLine(); // используем для вывода каждой следующей строки вывода с новой строки
 } */

 /* void PrintArray(int[,] matr) // Создаем метод
 {

 for (int i = 0; i < matr.GetLength(0); i++) // i считывает в строчном напрвлении, используем новый функционал matrix.GetLength(0) (данная конструкция с использование 0 в скобках выводит данные матрицы в строчном направлении)
 {
    for (int j = 0; j < matr.GetLength(1); j++) // j считывает по-столбцам, используем новый функционал matrix.GetLength(0) (данная конструкция с использование 1 в скобках выводит данные матрицы по столбцам)
    {
        Console.Write($"{matr[i, j]} "); // пробел между фиг.скобой и закрывающими прямыми ковычками используем для выводу через пробел
    }
    Console.WriteLine(); // используем для вывода каждой следующей строки вывода с новой строки
 }

 }

 int[,] matrix = new int[3, 4];
 PrintArray(matrix); // вызываем метод аргументом которого вызывается матрица matrix */

/*  void PrintArray(int[,] matr) // Создаем метод
 {

 for (int i = 0; i < matr.GetLength(0); i++) // i считывает в строчном напрвлении, используем новый функционал matrix.GetLength(0) (данная конструкция с использование 0 в скобках выводит данные матрицы в строчном направлении)
 {
    for (int j = 0; j < matr.GetLength(1); j++) // j считывает по-столбцам, используем новый функционал matrix.GetLength(0) (данная конструкция с использование 1 в скобках выводит данные матрицы по столбцам)
    {
        Console.Write($"{matr[i, j]} "); // пробел между фиг.скобой и закрывающими прямыми ковычками используем для выводу через пробел
    }
    Console.WriteLine(); // используем для вывода каждой следующей строки вывода с новой строки
 }

 }
 void FillArray(int[,] matr) // создаем метод заполнения матрицы
 {
    for(int i = 0; i < matr.GetLength(0); i++) // i считывает в строчном напрвлении, используем новый функционал matrix.GetLength(0) (данная конструкция с использование 0 в скобках выводит данные матрицы в строчном направлении)
 {
    for(int j = 0; j < matr.GetLength(1); j++)  // j считывает по-столбцам, используем новый функционал matrix.GetLength(0) (данная конструкция с использование 1 в скобках выводит данные матрицы по столбцам)

 {
    matr[i,j] = new Random().Next(1,10); // обращаясь на каждом витке цикла последоваетельно к конкретному элементу заполляем таким образом матрицу с помощью генератора случайных чисел
 }
 }  
 }
 int[,] matrix = new int[3, 4];
 PrintArray(matrix); // вызываем метод вывода элементов  аргументом которого вызывается 
 // матрица (элементы которой пустые) matrix
 FillArray(matrix); // вызываем метод заполения элементов матрицы (данными генератора случайных 
 // чисел)  аргументом которого вызывается матрица matrix (элементы которой пустые) 
 Console.WriteLine(); // разделяем пустой строкой данные вывода не заполненной матрицы 
 // и данные дальнейшего вывод заполненной
 PrintArray(matrix); // вызываем метод вывода элементов  аргументом которого вызывается 
 // матрица matrix (элементы которой теперь заполнены)
 */


/* 

 int[,] pic = new int[,] // пояснение: необязательно указывать количество строчек и столбцов если есть уже данные, например:
 {  
       
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
{0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
{0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,},
{0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,},
{0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,},
{0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,},
{0,0,0,0,0,0,1,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
{0,0,0,1,1,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
{0,1,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
{0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
{0,1,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,},
{0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,},
{0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,},
{0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,},
{0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,},
{0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,},
{0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,},
{0,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,},
{0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,},
{0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
 };
void PrintImage(int[,] image)
{
    for (int i = 0;  i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            // Console.Write($"{image[i, j]} ");
            if(image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}
 void FillImage(int row, int col)
 {
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
 }
 Console.Clear();
 PrintImage(pic);
 FillImage(10, 7);
 PrintImage(pic);
 
  */

  double Factorial (int n)
  {
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
  }
  Console.WriteLine(Factorial(33));
