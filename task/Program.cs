

int size = 6;
int n = 3;
string[] arrayOne = new string[size];
Console.WriteLine($"Введите набор символов, означающих значение строкогого элемента массива, {size} раз через Enter, без пробелов");
FillArray(arrayOne);
//Console.Clear();
PrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine($"Новый массив, содержащий элементы, размер которых меньше либо равен {n}: ");

if (GetSecondSizeArray(arrayOne) == 0)
{
    Console.WriteLine("Искомых элементов строкого массива для переноса в новый массив - нет");
}
else
{
    string[] arrayTwo = TransferElements(arrayOne);
    PrintArray(arrayTwo);
}


void FillArray (string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? ""; 
    }
}

void PrintArray (string[] arr)
{
    int arrLength = arr.Length;
    Console.Write("[ ");
    for (int i = 0; i < arrLength; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

int GetSecondSizeArray(string[] arr)
{
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            secondSize++;
        }
    }
    return secondSize;
}

string[] TransferElements(string[] arr)
{
    string[] arrayTwo = new string[GetSecondSizeArray(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;
}