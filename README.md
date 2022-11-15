## Итоговая проверочная работа

### Данная работа необходима для проверки знаний и навыков по игогу прождения первого блока обучения по программе разработчик.

### __Задание:__
1. Создать репозиторий на GitHub
2. Наристовать блок-схему алгоритма
3. Снабдить репозиторий оформленным текстовым описание решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом

### __Задача:__
#### Написать программу, которая из имеющегоя массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

### __Общее описание решения__
### Создаем:
### I.
1. Функцию _(WriteLine)_ которая после запуска программы выводит информацию о порядке выполения программы и возможных  действиях в консоли которые позволяют либо прекратить выполнение (предлагает ввести минус (-)), либо продолжить (предлагает ввести плюс(+)), после ввода вызывает _SelectsStop._ 
2. Функцию _void SelectsStop(string Stop)_ с аргументом _string Stop_ приминимает информацию о выборе действий в консоли (продолжения программы (+), или завершении (любой другой симовол))
    * В теле функции используем оператор _if_ который если Stop не равно плюс (+)
    выводит сообщение о прекращении выполнения программы и игнорирует оставшийся код (после else), завершая таким образом работу, а в случае если Stop равно плюс (+) передает выполнения программы кодам вызова функции после else.

### II.
### Далее:
1. Массив  _Array_ с определенным кооличеством пустых элементов String, который передается в качестве аргумента в функцию _SelectContinueArrayCreating_
    - В теле функции _SelectContinueArrayCreating_:
        * массив _BaseArray_ содержащий 36 элементов String заполенный  стандартными текстовыми символами алфавита и цифр.
        * Цикл _for_ в качестве аргумента принимающий длину массива(число элементов) _Array_ и повторяет свои действия пока счетчик _i_ не сравняется с числом его  элементов.
            * В теле цикла объявлена текстовая переменная _LiteralString_ которой присвоего значение _string.Empty_
            * Внутренний цикл _for_ цикла _for_(подцикл) в котором аргументу счетчика j присваевается случайное значение функции _Random_ и цикл работает пока значение при отрицательном инкрименте -1, больше значения 0.
                * В теле данного подцикла _for_ переменной _LiteralString_  присваевается значения случайно выбранных с помощью функции _Random_ элементов массива _BaseArray_ в количестве повторений цикла, равному случайному значению присвоеного счетчику _j_
            * при выходе из подцикла _for_ значение переменной _LiteralString_ присваивается текущему элементу массива _ArrayCreation_ индекс которого определяется текущим значением считчика _i_
            #### Таким образом _ArrayCreation_ заполняется случайно сформированными строками и возвращает себя вызванной строке кода
2. Массив  _Array_ с определенным кооличеством элементов String,  передается в качестве аргумента в функцию _ArraySelection_
    - В теле функции _ArraySelection_:
        * объявляется текстовая переменная _sum_ которой присваивается значение _string.Empty_ 
        * открывается цикл _for_ в качестве аргумента принимающий длину массива(число элементов) _Array_ и повторяет свои действия пока счетчик _x_ не сравняется с числом его  элементов. 
            *  в теле цикла _for_ открыватся функция с оператором _if_ которая исполняет в своем теле присваивание (сложение) переменной _sum_  значений всех элементов переданного в качестве аргумента функции массива _Array_(сформированного функцией ) содержащих строки в колличестве равном 3 и менее. Данные строки складыаются в переменной _sum_ с разделителем в виде пустой строки (пробела). 
        *  в качестве возвращаемого значения (return) по завершению функции используется значение переменной _sum_ и это значение возвращаемое функцией присваиваеься внешней переменной _s_ 
3. Значение переменной _s_ c помощью метода _Split_ присваивается массиву NewArray

4. Для наглядного отображения работы программы функция _Print_, которая в качестве аргументов принимает текстовое сообщение и знанчение массива (с использование метода _Join_), в своем теле складывает значение этих аргументов и выводит в консоль. Функция 
_Print_ используется для отображений полученных значений "Списка базовых элементов", "Базового массива", и полученного массива.
