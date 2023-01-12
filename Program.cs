
// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.Write("] ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void ElementsDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) -1; k++)
                if(array[i, k] < array[i, k +1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
}
int[,] myArray = CreateRandom2dArray();
Console.WriteLine("Source array:");
Show2dArray(myArray);
ElementsDescending(myArray);
Console.WriteLine("Ordered array:");
Show2dArray(myArray);
*/


//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.Write("] ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void ArraySumRows(int[,] array)
{
    int[] arraySum = new int[array.GetLength(0)];
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRows = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sumRows += array[i, j];
        arraySum[i] = sumRows;
        if (arraySum[i] < arraySum[min])
            min = i;
    }
    Console.WriteLine($"Row {min + 1} minimum amount is {arraySum[min]} ");
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
if (rows != colums)
{
    int[,] myArray = CreateRandom2dArray(rows, colums);
    Show2dArray(myArray);
    ArraySumRows(myArray);
}
else
{
    Console.WriteLine("Error! Set the parameters of a rectangular 2d array!");
}
*/


//Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " \t");
        Console.WriteLine();
    }
Console.WriteLine();
}
int[,] ProdMatrix(int[,] array1, int[,] array2)
{
    int[,] prodMatrixArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            prodMatrixArray[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
                prodMatrixArray[i, j] += array1[i, k] * array2[k, j];
        }
    return prodMatrixArray;
}
void ErrorMatrix()
{
    Console.WriteLine("Error! The number of columns in the first matrix must equal the number of rows in the second matrix!");
}
int[,] myArray1 = CreateRandom2dArray();
int[,] myArray2 = CreateRandom2dArray();
Show2dArray(myArray1);
Show2dArray(myArray2);
if (myArray1.GetLength(1) == myArray2.GetLength(0))
{
    int[,] prodArray = ProdMatrix(myArray1, myArray2);
    Show2dArray(prodArray);
}
else ErrorMatrix();
*/


//Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    int count = 1;
    int num = 0;
    int allNums = 0;
    while (allNums < rows * columns)
    {
        num++;
        for (int i = num - 1; i < columns - num + 1; i++)
        {
            array[num - 1, i] = count++;
            allNums++;
        }
        for (int i = num; i < rows - num + 1; i++)
        {
            array[i, columns - num] = count++;
            allNums++;
        }
        for (int i = columns - num - 1; i >= num - 1; i--)
        {
            array[rows - num, i] = count++;
            allNums++;
        }
        for (int i = rows - num - 1; i >= num; i--)
        {
            array[i, num - 1] = count++;
            allNums++;
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);


