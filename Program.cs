// Задача 57: Составить частотный словарь двумерного массива.
// Частотный словарь содержит информацию о том, Сколько раз
// встречается элемент входных данных.


Console.WriteLine("Введите число строк двумерного массива");
int lines = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число столбцов двумерного массива");
int columns = int.Parse(Console.ReadLine());

int[,] array_57 = Fill_Array(lines, columns);

PrintArray(array_57);

//Matrix_sort(array_57);

//PrintArray(array_57);

int[] one_d_array = Two_dimensionnal_array_to_one_dementional(array_57);

PrintArray(one_d_array);

Array.Sort(one_d_array);

PrintArray(one_d_array);

List_of_numbers(one_d_array);  // решение задачи


void List_of_numbers(int[] numbers)
{
    int count = 1;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (i + 1 == numbers.Length)
        {
            Console.WriteLine($"Количество {numbers[i]} в массиве равно {count}");
            return;
        }
        if (numbers[i] != numbers[i + 1])
        {
            Console.WriteLine($"Количество {numbers[i]} в массиве равно {count}");
            count = 1;
        }
        else
        {
            count++;
        }
    }
}

/// - и где XML комментарий, не пойму ?  короче этот метод копирует
/// элементы двумерного массива в одномерный
int[] Two_dimensionnal_array_to_one_dementional(int[,] _array)
{
    int[] array = new int[_array.GetLength(0) * _array.GetLength(1)];
    int count = 0;

    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            array[count] = _array[i, j];
            count++;
        }
    }
    return array;
}



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



void Matrix_sort(int[,] matrix)
{  
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0;j < matrix.GetLength(1); j++)
        {
            int last_i = matrix.GetLength(0) - 1 - i;
            int last_j = matrix.GetLength(1) - 1 - j;

            int max = matrix[last_i, last_j];
            int max_i = last_i;
            int max_j = last_j;

            for (int k = 0; k < matrix.GetLength(0) - i; k++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {                    
                    if (k == last_i &&
                        l == matrix.GetLength(1) - j)
                    {
                        goto Label;
                    }

                    if (matrix[k, l] > max)
                    {
                        max = matrix[k, l];
                        max_i = k;
                        max_j = l;                        
                    }                    
                }
            }
        Label:
            int temp = matrix[last_i, last_j];
            matrix[last_i, last_j] = max;
            matrix[max_i, max_j] = temp;            
        }
    }
}