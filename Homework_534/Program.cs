// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
int[] array = new int[4];

Console.Write("[ ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99, 1000);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.Write("]");

int count = 0;
int j = 0;
while (j < array.Length)
{
    int x = array[j] % 2;
    if(x == 0)
    {
        count++;
    }
    j++;
}
Console.Write($" -> {count}");