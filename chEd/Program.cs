// chLesson3


// Алгоритм сортировки методом выбора
// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения с значением первой неотсортированной позицией
// 3. Повторять 1 и 2 пока есть несортированные элементы

            // НАЧАЛО
int []arr = {1,5,4,3,2,6,7,1,1}; //объявляем массив заполняя его неотсортироваанными элементами


            // ПОДЗАДАЧА которая будет выводить массив на экран

void PrintArray(int[]array)
{
    int count = array.Length; // получаем длину массива (количество элементов)
    for(int i = 0; i < count; i++) // создаем цикл которые работает пока переменная count больше обявленной в нем переменной i которой при объявлении присвоено нулевое значение и установлен инкримент (проходит циклом по элементам массива определяя их для дальнейшего вывода на экран)
    {
        Console.Write ($"{array[i]}"); // выводим на экран элементы цикла
    }    
        Console.WriteLine(); // выводим пустую строку
}
     
     void SelectionSort(int[] array) //Создаем метод который упорядочивает элементы массива. Аркгументом устанавливаем array (некий массив).

     {
        for(int i = 0; i < array.Length -1; i++) // с помомщью цикла считываем значения элементов массива
         
        {
            int minPosition = i; // определяем текущую позицию

           for(int j = i + 1; j < array.Length; j++) // ищем минимальный элемент           
            {
            if (array[j] < array [minPosition]) minPosition = j; // ищем и сохраняем минимальный элемент
            }
            int temporari = array[i]; // присваиваем значение i временной переменной temporary, что бы не утратить его при дальнейшем обмене значениями с элементом массива имеющем индекс minPosition
            array[i] = array[minPosition]; // изменяем на 1 индекс элемента i, уменьшая на 1 неотсортированную часть массива при дальнейшем исполнении кода (до завершения колличества всех элементов)
            array[minPosition] = temporari; // присваиваем элементу array[miпPosition] значение array[i],
                                            // т.е. происходит обмен значениями

          


        }
 
     }
        PrintArray(arr);
        SelectionSort(arr);
        PrintArray(arr);
    



/* // Method4

 string Method4(int count, string text)
 {int i = 0;
 string result = String.Empty;
 while(i < count)
 {result = result + text;
 i++;
 }
 return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);
 */






/* //Method3

int Method3()
{return DateTime.Now.Year;}
int year = Method3();
Console.WriteLine(year); */



/* // Method2(Void)
void Method2(String msg, int count)
{int i = 0;
while (i < count)
{Console.WriteLine(msg);
i++;
}
}
Method2("Text", 4); */


/* // Method1(Void)
void Method1()
{Console.WriteLine("Автор ...");}
Method1(); */