//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите число строк двумерного массива");
int lines = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов двумерного массива");
int columns = int.Parse(Console.ReadLine());

int[,] array_57 = Fill_Array(lines, columns);

PrintArray(array_57);

Line_with_minimal_value(array_57);


void Line_with_minimal_value(int[,] _array)
{
    int minimal_line = 1;

    int line_sum = 0;
    int temp_sum = 0;

    for (int i =  0; i < _array.GetLength(0); i++)
    {
        temp_sum = 0;
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            temp_sum += _array[i, j];
        }        
        if (temp_sum < line_sum)
        {
            minimal_line += i;
        }
        else
        {
            line_sum = temp_sum;
        }        
    }
    Console.WriteLine($"Строка с наименьшой суммой элементов: {minimal_line}я строка");
}


// Заполнение массива
int[,] Fill_Array(int m, int n)
{
    int[,] _array = new int[m, n];

    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            _array[i, j] = new Random().Next(10);
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