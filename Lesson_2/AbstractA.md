#### Функции (методы), массивы (/home/vladi/Видео/ПрогСШ/Ур2ПрогСШ.mkv; 415,5 MiB (435684647 B);  )
A1) Методы

A2) Индефикатор (имя) и может иметь аргументы (входные и технические) и возвращать значение

A3) ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ... ])

{
    
    Тело Метода
    return ЗначениеСоответствующие ВозвращаемомуТипуДанных;
}

A4) return - обозначает данные которые будуь возвращаться функцией.

А5) ТИП ДАННЫХ [] ИМЯ = {значение1,значение2,...}

A6) 

int[]array = {1,2,4,...}

int[]array = new int[5];

int[]array = new int[] {0,0,0,0,0}

int[]array = new int[5] {0,0,0,0,0}

A7) два формата:
    
    int array[0] = 12;


    int index = 0;

    n = 12;
    
    array[index] = n;

A8) Console.WriteLine(array[0]);

A9) 

    int result = array[0];

    Console.WriteLine(result);

A10) int n = array.Length;

A11) break;


A12)

```
 void FillArray(int[]collection) // объявляем метод(м.) void FillArray с аргументом int [] collection в виде массива (м.)
{
    int length = collection.Length; // получаем количество элемементов (э.) м.
    int index = 0; // выбираем позицию проверяемого э.
     while(index < length) // ц. исполняется пока index < length
     {
        collection[index] = new Random().Next(1, 10);
        index++; 
     }
}
void PrintArray(int[]col) // метод распечатывает массив
{
    int count = col.Length;
    int position = -1; // -1 будет возвращаться, если индрекс в массиве отсутствует
    while(position < count)
    {
        Console.WriteLine(col[position]); // выводим значение текущего элемента
        position++;
    }
}

int IndixOF (int[]Collection, int find)
{
    int count = Collection.Length;
    int index = 0;
    int position = 0;
    while(index < count)
    {
        if(Collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;

}
int[] array = new int[10]; // создаем новый массив из 10 элементов (по умолчанию такой массив наполнен элементами со значение "0")
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndixOF(array, 4);
Console.WriteLine(pos);
```