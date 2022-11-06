

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

### 2А)
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

