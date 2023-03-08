// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


Console.WriteLine("Введите число строк двумерного массива");
int lines = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов двумерного массива");
int columns = int.Parse(Console.ReadLine());

int[,] array_57 = Fill_Array(lines, columns);

PrintArray(array_57);

Sorting_lines_in_a_two_dimensional_array(array_57);

PrintArray(array_57);




// Сортировка строк в двумерном массиве по убыванию
void Sorting_lines_in_a_two_dimensional_array(int[,] _array)
{
    for (int k = 0; k < _array.GetLength(0); k++)
    {
        for (int i = 0; i < _array.GetLength(1) - 1; i++)
        {
            int max = _array[k, i];
            int max_index = i;

            for (int j = i + 1; j < _array.GetLength(1); j++)
            {
                if (_array[k, j] > max)
                {
                    max = _array[k, j];
                    max_index = j;
                }
            }
            int temp = _array[k, i];
            _array[k, i] = max;
            _array[k, max_index] = temp;
        }
    }
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