// Найти произведение двух матриц

//Произведение двух матриц АВ имеет смысл только в том случае, когда число 
//столбцов матрицы А совпадает с числом строк матрицы В 

Console.WriteLine("Введите количество строк  первой матрицы: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов первой матрицы/количество строк второй: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int k = int.Parse(Console.ReadLine() ?? "0");

int [,] matrixOne = new int [n,m];
Random randomOne = new Random();
for (int i = 0; i < matrixOne.GetLength(0); i++)
{
    for (int j = 0; j < matrixOne.GetLength(1); j++)
    {
        matrixOne[i,j] = randomOne.Next(0,5);
        Console.Write($"{matrixOne[i,j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

int [,] matrixTwo = new int [m,k];
Random randomTwo = new Random();
for(int i= 0; i < matrixTwo.GetLength(0); i++)
{
    for ( int j =0; j< matrixTwo.GetLength(1); j++)
    {
        matrixTwo[i,j] = randomTwo.Next(0,5);
        Console.Write($"{matrixTwo[i,j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"\nПроизведение матриц равно: ");

int[,] matrixResult = new int [n,k];

PrintMatrix(matrixOne, matrixTwo, matrixResult);
void PrintMatrix(int[,] matrixOne, int [,] matrixTwo,  int [,] matrixResult)
{
  for (int i = 0; i < matrixResult.GetLength(0); i++)
  {
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
        int sum = 0;
        for ( int k = 0; k < matrixResult.GetLength(1); k++)
        {
            sum += matrixOne[i,k] * matrixTwo[k,j];
        }
        matrixResult[i,j] = sum;
        Console.Write($"{matrixResult[i,j]}\t");
    }
    Console.WriteLine();
  }
}
