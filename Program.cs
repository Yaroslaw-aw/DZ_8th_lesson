//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18




var matrix_size = Create_matrix();

int[,] matrix_1 = Fill_Array(matrix_size.lines, matrix_size.columns);

PrintArray(matrix_1);

int[,] matrix_2 = Fill_Array(matrix_size.columns, matrix_size.lines);

PrintArray(matrix_2);

int[,] matrix_result = Matrix_multiplication(matrix_1, matrix_2);

PrintArray(matrix_result);



// Функции:

// перемножение матриц
int[,] Matrix_multiplication(int[,] matrix1, int[,] matrix2)
{
    int lines = matrix1.GetLength(0);
    int columns = matrix2.GetLength(1);

    int[,] matrix_result = new int[lines, columns];

    int sum = 0;

    for (int i = 0; i < columns; i++)
    {        
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            matrix_result[i, j] = sum;
            sum = 0;
        }        
    }
    return matrix_result;
}



// Задание размеров перемножаемых матриц
(int lines, int columns) Create_matrix()
{
    Console.WriteLine("Введите количество строк первой матрицы");
    int lines = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов второй матрицы");
    int columns = int.Parse(Console.ReadLine());

    return (lines, columns);
}

// Заполнение массива
int[,] Fill_Array(int lines, int columns)
{
    int[,] _array = new int[lines, columns];

    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            _array[i, j] = new Random().Next(1, 5);
        }
    }
    return _array;
}


//Вывести массив любого типа на консоль
void PrintArray(Array matrix)
{
    switch (matrix.Rank)
    {
        case 1:
            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
                Console.Write($"{matrix.GetValue(i)} ");
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix.GetValue(i, j)} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            break;
    }
}