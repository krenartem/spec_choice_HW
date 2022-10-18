// создание массива текстовых элементов
string[] CreateArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите значение {i + 1} элемента массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

// вывод масссива на экран
void ShowArray(string[] array)
{
    Console.WriteLine();
    Console.WriteLine(String.Join("  ", array));
    Console.WriteLine();
}

// запись в новый массив элементов длиной <4 символов
string[] Create3SimbolsArray(string[] array, int size)
{
    string[] newArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

Console.Clear();
int arraySize = new Random().Next(5, 11);
Console.WriteLine($"Количество элементов в массиве = {arraySize}");
Console.WriteLine("В массив можно вносить любые символы: буквы, цифры, знаки препинания и т.д.");
string[] stringArray = new string[arraySize];
stringArray = CreateArray(arraySize);
Console.WriteLine();
Console.Write("Вы задали массив: ");
ShowArray(stringArray);
// подсчет в массиве количества элементов длиной менее 4 символов
int newArraySize = 0;
for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length < 4)
    {
        newArraySize++;
    }
}
if (newArraySize == 0)
{
    Console.WriteLine("В массиве нет элементов длиной менее 4 символов");
    Console.WriteLine();
}
else
{
    Console.WriteLine($"В массиве количество элементов длиной менее 4 символов = {newArraySize}.");
    string[] newStringArray = new string[newArraySize];
    newStringArray = Create3SimbolsArray(stringArray, newArraySize);
    Console.Write("Вот эти элементы:");
    ShowArray(newStringArray);
}