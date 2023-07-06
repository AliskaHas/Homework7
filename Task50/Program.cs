// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int ReadInt1(string text)
{
   Console.Write(text);
   return Convert.ToInt32(Console.ReadLine());
}

int ReadInt2(string text)
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



//---------------------основная часть кода--------------

int rows = ReadInt1("Введите количество строк: ");
int colons = ReadInt1("Введите количество столбцов: ");
int[,] matrix = FillMatrix(rows, colons, 0, 9);
PrintMatrix(matrix);
int a = ReadInt2("Введите номер строки: ");
int b = ReadInt2("Введите номер столбца: ");
if((a > matrix.GetLength(0) || b > matrix.GetLength(1)))
{
    System.Console.WriteLine("В данном массиве нет элемента с такой позицией");
}
else
{
        System.Console.WriteLine("Значение элемента массива с заданными значениями = {0}", matrix[a-1,b-1]);
}
