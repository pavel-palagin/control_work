// Написать программу, которая из имеющегося массива строк формирует массив строк, длинна которых меньше либо равна 3 символа

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void EnterArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] collection)
{
    Console.Write("Вывод массива: [");
    for (int i = 0; i < collection.Length - 1; i++)
    {
        Console.Write(collection[i] + ", ");
    }
    Console.Write(collection[collection.Length - 1] + "]");
}


