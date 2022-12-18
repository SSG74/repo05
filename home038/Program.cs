// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FindDiff(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    int diff = max - min;
    Console.Write($"-> {diff} ");
}

int[] CreateMassive(int count, int begin, int end)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(begin, end+1);
    }
    return array;
}

int[] arr =  CreateMassive(8, 1, 100);
Console.WriteLine(String.Join(" ", arr));
FindDiff(arr);