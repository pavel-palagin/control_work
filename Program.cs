// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа

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

int size = Promt("Введите количество элементов в массиве: ");
int maxLength = 3;

string[] array = new string[size];


EnterArray(array);
PrintArray(array);

Console.WriteLine();

string[] newArray = new string[array.Length];
int index = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= maxLength)
    {
        newArray[index] = array[i];
        index++;
    }
}

string[] arr = new string[index];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = newArray[i];
}

Console.WriteLine("Вывод массива с элементами, в которых количество символов меньше либо равно 3-м: ");
PrintArray(arr);