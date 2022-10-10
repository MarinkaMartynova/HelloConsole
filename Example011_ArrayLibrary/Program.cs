void FillArray (int[] collection)   //метод, который ничего не возвращает. это войд и в коде не используем поэтому оператор return
{
    int length = collection.Length;   //получим длину массива
    int index = 0;                   //Возьмем позицию индекс , которая будет начинаться с нуля
    while (index < length)            //пока индекс < длины то
    {
        collection[index] = new Random().Next(1, 10);   //обратится к аргументу коллекция и положить туда целое число от 1 до 10
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;         //искусственный элемент когда значения не существует
                               //( потому что по умолчанию пр инеправильном элементе выдает 0)
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10];    //новая конструкция: создай новый массив в котором будет 10 элементов (дословно)
                                 //по умолчанию заполнен нулями
FillArray(array);                 //заполнили массив набором чисел
array[4] = 4;
array[6] = 4;
PrintArray(array);                //и распечатали набор чисел
Console.WriteLine();

int pos = IndexOf(array, 44);      //если введем позицию которой не существует? тогда int position = -1; 
                                   //(придумка программистов) говорит о том что элемент не найден
Console.WriteLine(pos);