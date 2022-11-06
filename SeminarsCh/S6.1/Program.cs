// ChTask45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/* 


Console.Clear();

int[] storage = GA(9, 0, 9);
Console.WriteLine(String.Join(" ", storage));

int [] copystorage = Copystorage(storage);
Console.WriteLine(String.Join(" ", copystorage));


int[]GA(int size, int minValue, int maxValue)
{
  int[] res = new int[size];

  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

int[] Copystorage(int[]instorage)
{
  int[]result = new int[instorage.Length];
  for (int i = 0; i < instorage.Length; i++)
{
  result[i] = instorage[i];

}
return result;
}



 */

//ShTask 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.



/* 


Console.Clear();
Console.Write("Введите через пробел значения b1, k1, b2, k2: ");
string[]f = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(f[0]);
double k1 = double.Parse(f[1]);
double b2 = double.Parse(f[2]);
double k2 = double.Parse(f[3]);

Console.WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));




double[] GetPoint(double inB1, double ink1, double inB2, double ink2)
{
  double[] result = new double[2];
  result[1] = (inB2 - inB1) / (ink1 - ink2);
  result[1] = ink1 * result[0] + inB1;
return result;
}



 */

// ChTask41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользонаватель.



/* 


Console.Clear();

Console.Write(" Введите числа через пробел ");
int[]numbers = GAFS(Console.ReadLine());
Console.WriteLine($"Колличество чисел больше 0 ->{GCPE(numbers)}");
Console.WriteLine();


int[]GAFS(string stringstorage)
{
    string[] numS = stringstorage.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    // string[] numS = stringstorage.Split("  ", StringSplitOptions.RemoveEmptyEntries);
    int[]result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
  }

int GCPE(int[] storage)
{
    int count = 0;
    foreach (var item in storage)
{
    if(item>0) count++;
}
return count;
}


 */