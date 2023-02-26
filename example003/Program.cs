// Сформировать трехмерный массив не повторяющимися двузначными числами
// показать его построчно на экран выводя индексы соответствующего элемента
Console.Write(" Введите значение X : ");
int x = int.Parse(Console.ReadLine() ?? "0");

Console.Write(" Введите значение Y : ");
int y = int.Parse(Console.ReadLine() ?? "0");

Console.Write(" Введите значение Z : ");
int z = int.Parse(Console.ReadLine() ?? "0");

int [,,] matrix = new int [x,y,z];
int number = 10;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            matrix[i,j,k] = number;
            number += 1;
            Console.Write($"[{i},{j},{k}] {matrix[i,j,k]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}