//  Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.;

Console.WriteLine("Введите количество строк 1-ой матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1-й матрицы (и строк 2-й): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2-й матрицы: ");
int p = int.Parse(Console.ReadLine());

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}
int[,] matrix1 = new int[m, n];
CreateArray(matrix1);
Console.WriteLine($"Первая матрица: ");
PrintArray(matrix1);

int[,] matrix2 = new int[n, p];
CreateArray(matrix2);
Console.WriteLine($"Вторая матрица: ");
PrintArray(matrix2);

int[,] resultMatrix = new int[m, p];
MultiplyMatrix(matrix1, matrix2, resultMatrix);
Console.WriteLine($"Произведение 1-ой матрицы на 2-ую равно: ");
PrintArray(resultMatrix);