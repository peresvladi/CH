/* // ChTask8

int a = 101;
int index = 0;
int count = a;

while (index < count) 
{
   if(a % 2 == 0)
{
Console.Write(a);
Console.WriteLine(" (число является четным) ");
}
    a = a - 1;
    index++;
    }  */





/* // ChTask6

int[] numders = { 2, 3, 7 };

int index = 0;
int count = 3;

 while (index < count) 
{
if(numders[index] % 2 == 0)
{
Console.Write(numders[index]);
Console.WriteLine(" (число является четным) ");
}
if(numders[index] % 2 > 0)
{
Console.Write(numders[index]);
Console.WriteLine(" (число не является четным) ");
}
index++;
} */
    




/* // ChTask4

// part1
int[] a = { 2, 3, 7 };

int maxA = a[0];

if (a[1] > maxA) maxA = a[1];
if (a[2] > maxA) maxA = a[2];

Console.Write("part1 max = ");
Console.WriteLine(maxA);

// part2
int[] b = { 44, 5, 78 };

int maxB = b[0];

if (b[1] > maxB) maxB = b[1];
if (b[2] > maxB) maxB = b[2];

Console.Write("part2 max = ");
Console.WriteLine(maxB);


// part3
int[] c = { 22, 3, 9 };

int maxC = c[0];

if (c[1] > maxC) maxC = c[1];
if (c[2] > maxC) maxC = c[2];

Console.Write("part3 max = ");
Console.WriteLine(maxC);
 */






/* // ChTask2
int[] a = {5, 2, -9};
int[] b = {7, 10, -3};

int index = 0;
int count = 3;


 while (index < count) 
{
    if(a[index] < b[index])
    {
        Console.Write(a[index]);
        Console.Write(" < ");
        Console.Write(b[index]);
        Console.WriteLine(" (результат сравнения) ");
    }
    if(a[index] > b[index])
    {
        Console.WriteLine(" (результат сравнения) ");
        Console.Write(a[index]);
        Console.Write(" > ");
        Console.Write(b[index]);
    }

    index++;
} 

*/

