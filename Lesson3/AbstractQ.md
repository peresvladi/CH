###/home/vladi/Видео/ПрогСШ/Ур3ПроСШ.mp4

### Методы (функции) Void и return

 

### 1)1-я группа методов:  свойства, формат, примеры

<details>
<summary></summary>

```javascript
```
### 1-я группа методов (void) - не принимает и не возвращает ни каких значений, например:
```
void Method1() // имя (интефикатор) М.
{
    Console.WriteLine("Автор ..."); // тело М. 
}

Method1(); // вызов М.
```  
### Еще раз пример вызова метода: 
```
Method1();

```
</details>





### 2)2-я группа методов:  свойства, формат, примеры  

<details>
<summary></summary>



### 2-я группа методов (void) - принимает аргументы но ничего не возращает например:      

```javascript

void Method2(String msg, int count) // имя (индефикатор) М. с   
                                    //аргументами: String msg, int count
    {int i = 0;                     // тело М.
        while (i < count)
        {Console.WriteLine(msg);
        i++;
        }
    }
Method2("Text", 4);                 // Вызов М.

```    
### Еще раз пример вызова метода:  

```
Method2("Текст сообщения", 4);
```
### Пример вызова c явым указание аргументов: 

```
void Method2.2 (msg:"Текст",  count: 4);
```

### Пример метода с использованием именованных аргументов: 

```
void Method2_1 (String msg) // имя (индефикоатор) аргумент(текстовый) М.
    {
        Console.WriteLine(msg); // тело М.
    }
Method2_1 (msg:"Текст сообщения"); // вызов М.
```  
### Еще раз пример вызова метода: 
```
Method2.1(msg: "Текст сообщения");
```

</details>


  

### 3)3-я группа методов:  свойства, формат, примеры

<details>
<summary></summary>



### 3-я группа методов (return) - могут возращать значения, но не принимают аргументы  

```javascript


int Method3()  // имя (индефикатор) М.
    {
    return DateTime.Now.Year;
    } // тело М.
        int year = Method3(); // Вызов М. c присвоением возвращаемого им значения переменной year
 Console.WriteLine(year); // Вывод на экран значения через переменную year

```
</details>




### 4)4-я группа методов:  свойства, формат, примеры  

<details>
<summary></summary>



### 4-я группа методов (return) - принимают аргументы и возращают значения для дальнейшей работы

```javascript


// Method4

 string Method4(int count, string text) // возвращаемый тип данных, имя переменной с аргументами: int count, string text
 {int i = 0;
 string result = String.Empty;
 while(i < count)
 {result = result + text;
 i++;
 } // тело переменной 
 return result; // возвращаемое методом значение
}
string res = Method4(10, "asdf"); // вызов метода с присваением ему значений 10, "asdf" и присвоением результата вычислений переменной res
Console.WriteLine(res); // вывод полученного значения на экран
```
</details>



 