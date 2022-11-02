using System;
using static System.Console;

Clear();
WriteLine("Введите десятичное число");
int tennum = int.Parse(ReadLine());
string box2 = string.Empty;
while(tennum >=1)   
{
string box1 = (tennum % 2).ToString("G");
box2 = box1 + " " + box2;
tennum = tennum / 2;
}
WriteLine(box2);
 
 











/* Console.Clear();
Console.WriteLine("Введите десятичное число");
int num = int.Parse(Console.ReadLine());
// int [] size =  new int [((long)num)];
int size = 
int I = 0;
while (num <= 1)
{
    int DoudlNum = num / 2;
    
   
   I++;


} */





/* // Вариант Моисеева К.

Console.Clear();
Console.WriteLine ("Введите стороны треугольника через пробел");
String[]cell = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

if (FalseTrue(int.Parse(cell[0]),int.Parse(cell[1]),int.Parse(cell[2])))
{
Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
bool FalseTrue(int a, int b, int c)
{
    return ((a + b) > c && (b + c) > a && (c + a) > b);
} */





/* Console.Clear();
int [] vol = new int [3];
RL(vol);
WL(vol);
void RL(int[]arr)
{
    for (int i = 0; i < 3; i++)
    {
     Console.WriteLine($"Введите {i + 1}-ое число");
     arr[i] = int.Parse(Console.ReadLine());
    }
}
void WL(int[]array)
{
    if (array[0] + array[1] > array[2] && array[1] + array[2] > array[0] && array[2] + array[0] > array[1])
{
Console.WriteLine($"Введенные числа: {array[0]},{array[1]},{array[2]}, могут образовать  треугольник");
} 
else
{
 Console.WriteLine($"Введенные числа: {array[0]},{array[1]},{array[2]}, не могут образовать  треугольник");   
}
}
 */




/* Console.Clear();
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
if (a + b > c && b + c > a && c + a > b)
{
Console.WriteLine("Введенные числа могут образоватьЫ  треугольник");
} 
else
{
 Console.WriteLine("Введенные числа не могут образоватm  треугольник");   
} */











/* 

// Какой-то кусок кода.
ReversArray1(array);
Console.WriteLine(String.Join("",array));


for (int i = 0; i < size; i++)
{Program.cs
    res[i] = new Random().Next(minValue, maxValue +1);
}z */





 // Коде перепечатан с кода Моисеева, не проверен, показывает ошибки надо разбираться
// Перевернуть массив
/* Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ",array));

int[]ReversArray2 = ReversArray(array);
Console.WriteLine(String.Join(" ",ReversArray));

ReversArray1(array);
Console.WriteLine(String.Join("", array));


int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
return res;
}

void ReversArray1(int[]inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
    int k = inArray[i];
    inArray[i] = [inArray.Length - i - 1] = k;
    }
 
} */
 
// ShTask39 Между правой и левой частью массива "Зеркально" поменять значения элементов массива

/* using System;
using static System.Console;

Clear();
void IntPutArr(int[]arr)
{
      for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,11);
    }
    WriteLine(String.Join(" ", arr));
} 

void TransformationArr(int[]ar)
{
    for(int i = 0; i < ar.Length/2; i++)
    { int temp = ar[i];
    ar[i] = ar[ar.Length - (i + 1)];
    ar[ar.Length - (i + 1)] = temp;
    }
    WriteLine(String.Join(" ", ar));
} 
int[]array = new int [11];
IntPutArr(array);
TransformationArr(array);

 */
// ShTask40_Напишите программу которая на входе принимает 3-числа и проверяет может ли с такими сторонами существовать треугольник.

 /* using System;
 using static System.Console;

 Clear();
 Write("Введите стороны треугольника через пробел");
 String [] Triangle = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); */
 //int [] Triangle = int.Parse(ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
// bool examination (int a = int.Parse(Triangle[0]), int b = int.Parse(Triangle[1]), int c = int.Parse(Triangle[2])
/* int a = int.Parse(Triangle[0]);
int b = int.Parse(Triangle[1]);
int c = int.Parse(Triangle[2]); */
/* bool examination (int a, int b, int c) */
/* void examination (int a, int b, int c)
{
if (a+b > c && b+c > a && c+a > b) Write ("Треугольник возможен");
else Write ("Треугольник не возможен");
} */

 
 // ShTask40_Напишите программу которая на входе принимает 3-числа и проверяет может ли с такими сторонами существовать треугольник.
 
 /* using System;
 using static System.Console;

 Clear();
 Write("Введите стороны треугольника через пробел: ");
 String [] Triangle = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
void examination (int a, int b, int c)
{
    if (a+b > c && b+c > a && c+a > b) Write (" Треугольник возможен ");
    else Write (" Треугольник не возможен ");
}
examination (int.Parse(Triangle[0]), int.Parse(Triangle[1]), int.Parse(Triangle[2])); */