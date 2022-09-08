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
Console.WriteLine("Введите число строк Вашего массива");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число столбцов Вашего массива");
int n = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Вот Ваш массив, заполненный произвольными числами:");
int[,] matrix = new int [m,n];
FillArray(matrix);
PrintArray(matrix);
for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int k=0; k<matrix.GetLength(1); k++)
        {
          for (int j=0; j<matrix.GetLength(1)-1; j++)
          {
            if ( matrix [i, j+1]>matrix [i, j])
            {
                int help = matrix [i, j];
                matrix [i, j] = matrix [i, j+1];
                matrix [i, j+1] = help;
            }
          }
        }  
    }
Console.WriteLine("А вот этот же массив, заполненный в порядке убывания построчно:");
PrintArray(matrix);
