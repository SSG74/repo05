// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SummaOfNumber(int[] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
       res = res + array[i];
    }
    return res;       
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

// задайте массив случайных чисел
int[] arr =  CreateMassive(8, -10, 100);
// вывести массив на экран
Console.WriteLine(String.Join(", ", arr));
//  наити сумму чисел на нечетных позициях
int summ = SummaOfNumber(arr);
// вывести на экран сумму
Console.WriteLine(summ);
