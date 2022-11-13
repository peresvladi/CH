

### A1)

```

using System;
using static System.Console;

Clear();
WriteLine("Введител N");
int N = 2;//int.Parse(ReadLine());
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
} 
```

### А2)
```
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
} 
```
### A3)
```
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

```
### A4) 
```
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

```

