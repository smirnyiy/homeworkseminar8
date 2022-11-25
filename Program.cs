// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

/*
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void SortRowsInArray(int[,] inArray)
{
    for (int k = 0; k < inArray.GetLength(0); k++)
    {
        for (int i = 0; i < inArray.GetLength(1); i++)
        {
        for (int j = i + 1; j < inArray.GetLength(1); j++)
        {
            if (inArray[k,i] < inArray[k,j])
            {
                int temp = inArray[k,i];
                inArray[k,i] = inArray[k,j];
                inArray[k,j] = temp;
            }
        }
    }
}
}
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, columns, 0, 99);
PrintArray(array);
Console.WriteLine();
SortRowsInArray(array);
PrintArray(array);

*/

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
int[] SumRowInArray(int[,] Array)
{
    int[] result = new int[Array.GetLength(0)];
    int k = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            sum += Array[i, j];
        }
        result[k++] = sum;
    }
    return result;
}
void FindRowMinSum(int[] arr)
{
    int minSum = arr[0];
    int rowMinSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minSum)
        {
            minSum = arr[i];
            rowMinSum = i;
        }
    }
    Console.Write($"Наименьшая сумма элементов массива равна: {minSum}, и находится в строке с индексом: {rowMinSum}. ");
}
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);
int[] newArray = SumRowInArray(array);
Console.WriteLine();
FindRowMinSum(newArray);
*/

// Задача 62: Заполните спирально массив 4 на 4.

/*
int[,] SpiralFillArray(int a)
{
    int size = a;
    int[,] fillMass = new int[size, size];
    int row = 0;
    int col = 0;
    for (int i = 1; i <= size * size; i++)
    {
        fillMass[row, col] = i;
        if (row <= col + 1 && row + col < size - 1) col++;
        else if (row < col && row + col >= size - 1) row++;
        else if (row >= col && row + col > size - 1) col--;
        else row--;
    }
    return fillMass;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размер квадратного массива: ");
int array = int.Parse(Console.ReadLine()!);
PrintArray(SpiralFillArray(array));

*/