// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Укажите количество вводимых чисел");
int numAmount = int.Parse(Console.ReadLine()!);

int[] arr = new int[numAmount];

UserFillArray(arr);

PrintArray(arr);

int positivNumAmount = PositivNumCount(arr);

Console.WriteLine("Количество положительных чисел = " + positivNumAmount);

int PositivNumCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] UserFillArray(int[] array)
{
    for (int i = 1; i < array.Length + 1; i++)
    {
        Console.WriteLine("Введите число под номером " + i + ":");
        array[i-1] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}    