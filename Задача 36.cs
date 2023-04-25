//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов с нечётными индексами.

int[] GenerateArray(int Length)
{
    Console.WriteLine("Введите количество чисел массива: ");
    int N = int.Parse(Console.ReadLine());
    Random rnd = new Random();
    int[] array = new int[N];
    for (int i = 0; i<N; i++)
    {
        array[i] = rnd.Next();
    }
return array;
}

void PrintArray(int[] array)
{
    Console.Write("Массив чисел: [ ");
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();    
}

void Sum(int[] array)
{
    int Sum=0;
    for (int i = 0; i<array.Length; i++)
    {
        if (i%2>0)
        {
        Sum = Math.Abs(Sum + array[i]);    
        }
    }
     Console.WriteLine($"Сумма нечетных элементов: {Sum}");}



int[] array = GenerateArray(6);
PrintArray(array);
Sum(array);
