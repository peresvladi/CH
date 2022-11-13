### Q Тема: Массивы и функции (/home/vladi/Видео/ПрогСШ/Ур2ПрогСШ.mkv; 415,5 MiB (435684647 B);)



### ) Как функции называются в C# 

<details>
<summary></summary>

```javascript
Методы
```
</details>


### 2) Что имеет и может иметь функция (метод)

<details>
<summary></summary>

```javascript
Индефикатор (имя) и может иметь аргументы (входные и технические) и возвращать значение
```
</details>

### 3) Описание функции ...

<details>
<summary></summary>

```javascript

ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ... ])

{
    
    Тело Метода
    return ЗначениеСоответствующие ВозвращаемомуТипуДанных;
}
```
</details>


### 4) что обозначает в функции (ф.) return

<details>
<summary></summary>

```javascript
return - обозначает данные которые будуь возвращаться функцией.
```
</details>


### 5) синтаксис массива

<details>
<summary></summary>

```javascript
ТИП ДАННЫХ [] ИМЯ = {значение1,значение2,...}
```
</details>

### 6) пример объявления массивов в разных форматах.


<details>
<summary></summary>

```javascript

int[]array = {1,2,4,...}

int[]array = new int[5];

int[]array = new int[] {0,0,0,0,0}

int[]array = new int[5] {0,0,0,0,0}
```
</details>


### 7) формат присвоения элементу массива значения

<details>
<summary></summary>

```javascript
два формата:
    
    int array[0] = 12;


    int index = 0;

    n = 12;
    
    array[index] = n;
```
</details>


### 8) вывод на экран значения элемента массива

<details>
<summary></summary>

```javascript
Console.WriteLine(array[0]);
```
</details>


### 9) вывод на экран значения элемента массива с использованием переменной

<details>
<summary></summary>

```javascript
int result = array[0];

    Console.WriteLine(result);

```
</details>


### 10) получить колличество элементов массива

<details>
<summary></summary>

```javascript
int n = array.Length;
```
</details>


### 11) прервать выполнения кода

<details>
<summary></summary>

```javascript
 break;
```
</details>


### 12) code:
* объявить метод, передать ему массив, заполнить массив нужным колличеством элементов
* описание метода который выводит все элементы по порядку
* описание метода поиска индекса


<details>
<summary></summary>

```javascript
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
</details>
