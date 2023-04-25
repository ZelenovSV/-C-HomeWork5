//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GenerateArray(int Length)
{
    Console.WriteLine("Введите количество чисел массива: ");
    int N = int.Parse(Console.ReadLine());
    Random rnd = new Random();
    int[] array = new int[N];
    for (int i = 0; i<N; i++)
    {
        array[i] = rnd.Next(99, 1000);
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

void EvenNumbers(int[] array)
{
    int count=0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]%2==0)
        {
        count = count + 1;    
        }
    }
     Console.WriteLine($"Количество чётных чисел в массиве: {count}");}



int[] array = GenerateArray(6);
PrintArray(array);
EvenNumbers(array);


