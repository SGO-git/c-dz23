// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

int[,] CreateMatrix(int m, int n, int leftRange, int rightRange)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] SumRow(int[,] matrix)
{
    int sum = 0;
    int[] result = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        result[i] = sum;
        sum = 0;
    }
    return result;
}

void MinRow(int[] array)
{
    int count = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            count = i;
        }

    }
    System.Console.WriteLine("Min row is " + (count + 1));
}

int[,] myMatrix = CreateMatrix(3, 3, 0, 9);
PrintArray(myMatrix);
int[] avrArray = SumRow(myMatrix);
MinRow(avrArray);