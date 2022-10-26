/* Console.Clear();
Console.WriteLine("Введите десятичное число");
double num = double.Parse(Console.ReadLine());
// double [] size =  new double [((long)num)];
double size = 
int I = 0;
while (num <= 1)
{
    double DoudlNum = num / 2;
    
   
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








/* // Коде перепечатан с кода Моисеева, не проверен, показывает ошибки надо разбираться
// Перевернуть массив
Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ",array));

int[]reversArray = ReversArray2 (array);
Console.WriteLine(String.Join(" ",reversArray));

ReversArray1(array);
Console.WriteLine(String.Join("", array));


int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res - new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Pandom(),Next(minValue, maxValue + 1);
    }
return res;
}

void ReversArray1(int[]inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {

int k = igArray[i];
inArray[i] = [inArray.Length - i - 1] = k;
}

   
}
 */



/* 

// Какой-то кусок кода.
ReversArray1(array);
Console.WriteLine(String.Join("",array));


for (int i = 0; i < size; i++)
{Program.cs
    res[i] = new Random().Next(minValue, maxValue +1);
}z */