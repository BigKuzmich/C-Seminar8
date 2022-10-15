using System;


void Task1()
{
    Console.WriteLine("введите количество строк");
    int linesVol = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int columnsVol = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[linesVol, columnsVol];
    FillArrayRandomNumbers(numbers);
    Console.WriteLine();
    Console.WriteLine("Массив до изменения");
    PrintArray(numbers);

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++)
            {
                if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                {
                    int temp = 0;
                    temp = numbers[i, z];
                    numbers[i, z] = numbers[i, z + 1];
                    numbers[i, z + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("Массив с упорядоченными значениями");
    PrintArray(numbers);

    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}
void Task2()
{
    Console.WriteLine("введите размер квадратного массива");
    int massVol = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[massVol, massVol];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);
    int minsum = Int32.MaxValue;
    int indexLine = 0;

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum = sum + numbers[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }

    Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}
void Task3()
{
    int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }

    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 5); //Для увеличения размера чисел в матрицах поменять число 5 на большее
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }

    int size = InputInt("размерность матриц: ");
    int[,] matrixA = new int[size, size];
    int[,] matrixB = new int[size, size];
    FillArrayRandomNumbers(matrixA);
    FillArrayRandomNumbers(matrixB);
    int[,] matrixC = new int[size, size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
            }
        }
    }
    Console.WriteLine("Матрица - А");
    PrintArray(matrixA);
    Console.WriteLine();
    Console.WriteLine("Матрица - В");
    PrintArray(matrixB);
    Console.WriteLine();
    Console.WriteLine("Произведение матриц А*В");
    PrintArray(matrixC);
}
void Task4()
{
    int deep1 = InputInt("Введите размерность 1: ");
    int deep2 = InputInt("Введите размерность 2: ");
    int deep3 = InputInt("Введите размерность 3: ");
    int countNums = 89;

    if (deep1 * deep2 * deep3 > countNums)
    {
        Console.Write("Массив слишком большой");
        return;
    }

    int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

    for (int i = 0; i < resultNums.GetLength(0); i++)
    {
        for (int j = 0; j < resultNums.GetLength(1); j++)
        {
            for (int k = 0; k < resultNums.GetLength(2); k++)
            {
                Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }


    int[,,] Create3DMassive(int size1, int size2, int size3)
    {
        int[,,] array = new int[size1, size2, size3];
        int[] values = new int[countNums];
        int num
         = 10;
        for (int i = 0; i < values.Length; i++)
            values[i] = num
            ++;

        for (int i = 0; i < values.Length; i++)
        {
            int randomInd = new Random().Next(0, values.Length);
            int temp = values[i];
            values[i] = values[randomInd];
            values[randomInd] = temp;
        }

        int valueIndex = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = values[valueIndex++];
                }
            }
        }
        return array;
    }


    int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }
}
void Task5()
{
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());

    int[,] nums = new int[size, size];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= size * size)
    {
        nums[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
            ++j;
        else if (i < j && i + j >= size - 1)
            ++i;
        else if (i >= j && i + j > size - 1)
            --j;
        else
            --i;
        ++num;
    }

    PrintArray(nums);

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}

while (true)
{
    Console.WriteLine("Введите номер задачи");
    int a = int.Parse(Console.ReadLine());
    if (a == 1)
    {
        Task1();
    }
    if (a == 2)
    {
        Task2();
    }
    if (a == 3)
    {
        Task3();
    }
    if (a == 4)
    {
        Task4();
    }
    if (a == 5)
    {
        Task5();
    }
}