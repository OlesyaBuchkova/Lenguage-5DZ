//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] array = new int [10];

void FullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    Console.WriteLine(String.Join(" ", array));
}

int Sum (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        sum += array[i];
    }
    return sum;
}
FullArray(array);
Sum(array);
Console.WriteLine($"Сумма цифр на нечетных позтцтях = {Sum(array)}");