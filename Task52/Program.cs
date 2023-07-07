// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillMatrix(int row, int colon, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, colon];
    Random rand = new Random();

    for(int i =0; i < tempMatrix.GetLength(0); i++ )// или i < row
     {
        for(int j = 0; j < tempMatrix.GetLength(1); j++)    //j количество столбцов
        {
            tempMatrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
     }

     return tempMatrix;
}

int ReadInt(string text)
{
   Console.Write(text);
   return Convert.ToInt32(Console.ReadLine());
}


void PrintMatrix(int[,] matrixForPrint)
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

void Average(int[,] matrix)
{    int sum = 0;
     double average = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        average = Math.Round((double)sum/matrix.GetLength(0),2);
        System.Console.WriteLine();
        System.Console.WriteLine(average);
        sum =0;
    }
}


//---------------------основная часть кода--------------

int rows = ReadInt("Введите количество строк: ");
int colons = ReadInt("Введите количество столбцов: ");
int[,] matrix = FillMatrix(rows, colons, 0, 9);
PrintMatrix(matrix);
Average(matrix);
System.Console.WriteLine();