﻿using System;
using static System.Console;

Clear();
void SelectContinueArrayCreating(string[]ArrayCreation)
{
    string [] BaseArray = {"a","d","c","d","i","f","g","h","i","j","k","l",
    "m","n","o","p","q","r","s","t","u","v","w","x","y","z","1","2","3","4"
    ,"5","6","7","8","9","10"};
     Print("Базовые элементы: ", BaseArray);
for (int i = 0; i < ArrayCreation.Length; ++i)
{
    string LiteralString = string.Empty;
    for (int j = new Random().Next(1, 5); j > 0; --j)
    {
        LiteralString = BaseArray[new Random().Next(0, 35)]  + LiteralString;      
    }
    ArrayCreation[i] = LiteralString;
    
}
Print("Базовый массив: ", ArrayCreation);
}
string ArraySelection (string[]Arr)
{
     string sum = string.Empty;
    for (int x = 0; x < Arr.Length; ++x)
    {   
       if (Arr[x].Length <= 3)
    {
        sum = sum + " " + Arr[x];
    }
        
    }
    return sum;
}
void Print (string msg, string[]PrintArray)
{
    WriteLine(msg + String.Join(" ", PrintArray));
}

WriteLine(" Инициированная программа автоматически формирует массив заполненый случайными текстовыми элементами (string) из которого создает массив заполненый текстовыми элементами длиной 3 и менее символов. Для  выхода введите минус (-), для продолжения выполнения программы введите плюс (+)");
string YesNo = "+";  //ReadLine();
SelectsStop(YesNo);
void SelectsStop(string Stop)
{
    if(Stop != "+")
    {
       WriteLine("Ввод любых символов за исключением знака +, ведет к выходу из программы. Выполнение программы завершено. "); 
    }
    else
    {
    String [] Array = new string [9];
    SelectContinueArrayCreating(Array);
    string s = ArraySelection(Array);
    String[]NewArray = s.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    Print("Полученный массив : ", NewArray);
    }
}

