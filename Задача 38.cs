//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

double[] GenerateArray(int Length)
{
    Console.WriteLine("Введите количество чисел массива: ");
    int N = int.Parse(Console.ReadLine());
    Random rnd = new Random();
    double[] array = new double[N];
    for (int i = 0; i<N; i++)
    {
        array[i] = rnd.NextDouble();
    }
return array;
}

void PrintArray(double[] array)
{
    Console.Write("Массив чисел: [ ");
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();    
}

double Max(double[] array)
{
    double Max=0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]>Max)
        {
        Max = array[i];    
        }
    }
return Max;
}


double Min(double[] array)
{
    double Min=array[0];
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]<Min)
        {
        Min = array[i];    
        }
    }
return Min;
} 

void Sum(double[] array)
{
    double Sum = Max(array)+Min(array);
    Console.WriteLine($"Сумма наибольшего и наименьшего элементов массива равна: {Sum}");
}


double[] array = GenerateArray(6);
PrintArray(array);
Sum(array);
