// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write($"Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[m];

for (int i = 0; i < m; i++)
{
    Console.Write($"Введите элемент массива с индексом {i} ");
    arr[i] = int.Parse(Console.ReadLine());
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{collection[position]}, ");
        position++;
    }
}
Console.WriteLine();
PrintArray(arr);

int count = 0;
void CountNum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
}
CountNum(arr);
Console.WriteLine("Количество элементов больше 0: " + count);
