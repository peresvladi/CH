using System;
using static System.Console;

Clear();
void SelectContinueArrayCreating(string[]ArrayCreation)
{
    string [] BaseArray = {"a","d","c","d","i","f","g","h","i","j","k","l",
    "m","n","o","p","q","r","s","t","u","v","w","x","y","z","1","2","3","4"
    ,"5","6","7","8","9","10"};
     Print("Базовые элементы: ", BaseArray);
for (int i = 0; i < ArrayCreation.Length; ++i)
{
    string LiteralString = string.Empty;
    for (int j = new Random().Next(1, 5); j > 0; --j)
    {
        LiteralString = LiteralString + BaseArray[new Random().Next(0, 35)];      
    }
    ArrayCreation[i] = LiteralString;
    
}
Print("Базовый массив: ", ArrayCreation);
}
string ArraySelection (string[]Arr)
{
     string sum = string.Empty;
    for (int x = 0; x < Arr.Length; ++x)
    {   
       if (Arr[x].Length <= 3)
    {
        sum = sum + " " + Arr[x];
    }
        
    }
    return sum;
}
void Print (string msg, string[]PrintArray)
{
    WriteLine(msg + String.Join(" ", PrintArray));
}

WriteLine(" Инициированная программа автоматически формирует массив заполненый случайными текстовыми элементами (string) из которого создает массив заполненый текстовыми элементами длиной 3 и менее символов. Для  выхода введите минус (-), для продолжения выполнения программы введите плюс (+)");
string YesNo = "+";  //ReadLine();
SelectsStop(YesNo);
void SelectsStop(string Stop)
{
    if(Stop != "+")
    {
       WriteLine("Ввод любых символов за исключением знака +, ведет к выходу из программы. Выполнение программы завершено. "); 
    }
    else
    {
    String [] Array = new string [9];
    SelectContinueArrayCreating(Array);
    string s = ArraySelection(Array);
    String[]NewArray = s.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    Print("Полученный массив : ", NewArray);
    }
}




/* using System;
using static System.Console;

void SelectContinueArrayCreating(string[]ArrayCreation)
{
for (int i = 0; i < ArrayCreation.Length; ++i)
{
    string LiteralString = string.Empty;
    string [] BaseArray = {"a","d","c","d","i","f","g","h","i","j","k","l",
    "m","n","o","p","q","r","s","t","u","v","w","x","y","z","1","2","3","4"
    ,"5","6","7","8","9","10"};
    for (int j = new Random().Next(1, 5); j > 0; --j)
    {
        LiteralString = LiteralString + BaseArray[new Random().Next(0, 35)];      
    }
    ArrayCreation[i] = LiteralString;
}
}
string ArraySelection (string[]Arr)
{
     string sum = string.Empty;
    for (int x = 0; x < Arr.Length; ++x)
    {   
       if (Arr[x].Length <= 3)
    {
        sum = sum + " " + Arr[x];
    }
        
    }
    return sum;
}
void Print (string msg, string[]PrintArray)
{
    WriteLine(String.Join(" ", PrintArray));
}

WriteLine(" Инициированная программа автоматически формирует массив заполненый случайными текстовыми элементами (string) из которого создает массив заполненый текстовыми элементами длиной 3 и менее символов. Для  выхода введите минус (-), для продолжения выполнения программы введите плюс (+)");
string YesNo = "+";  //ReadLine();
SelectsStop(YesNo);
void SelectsStop(string Stop)
{
    if(Stop != "+")
    {
       WriteLine("Ввод любых символов за исключением знака +, ведет к выходу из программы. Выполнение программы завершено. "); 
    }
    else
    {
    String [] Array = new string [9];
    SelectContinueArrayCreating(Array);
    string s = ArraySelection(Array);
    String[]NewArray = s.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    Print("РЕЗУЛЬТАТ: ", NewArray);
    }
}
 */



/* int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

int max = a1;
if (a1 > max)   max = a1;
if (a2 > max)   max = a2;
if (a3 > max)   max = a3;
if (b1 > max)   max = b1;
if (b2 > max)   max = b2;
if (b3 > max)   max = b3;
if (c1 > max)   max = c1;
if (c2 > max)   max = c2;
if (c3 > max)   max = c3;
Console.WriteLine(max); */

/* int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3);

Console.WriteLine(max); */





/* using System;
using static System.Console;
 


    class Program
    {
        public static int Depth = 0;
        public static UInt64 AckermannFunc(UInt64 m, UInt64 n) {
            Depth++;
            if (m == 0)
                return n + 1;
            if (n == 0)
                return AckermannFunc(m - 1, 1);
            return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
        }
 
        static void Main(string[] args) {
            WriteLine(AckermannFunc(3, 5));
            WriteLine(Depth);
        }
    } */


/* using System;

namespace ConsoleApp
{
    class Program
    {
        public static int Depth = 0;
        public static UInt64 AckermannFunc(UInt64 m, UInt64 n)
        {
            Depth++;
            if (m == 0)
                return n + 1;
            if (n == 0)
                return AckermannFunc(m - 1, 1);
            return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AckermannFunc(3, 5));
            Console.WriteLine(Depth);
        }
    }
} */


/* Console.WriteLine("Введите M:");
int numM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N:");
int namN = int.Parse(Console.ReadLine());

///Метод вычисления функции Аккермана:
int AckermannFunction (int numM, int namN)
{
    if (numM == 0) return namN + 1;
    if (numM != 0 && namN == 0) return AckermannFunction(numM - 1, 1);
    if (numM > 0 && namN > 0) return AckermannFunction(numM - 1, AckermannFunction(numM, namN - 1));
return AckermannFunction(numM, namN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numM},{namN}) = {AckermannFunction(numM, namN)}");

 */

/* Console.WriteLine("Введите начальное число M:");
double numM = 3;//double.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
double namN = 5;//double.Parse(Console.ReadLine());

///Метод вычисления функции Аккермана:
double AckermannFunction (double numM, double namN)
{
            if (numM == 0) return numM + 1;
            if (namN == 0) return AckermannFunction(numM - 1, 1);
            return AckermannFunction(numM - 1, AckermannFunction(numM, numM - 1));

   // if (numM == 0) return namN + 1;
     //if (numM != 0 && namN == 0) return AckermannFunction(numM - 1, 1);
    // if (numM > 0 && namN > 0) return AckermannFunction(numM - 1, AckermannFunction(numM, namN - 1));
 //return AckermannFunction(numM, namN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numM},{namN}) = {AckermannFunction(numM, namN)}");
 */


// РАБОЧИЙ КОД


// Заполняеь массив случайными числами 3-х значными через 
// new Random().Next(100, 1000) фильmтруя для заполнения 
// только четные из них (еще не протестировано до конца )
/* Console.Clear();
void IntPutF (int[]arr, int i)
{
    int temp = 0;
    int index = 0;
    while(index < i)
    {temp = new Random().Next(100, 1000);
         if (temp%2 == 0)
        {
            arr[index] = temp;
            index++;
        }

    }
}

int[]array = new int [11];
IntPutF(array,array.Length);
 */
 
 // ShTask34 Задайте массив заполненный случайными 3-х значными положительными числами. Напишите программу которая покажет колличество четных чисев в массиве

/* void IntPut (int[]arr, int i)
{

for (int index = 0; index < i; index++)
{
 arr[index]  = new Random().Next(100, 1000); 
}

}
void OutPutCount (int[]arr, int i)
{
        int count = 0;
    for (int index = 0; index < i; index++)
    {
        if (arr[index]%2 == 0)
        {
            count++;
        }   
    }
    Console.WriteLine($"Колличество четных чисел в массиве составляет - {count}");
}

int[]array = new int [11];
IntPut(array,array.Length);
OutPutCount(array,array.Length);
 */


// Принимает цифры через пробел, выводит колличество введенных цифр имеющих значение больше "0"

/* using System;
using ctatic System, Console; */




/* Console.Clear();

Console.Write(" Введите числа через пробел ");
int[]numbers = GAFS(Console.ReadLine());
Console.WriteLine($"Колличество чисел больше 0 ->{GCPE(numbers)}");
Console.WriteLine();


int[]GAFS(string stringArray)
{
    string[] numS = stringArray.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    // string[] numS = stringArray.Split("  ", StringSplitOptions.RemoveEmptyEntries);
    int[]result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
  }

int GCPE(int[] array)
{
    int count = 0;
    foreach (var item in array)
{
    if(item>0) count++;
}
return count;
}
 */

 // ChTask45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/* using System;
using static System.Console;

Clear();

int[] array = GA(10, 0, 10);
WriteLine(String.Join(" ", array));

int [] copyArray = CopyArray(array);
WriteLine(String.Join(" ", copyArray));


int[]GA(int size, int minValue, int maxValue)
{
  int[] res = new int[size];

  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

int[] CopyArray(int[]inArray)
{
  int[]result = new int[inArray.Length];
  for (int i = 0; i < inArray.Length; i++)
{
  result[i] = inArray[i];

}
return result;
} */

//ShTask 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 



/* using System;
using static System.Console;

Clear();
Write("Введите через пробел b1, k1, b2, k2: ");
string[]f = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(f[0]);
double k1 = double.Parse(f[1]);
double b2 = double.Parse(f[2]);
double k2 = double.Parse(f[3]);

WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));




double[] GetPoint(double inB1, double ink1, double inB2, double ink2)
{
  double[] result = new double[2];
  result[1] = (inB2 - inB1) / (ink1 - ink2);
  result[1] = ink1 * result[0] + inB1;
return result;
}
 */


// ChTask41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3


/* 


Console.Clear();

Console.Write(" Введите числа через пробел ");
int[]numbers = GAFS(Console.ReadLine());
Console.WriteLine($"Колличество чисел больше 0 ->{GCPE(numbers)}");
Console.WriteLine();


int[]GAFS(string stringArray)
{
    string[] numS = stringArray.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    // string[] numS = stringArray.Split("  ", StringSplitOptions.RemoveEmptyEntries);
    int[]result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
  }

int GCPE(int[] array)
{
    int count = 0;
    foreach (var item in array)
{
    if(item>0) count++;
}
return count;
}


 */

 
// ChTask52 Задайте 2-х мерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

/* using System;
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





// ChTask47 Задайте 2-х мерный массив размером mхn, заполненный случайными вещественными числами


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

// static void Main(string[] args) (опубликован в данной функции, но вызвать фнукцию не получилось т.к. времени не хватило, поэтому код разделен и часть без функции в принципе работает, но из выполненения выходит через Ctrl + C)



/*         




{
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
 
        } 



 */

 //Task64



/* using System;
using static System.Console;

Clear();
Write ("Введите N: ");
int N = 2;//int.Parse(ReadLine());
Write ("Введите M: ");
int M = 9;//int.Parse(ReadLine());

WriteLine(PN(N,M));

string PN (int start, int finish)
{
    if (start == finish) return start.ToString();
    return (start + " " + PN(start + 1, finish));
} 
 */


// Task66
/* 
using System;
using static System.Console;

Clear();
Write ("Введите N: ");
int N = int.Parse(ReadLine());
Write ("Введите M: ");
int M = int.Parse(ReadLine());

WriteLine(SUM(N,M));

int SUM (int start, int finish)
{
    if (start == finish) return start;
    return (start + SUM(start + 1, finish));
}
 */


// Task68



/* 
using System;
using static System.Console;

Write("Введите число M: ");
double m = double.Parse(ReadLine());

Write("Введите число N: ");
double n = double.Parse(ReadLine()); 

AkkermanFunction(m,n);


// вызов функции Аккермана
void AkkermanFunction(double m, double n)
{
    Write(AkkermanFunct(m, n)); 
}

// функция Аккермана
double AkkermanFunct(double m, double n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunct(m - 1, 1);
    }
    else
    {
        return (AkkermanFunct(m - 1, AkkermanFunct(m, n - 1)));
    }
} 
 */

 
/* 
Console.WriteLine("Введите M:");
double numM = double.Parse(Console.ReadLine());

Console.WriteLine("Введите N:");
double namN = double.Parse(Console.ReadLine());


double AckermFunct (double numM, double namN)
{
    if (numM == 0) return namN + 1;
    if (numM != 0 && namN == 0) return AckermFunct(numM - 1, 1);
    if (numM > 0 && namN > 0) return AckermFunct(numM - 1, AckermFunct(numM, namN - 1));
return AckermFunct(numM, namN);
}

Console.WriteLine($"Результат: ({numM},{namN}) = {AckermFunct(numM, namN)}"); */