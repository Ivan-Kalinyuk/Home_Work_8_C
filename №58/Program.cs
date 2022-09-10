void PrintArray(int[,] matr )
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
    Console.WriteLine( );
    }
}

void FillArray(int[,] matr )
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1,10); //[1,10)
        }
    }
}
Console.WriteLine("Вот Ваша 1-я матрица, размером 2х2, заполненная произвольными числами:");
int[,] matrix1 = new int [2,2];
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine("Вот Ваша 2-я матрица, размером 2х2, заполненная произвольными числами:");
int[,] matrix2 = new int [2,2];
FillArray(matrix2);
PrintArray(matrix2);

Console.WriteLine("А вот произведение 2-х матриц:");
int[,] matrix3 = new int [2,2];
Console.Write($"{matrix3[0, 0] = matrix1[0, 0] * matrix2[0, 0] + matrix1[0, 1] * matrix2[1, 0]} ");
Console.Write($"{matrix3[0, 1] = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1]} ");
Console.WriteLine( );
Console.Write($"{matrix3[1, 0] = matrix1[1, 0] * matrix2[0, 0] + matrix1[1, 0] * matrix2[1, 0]} ");
Console.Write($"{matrix3[1, 1] = matrix1[1, 0] * matrix2[0, 1] + matrix1[1, 1] * matrix2[1, 1]} ");