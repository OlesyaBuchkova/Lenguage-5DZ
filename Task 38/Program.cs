//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double[] array = new double[10];

void Razn(double[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble()*100;
        Console.WriteLine($"{array[i]:F2}");
    }

}
   
double Rezult(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i])
        max = array[i];
        if (min > array[i])
        min = array[i];
        i++ ;
    }
return max-min;
}
Razn(array);
Rezult(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {Rezult(array):F2}");
