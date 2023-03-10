//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07


int[,] dz_array = Fill_spitally_Array(4, 4);

PrintArray(dz_array);

int[,] Fill_spitally_Array(int m, int n)
{
    int[,] _array = new int[m, n];

    int line = _array.GetLength(0), column = _array.GetLength(1);

    int count = 5;
    int numbers = 0;    

    for (int i = 0; i < line; i++)
    {        
        for (int j = 0; j < column; j++)
        {            
            int swither = count % 4;

            if (swither == 1 && j < column)
            {
                numbers++;
                _array[i, j] += numbers;                
            }
            else if (swither == 2 && j < column - i)
            {
                numbers++;
                _array[j + 1, column - i] += numbers;
                if (j + 1 == column -1)
                {
                    _array[column - i, j] += numbers;
                }
            }
            else if (swither == 3 && column - i - j >= 0)
            {
                numbers++;
                _array[line - i + 1, column - i - j ] += numbers;
            }
            //else if (swither == 0 && )
            //{
            //    count++;
            //}

            //_array[i, j] += count % 4 == 3 ? count2 : 0;
            //_array[i, j] += count % 4 == 0 ? count2 : 0;             
        }
        count++;
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
                    int l = (int)matrix.GetValue(i, j);
                    if (l < 10)
                    {
                        Console.Write($"0{l} ");
                    }
                    else
                    {
                        Console.Write($"{matrix.GetValue(i, j)} ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            break;
    }
}
