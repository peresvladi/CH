// ChTask4 Напишите программу которая выводит массив из 8 
// элементов, заполненных нулями и единицами в случайном порядке.

Console.WriteLine(string.Join(",", GetBinaryArray(8)));

int[] GetBinaryArray(int size)
{
    int[] result = new int [size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}

/* 
Заготовка

int [] array = new int [8];

void demo(Array)
int ind = 0;
for (int i = array.Length; i > 0; --i)
{
array[ind] = new Random().Next(0,2);
ind+=ind;
} */

/* //ChTask3 Напишите задачу которая принимаеь на вход число N 
// и выдает произведение от 1 до N.
Console.Write ("Введите число: ");
double limit = double.Parse(Console.ReadLine());

Console.WriteLine($"Произведение чисел от 0 до {limit} составляет {Mul(limit)} ");

double Mul(double limit)
{
double m =1;
for (double i = 1; limit >= i; ++i)
{
    m*=i;
}
return m;
} */


// ChTask2 Напишите программу которая принимает на вход число и выдает количество цифр в числе.

//v3 (через for) в целом работает за исключением случаев
// введения нулей первыми числами

/* Console.Write ("Введите число: ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {limit} содержит {InSum(limit)} цифр");

int InSum(int limit)
{
    int i;
    for (i = 0; limit > 0; ++i)
{
    limit = limit/10;
}
return i;
}
 
 */


/* 
//v2 в целом работает за исключением случев введения десятичных дробей 
// (необходимо установить проверки на ввод ",", или некорректных симоволов)
Console.Write("Введите число: ");
String limit = Console.ReadLine();
Console.WriteLine($"Число {limit} содержит {InStrSum(limit)} цифр");

int InStrSum(String limit)
{
  return limit.Length;
} 
 */

//v1 в целом работает за исключением случаев
// введения нулей первыми числами

/* Console.Write ("Введите число: ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {limit} содержит {InSum(limit)} цифр");

int InSum(int limit)
{
    int i = 1;
    int n = 0;
    while ( i <= limit)
{
    limit = limit/10;
    ++n;
}
limit = n;
return limit;
}
 */


/* 
//ChTask1 Напишите программу, которая принимает на вход число (A) 
// и выдает сумму чисел от 1 до A.
Console.Write ("Введите числа: ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {limit} равна {GetSum (limit)}");

int GetSum (int limit)
{
int sum = 0;
for (int i = 1; i <= limit; i++)
sum += i;
return sum;
} */

/* 
//ChTask19 Напишите программу, которая на вход принимает пятизначное число и проверяет, является ли это число палиндромом;
Console.Clear();
Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());
int a1 = num / 10000;
num-= a1 * 10000;
int a2 = num / 1000;
num-=a2 * 1000;
int a3 = num / 100;
num-=a3 * 100;
int a4 = num / 10;
int a5 = num % 10;
if (a1 == a5 && a2 == a4)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
} */ 



/* //ChTask21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояник между ними в 3D пространстве;
Console.Clear();
Console.Write("Введите х1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите Z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите Х2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите Z2: ");
int z2 = int.Parse(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"d = {d:f3}"); */


/* 
//ChTask23 Напишите программу, которая принимает на вход числа (N) и выдает таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите числа N:  ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
   // Console.Write($"{Math.Pow(i, 3)}");
      Console.Write($"{i*i*i} ");
   } */
