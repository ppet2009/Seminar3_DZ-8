//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

/*
int[,] Create2DRandomArray(int rows, int columns , int minValue, int maxValue)
{
    int [,] newArray = new int[rows,columns];
    for(int i = 0;i < rows; i++)
        for(int j = 0; j < columns; j ++)
        {
            newArray[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    return newArray;    
}
void Show2DArray (int[,] array )
{
    for(int i = 0;i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }    
}
int [,] ChangeRowsColums(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1)-1; k++)
      {
       	if (array[i,k] < array[i,k + 1])
					{
						int temp = array[i,k + 1];
						array[i,k + 1] = array[i,k];
						array[i,k] = temp;
					}
      }
    }
  }
  return array;
}
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
myArray = ChangeRowsColums(myArray);
Console.WriteLine();
Show2DArray(myArray);
*/

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

/*
Console.WriteLine("Введите диапазон случайных чисел: от 1 до ");
int range = Convert.ToInt32(Console.ReadLine());
void Create2DRandomArray(int [,] array)
    {
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}
void Show2DArray (int[,] array )
{
    for(int i = 0;i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }    
}
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
  
}
Console.WriteLine($"размер матрицы");
Console.WriteLine($"Введите число строк 1-ой матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число столбцов 1-й матрицы");
int n =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк 2-й матрицы ");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-й матрицы ");
int c = Convert.ToInt32(Console.ReadLine());
int[,] firstMartrix = new int[m, n];
Create2DRandomArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
Show2DArray(firstMartrix);
int[,] secomdMartrix = new int[c, p];
Create2DRandomArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
Show2DArray(secomdMartrix);
int[,] resultMatrix = new int[m,p];
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
Show2DArray(resultMatrix);
*/
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int [,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];                        
    for(int i = 0; i < rows; i++)                                   
        for(int j = 0; j < columns; j++)                             
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
        return newArray;
}
void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {                                   
        for(int j = 0; j < array.GetLength(1); j++)                             
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();}
}
int SumElementsFromRow(int[,] array, int i)
{
    int rowSum = array[i, 0];
    for(int j = 1; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    return rowSum;
}
int[,] RowWithlowlestSum(int[,] array)
{
    int minSumRow = 0;
    int rowSum = SumElementsFromRow(array, 0);
    for(int i = 1; i < array.GetLength(0); i++)
    {
        int tempRowSum = SumElementsFromRow(array, i);
        if(rowSum > tempRowSum)
        {
            rowSum = tempRowSum;
            minSumRow = i;
        }
        else Console.WriteLine($"{minSumRow + 1} - строкa с наименьшей суммой. Сумма элементов в указанной строке -> {rowSum} ");
    }
    return array;
}
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
myArray = RowWithlowlestSum(myArray);
Console.WriteLine();
*/