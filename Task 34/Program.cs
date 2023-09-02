//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int [6];

void FullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine(String.Join(" ", array));
}
int Chet(int [] array) 

{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2==0)
        num ++;
    }
    return num;
}
FullArray(array);
Chet(array);
Console.WriteLine($"Количество четных чисел {Chet(array)}");