// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
int[] array = new int[4];

Console.Write("[ ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.Write("]");

int summ = 0;
for (int i = 1; i < array.Length; i=i+2)
{
    summ = summ + array[i];
}

Console.Write($" -> {summ}");