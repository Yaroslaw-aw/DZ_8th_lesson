//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)

int[,,] dz_array = Fill_3d_array(2, 2, 2);

Print_3d_dz_array(dz_array);


void Print_3d_dz_array(int[,,] dz_array)
{
    int stands = dz_array.GetLength(0);
    int lines = dz_array.GetLength(1);
    int columns = dz_array.GetLength(2);

    for (int i = 0; i < stands; i++)
    {
        for (int j = 0; j < lines; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                Console.Write($"{dz_array[j, k, i]}({j}, {k}, {i}) ");
            }
            Console.WriteLine();
        }
    }
}


int[,,] Fill_3d_array(int stands, int lines, int columns)
{
    int[,,] _3darray = new int[stands, lines, columns];
    

    for (int i = 0; i < stands; i++)
    {
        for (int j = 0; j < lines; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                _3darray[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return _3darray;
}
