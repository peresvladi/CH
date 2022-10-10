
/* //ChTask10 Напишите программу, которая принимает на вход 3 значное число и на выходе показывает вторую цифру этого числа

Console.Clear();
Console.WriteLine("Введите трехзначное число:  ");
int num = int.Parse(Console.ReadLine());
if(num < 100 || num > 999)
{
    Console.WriteLine("Неверное число");
    return;
}
int y = num % 100;
int x = y / 10;
Console.WriteLine($"{num}{" -> "}{x}"); */



 /* //ChTask13 Напишите программу, которая выводит третью цифру заднного числа или сообщает, что третьей цифны нет.
Console.Clear();
Console.WriteLine("Введите число:  ");
int num = int.Parse(Console.ReadLine());
// int num = 100;
double num1 = num;
int div1 = 1;
double div3 = 0.1;

if(num <= 99)
{
    Console.WriteLine("третьей цифры нет");
    return;
    
}

while(num1 >= 100)
{
    num1 = num1/10;
    div1 = div1 * 10;
    div3 = div3 * 10;  
}
int div2 = 0;
div2 = (int)div3;
int y = num % div1;
int x = y / div2;
Console.WriteLine($"{num}{" -> "}{x}"); 
 */

/* 
//ChTask15 Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным
Console.Clear();
Console.WriteLine("Введите номер дня недели:  ");
int num = int.Parse(Console.ReadLine());
if(num < 1 || num > 7)
{
    Console.WriteLine("Неверное число");
    return;
}
if (num ==1) Console.WriteLine("пн. - не выходной день");
if (num ==2) Console.WriteLine("вт. - не выходной день");
if (num ==3) Console.WriteLine("ср. - не выходной день");
if (num ==4) Console.WriteLine("чт. - не выходной день");
if (num ==5) Console.WriteLine("пт. - не выходной день");
if (num ==6) Console.WriteLine("сб. - выходной день !");
if (num ==7) Console.WriteLine("вск. - выходной день !"); */