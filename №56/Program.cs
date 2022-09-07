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

int [] ar = new int [m];
int k = 0;
for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
           ar [k] = ar[k] + matrix [i, j];
        }
        k++;
    }
int p = 0;
int minN = 0;
int min = ar[p];
p++;
while (p<ar.Length)
{
    if (ar[p]<min) 
    {
      min = ar[p]; 
      minN = p;
      p++; 
    } 
    else 
    {
       p++; 
    }
}
Console.WriteLine($"Вот номер строки, с наименьшей суммой элементов: {minN+1}");