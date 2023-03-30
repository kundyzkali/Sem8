//Задача 53.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        {
            for (int j = 0; j < matrix.GetLength(1); j++)

            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}

void FirstLastRowsReplacement(int[,] matrix)
{
  int firstRow = 0;
  int lastRow = matrix.GetLength(0) - 1;  
 for (int i = 0; i < matrix.GetLength(1); i++)
 {
    int temp = matrix[firstRow, i];
   matrix[firstRow, i] = matrix[lastRow, i];
   matrix[lastRow, i] = temp; 
 }
}

int MatrixDiagonalSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i, j];
            }
        }

    }
    return sum;
}
int[,] matrixArray = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matrixArray);
Console.WriteLine();
FirstLastRowsReplacement(matrixArray);
PrintMatrix(matrixArray);
