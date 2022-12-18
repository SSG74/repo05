// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void CounterEven(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            counter = counter + 1;
        }
    }
    Console.Write(counter);
}

int[] CreateMassive(int count, int begin, int end)
{
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(begin, end + 1);
    }
    return arr;
}

// Задать массив заполненный случайными положительными трёхзначными числами
int[] array = CreateMassive( 5, 100, 1000);
Console.WriteLine(String.Join(" ", array));
// найти количество чётных чисел в массиве
CounterEven(array); 
