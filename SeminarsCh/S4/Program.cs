// ShTask 25. Напишите цикл который принимает на вход два цисла (А и В), и возводит число А в натуральную степень В.

/* 
Console.Write ("Введите числовое значение переменной А: ");
int a = int.Parse(Console.ReadLine()); 
Console.Write ("Введите числовое значение переменной В: ");
int b = int.Parse(Console.ReadLine());
int c = a;
int i;
for (i = 0; i < b; i++)  
a=a*c;
Console.WriteLine($"Если А =  {c}, а  B = {b}, то A в степени В равно {a}");
 */


// ShTask 27. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе 

/* Console.Write ("Введите число: ");
int count = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр введенного числа {count} равна: {InSum(count)}");

int InSum(int count)
{
    int i = 1;
    int n = 0;
    int Sum = 0;
    while ( i <= count)
{ 
    int Part = count%10;
    count = count/10;
    Sum = Sum + Part;
    ++n;
}
count = Sum;
return count;
} */



// ShTask 29. Напишите программу которая задает массив из 8 элементов и  выводит их на экран

/* Console.WriteLine(string.Join(",", InpOutpArr(8)));
int[] InpOutpArr(int size)
{
    int[] result = new int [size];
    for(int i = 0; i < size; i++)
    {
        Console.Write ($"Введите числовое значение элемента массива с индексом {i} ");
        result[i] = int.Parse(Console.ReadLine());
    } 
    Console.Write ("Вы заполнили элементы массива следующими значениями: ");
    return result;
} */