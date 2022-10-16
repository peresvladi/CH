// ShTask 25. Напишите цикл который принимает на вход два цисла (А и В), 
// и возводит число А в натуральную степень В.

/* Console.Write ("Введите числовое значение переменной А: ");
int a = int.Parse(Console.ReadLine()); 
Console.Write ("Введите числовое значение переменной В: ");
int b = int.Parse(Console.ReadLine());
int c = a;
int i;
for (i = 0; i < b; i++)  
a=a*c;
Console.WriteLine($"Если А =  {c}, а  B = {b}, то A в степени В равно {a}");
 */
// ShTasr 27. Напишите программу которая принимает на вход число и 
// выдает сумму цифр в числе

// ShTask 29. Напишите программу которая задает массив из 8 элементов и 
// выводит их на экран

Console.WriteLine(string.Join(",", GetBinaryArray(8)));
int[] GetBinaryArray(int size)
{
    int[] result = new int [size];
    for(int i = 0; i < size; i++)
    {
        Console.Write ($"Введите числовое значение элемента массива с индексом {i} ");
        result[i] = int.Parse(Console.ReadLine());
    } 
    Console.Write ("Вы заполнили элементы массива следующими значениями: ");
    return result;
}





/* Console.Write ("Введите числовое значение элемента массива с индексом (1) ");
array[1] = int.Parse(Console.ReadLine());
Console.Write ("Введите числовое значение элемента массива с индексом (2) ");
array[2] = int.Parse(Console.ReadLine());
Console.Write ("Введите числовое значение элемента массива с индексом (3) ");
array[3] = int.Parse(Console.ReadLine());
Console.Write ("Введите числовое значение элемента массива с индексом (4) ");
array[4] = int.Parse(Console.ReadLine());
Console.Write ("Введите числовое значение элемента массива с индексом (5) ");
array[5] = int.Parse(Console.ReadLine());
Console.Write ("Введите числовое значение элемента массива с индексом (6) ");
array[6] = int.Parse(Console.ReadLine());
Console.Write ("Введите числовое значение элемента массива с индексом (7) ");
array[7] = int.Parse(Console.ReadLine()); */