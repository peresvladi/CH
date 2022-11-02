


### Q1)
```
String.Join(" ", arr)

```


### Q2)
```

using System;
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


```
### Q3)
```
using System;
 using static System.Console;

 Clear();
 Write("Введите стороны треугольника через пробел: ");
 String [] Triangle = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
void examination (int a, int b, int c)
{
    if (a+b > c && b+c > a && c+a > b) Write (" Треугольник возможен ");
    else Write (" Треугольник не возможен ");
}
examination (int.Parse(Triangle[0]), int.Parse(Triangle[1]), int.Parse(Triangle[2]));
```