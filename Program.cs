// Задача 57: Составить частотный словарь двумерного массива.
// Частотный словарь содержит информацию о том, Сколько раз
// встречается элемент входных данных.


int lines = new Random().Next(3, 5);
int columns = new Random().Next(3, 5);

int[,] array_57 = Fill_Array(lines, columns);

int[] one_d_array = Two_dimensionnal_array_to_one_dementional(array_57);

Array.Sort(one_d_array);

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
            _array[i, j] = new Random().Next(20);            
        }        
    }
    return _array;
}

void Print_2d_array(int[,] _array)
{
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            Console.Write(_array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Print_1d_array(int[] _array)
{
    for (int i = 0; i < _array.Length; i++)
    {
        Console.Write(_array[i] + " ");
    }
    Console.WriteLine();
}