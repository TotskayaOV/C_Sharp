// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = {3, 7, 22, 2, 78};

//находим макс и мин

double Max(double arg1, double arg2, double arg3, double arg4, double arg5)
{
    double result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    if(arg4 > result) result = arg4;
    if(arg5 > result) result = arg5;
    return result;
}
double max = Max(array[0], array[1], array[2], array[3], array[4]);

double Min(double arg1, double arg2, double arg3, double arg4, double arg5)
{
    double result = arg1;
    if(arg2 < result) result = arg2;
    if(arg3 < result) result = arg3;
    if(arg4 < result) result = arg4;
    if(arg5 < result) result = arg5;
    return result;
}
double min = Min(array[0], array[1], array[2], array[3], array[4]);
Console.WriteLine(max);
Console.WriteLine(min);

//находим разницу

double numbers = max - min;

Console.Write($"{array} -> {numbers}");