// Задача 69.__ Напишите программу которая на входе принимает два числа А и В, 
//и возводите число А в целую степень В (с помощью рекурсии).
using System;
using static System.Console;

WriteLine("Введител числа A");
double A = double.Parse(ReadLine());

WriteLine("Введител числа B");
double B = double.Parse(ReadLine());

WriteLine(RaisingAtoThePowerOfB (A, B));
double RaisingAtoThePowerOfB(double C, double D)
{
  if (D == 0)
{
  return (C);
}
  else
  {
    return (C)*RaisingAtoThePowerOfB(C, D-1);
  }
}














/* 
// Задача 67.__ Напишите программу которая будет принимать на вход число 
// и возращать сумму его цифр (при помощи рекурсии)

using System;
using static System.Console;
Clear();
WriteLine("Введите N ");
int N = int.Parse(ReadLine());

WriteLine (Copilka(N));
int Copilka(int x)
{
if (x == 0)
{
   return 0;
}
else
{
  
  return (x%10 + Copilka (x/10));
}
}  

 */

//__Задача 64.__ Задайте значения М и N. Напишите программу которая 
// выведет все значения от М до N.

/* 


using System;
using static System.Console;

Clear();
WriteLine("Введите N (минимальное значение)");
int N = int.Parse(ReadLine());
WriteLine("Введите M (максимальное значение)");
int M = int.Parse(ReadLine());
WriteLine (Copilka(N, M));

String Copilka(int x, int y)
{
if (x == y)
{
   return (x).ToString();
}
else
{
  return  x.ToString() + ", " + Copilka(x + 1, y);
}
}   */



// Задача 63.__  Задайте значение N напишите программу которая выведит все натуральные числа от 1 до N (При помощи рекурсии подробно в 
// примерах рассматривается синтаксис рекурсии в окончании решения задачи).

/* 

using System;
using static System.Console;

Clear();
WriteLine("Введител N");
int N = int.Parse(ReadLine());
WriteLine (Copilka(0, N));

String Copilka(int x, int y)
{
if (x == y)
{
   return (x).ToString();
}
else
{
  return  x.ToString() + Copilka(x + 1, y);
}
} */