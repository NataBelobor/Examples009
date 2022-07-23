//Задача 29: Напишите программу, которая задаёт массив из 8 
//элементов и выводит их на экран.

void FillArray (int [] collection)
{
    int Lenght = collection.Length;
    int index = 0;
    while (index < Lenght)
    {
        collection [index] = new Random ().Next ();
        index = index ++;
    }
}

void PrintArray (int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine (col[position]);
        position++;
    }
}

int [] array = new int [8];

FillArray (array);
PrintArray (array);