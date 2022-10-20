// ShTask34 Задайте массив заполненный случайными 3-х значными положительными числами. Напишите программу которая покажет колличество четных чисев в массиве

/* 


void IntPut (int[]arr, int i)
{

for (int index = 0; index < i; index++)
{
 arr[index]  = new Random().Next(100, 1000); 
}

}
void OutPutMax (int[]arr, int i)
{
        int Max = 0;
    for (int index = 0; index < i; index++)
    {
        if (arr[index]%2 == 0)
        {
            Max++;
        }   
    }
    Console.WriteLine($"Колличество четных чисел в массиве составляет - {Max}");
}

int[]array = new int [11];
IntPut(array,array.Length);
OutPutMax(array,array.Length);


 */





// ShTask36 Задайте одномерный массив заполненный заполненный случайными 
// числами. Найдите сумму элементов стоящих на нечетных позициях.

/* 


void IntPut (int[]arr, int i)
{

for (int index = 0; index < i; index++)
{
 arr[index]  = new Random().Next(10, 100);
}

}
void OutPutMax (int[]arr, int i)
{
        int Max = 0;
    for (int index = 0; index < i; index++)
    {
        if (index%2 > 0)
        {
            Max = Max + arr[index];
        }   
    }
    Console.WriteLine($"Сумма элементов массива стоящих на нечетных позициях составляет - {Max}");
}

int[]array = new int [9];
IntPut(array,array.Length);
OutPutMax(array,array.Length); 


*/






// ShTask38 Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементом массива. 

/* 


void IntPut (int[]arr, int i)
{

for (int index = 0; index < i; index++)
{
 arr[index]  = new Random().Next(10, 100);
}

}

int OutMax (int[]arr, int i)
{
        int Max = arr[0];
        
    for (int index = 1; index < i; index++)
    {
        if (arr[index] > Max)
        {
            Max = arr[index];
        } 
    }  
  return Max;
}
  
  int OutMin (int[]arr, int i)
{
        int Min = arr[0];
        
    for (int index = 1; index < i; index++)
    {
        if (arr[index] < Min)
        {
            Min = arr[index];
        }       
        
    }
    
return Min;
    
}

int OutMaxMin (int Maxim, int Minim)
{
    int result;
    return result = Maxim - Minim;
}

void Print (String msg,  int res)
{
        
        Console.Write(msg);
        Console.Write(res);
        Console.WriteLine(); 

}

int[]array = new int [9];
IntPut(array,array.Length);
int ghjs = OutMaxMin(OutMax(array,array.Length), OutMin(array,array.Length)); 
Print("Разница между максимальным и минимальным элементами массива равна  ", ghjs);


 */