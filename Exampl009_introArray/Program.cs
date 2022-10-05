void FILLArray(int[] collection) // работает общая задача: описание метода для заполнения массива
{
int length = collection.Length; // получаем длинну массива
int index = 0; // присваеваем переменной тип и значение (выставляем позицию)
while (index < length) // цикл пока длина массива больше значения index, будет исполняться
{
    collection[index] = new Random().Next(1, 10); // присваиваем случайное число массиву
    
    index++; // index = index + 1; (аналогично)
    }
}

void PrintArray(int[] col) // печатает массив
{

int count = col.Length; // колличество элементов
int position = 0; // обозначаем текущую позицию
while (position < count) // пока позицию меньше чем значаение count цикл будет исполняться
{
    Console.WriteLine(col[position]); // выводим значение позиции текущего элемента
    position++; 
}
}
int indexOF(int[] collection, int find) // создаем метод который будет возвращать позицию, который приминимает в качестве аргументов массив collecktion и элемент find
{
    int count = collection.Length; // опеределяем количество элементов count
    int index = 0; // объявляем переменную и присваиваим значение 0
    int position = -1; // объявляем переменную и присваиваим значение -1 (используется не ноль а -1, т.к. в случае отсутствия в массиве нужного числа по результатам работы проги выводится это значение) 
    while (index < count) // цикл работатает пока index меньше чем count
{
    if(collection[index] == find) // если index = find в переменную position сохраняется позиция индекса
    {
        position = index; // сохраняем значение при совпадении условия в if
        break; // добавляем, что бы на экран выводились данные именно первой позиции
    }
    index++;
}
return position; // ожидаем позицию элемента массива
}
int[] array = new int[10];
// Далее тестируем написанный код
FILLArray(array); // созданному методу FILLArray передаем наименование массива
PrintArray(array); // распечатывает массив
Console.WriteLine(); // выводим пустую строку для тестирования


int pos = indexOF(array, 4); // опеределяем переменную pos и сохраняем в нее результат работы метода indexOF(), аргументами кторого определим массив и число которое в нем будет искаться
Console.WriteLine(pos); // выводим результат (найденный индекс значения 4 в массиве)






// работает - находит индекс числа в массиве заданного для поиска в переменной find числа 
/* int[] array = {1,12,31,4,15,61,17,18,19};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {  
        Console.WriteLine(index);
        break;
    }
    // index = index + 1; (аналогично нижней следующей строке)
       index++;
} */



// не работает т.к. Max за функцию не признает
/* int[] array = {11,21,31,41,15,61,17,18,19};
Console.WriteLine(array[4]);
int max = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8]));

    Console.WriteLine(max); */

