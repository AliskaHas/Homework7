// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] FillMatrix(int row, int colon, double leftRange, double rightRange)
{
    double[,] tempMatrix = new double[row, colon];
    Random rand = new Random();

    for(int i =0; i < tempMatrix.GetLength(0); i++ )// или i < row
     {
        for(int j = 0; j < tempMatrix.GetLength(1); j++)    //j количество столбцов
        {
            tempMatrix[i,j] = Math.Round((rightRange - 1)* rand.NextDouble()+1,2);
        }
     }

     return tempMatrix;
}

int ReadInt1(string text)
{
   Console.Write(text);
   return Convert.ToInt32(Console.ReadLine());
}

double ReadInt2(string text)
{
   Console.Write(text);
   return Convert.ToDouble(Console.ReadLine());
}


void PrintMatrix(double[,] matrixForPrint)
{
     

    for(int i =0; i < matrixForPrint.GetLength(0); i++ )// или i < row
     {
        for(int j = 0; j < matrixForPrint.GetLength(1); j++)    //j количество столбцов
        {
            System.Console.Write(matrixForPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
     }

}

//---------------------основная часть кода--------------

int rows = ReadInt1("Введите количество строк: ");
int colons = ReadInt1("Введите количество столбцов: ");
double leftRange = ReadInt2("Введите нижнюю границу массива: ");
double rightRange = ReadInt2("Введите верхнюю границу массива: ");
double[,] matrix = FillMatrix(rows, colons, 0, 10);
PrintMatrix(matrix);