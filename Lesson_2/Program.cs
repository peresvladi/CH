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
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]); // выводим значение текущего элемента
        position++;
    }
}
int[] array = new int[10]; // создаем новый массив из 10 элементов (по умолчанию такой массив наполнен элементами со значение "0")
FillArray(array);
PrintArray(array);