
//Seminar#6
/*
// Задача №1
// Условие: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// void Triangle(int a, int b, int c)
// {
//     if (a < b + c && b < a + c && c < a + b)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }

// Console.WriteLine("Напишите первое число");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Напишите второе число");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Напишите третье число");
// int numC = Convert.ToInt32(Console.ReadLine());

// Triangle(numA, numB, numC);

// Задача №2_1
// Условие: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// string Transform(int number)
// {
//     string binary_num = "";
//     while (number >= 1)
//     {
//         binary_num = number % 2 + binary_num;
//         number = number / 2;
//     }
//     return binary_num;
// }
// Console.Write("Enter decimal number:  ");
// int user_input = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Binary number: ");
// Console.WriteLine(Transform(user_input));

// Задача №2_2
// Условие: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// void Binar(int numS)
// {
//     string answer = "";
//     while (numS > 0)
//     {
//         answer = Convert.ToString(numS % 2) + answer;
//         numS = numS / 2;
//     }
//     Console.WriteLine(answer);
// }
// Console.WriteLine("Введите число");
// int Num = Convert.ToInt32(Console.ReadLine());
// Binar(Num);


// Задача №3_1
// Условие: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// void Fib_Bruteforce(int size)
// {
//     int n1 = 0;
//     int n2 = 1;
//     int n;
//     Console.Write(n1 + " " + n2 + " ");
//     for (int i = 2; i < size; i++)
//     {
//         n = n1 + n2;
//         n1 = n2;
//         n2 = n;
//         Console.Write(n + " ");
//     }
// }
// Console.WriteLine("Enter  number:  ");
// int N = Convert.ToInt32(Console.ReadLine());
// Fib_Bruteforce(N);

// Задача №3_2
// Условие: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

// void Fibbon(int numA)
// {
//     int[] array = new int[numA];
//     array[0] = 0;
//     array[1] = 1;
//     Console.Write("0 1 ");
//     for (int i = 2; i < numA; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//         Console.Write(array[i] + " ");
//     }
// }
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Fibbon(num);


// Задача №4_1
// Условие: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[,] init_array = new int[3, 4];
// for (int i = 0; i < init_array.GetLength(0); i++)
// {
//     for (int j = 0; j < init_array.GetLength(1); j++)
//     {
//         init_array[i, j] = new Random().Next(100);
//         Console.Write(init_array[i, j] + " ");
//     }
//     Console.WriteLine(" ");
// }

// Console.WriteLine("----------------------------------");
// int[,] array_copy = new int[init_array.GetLength(0), init_array.GetLength(1)];


// for (int i = 0; i < array_copy.GetLength(0); i++)
// {
//     for (int j = 0; j < array_copy.GetLength(1); j++)
//     {
//         array_copy[i, j] = init_array[i, j];
//         Console.Write(array_copy[i, j] + " ");
//     }
//     Console.WriteLine(" ");
// }

// Задача №4_2
// Условие: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 10);
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// int[,] Matrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
// for (int i = 0; i < Matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < Matrix.GetLength(1); j++)
//     {
//         Matrix[i,j] = matrix[i,j];
//         Console.Write(Matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }    
*/

// Домашняя работа №6
// Задача №1
// Условие: Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void Converter(int count)
// {
//     int pos = 0;
//     int[] array = new int[count];
//     for (int i = 0; i <= count - 1; i++)
//     {
//         Console.WriteLine($"Введите {i + 1}-е число из {count}");
//         array[i] = Convert.ToInt32(Console.ReadLine());//         
//     }
//     Console.WriteLine();
//     foreach (int item in array)
//     {
//         if (item > 0)
//         {
//             pos++;
//         }
//     }
//     if (pos == 0)
//     {
//         Console.WriteLine("Положительных значений не выявленно!");
//     }
//     else Console.WriteLine($"Число положительных элементов в веддёных значениях равно => {pos}");
// }
// Console.WriteLine("Введите размер массива");
// int num = Convert.ToInt32(Console.ReadLine());
// Converter(num);


// Задача №2
// Условие: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.
// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1

void FrameArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0
                || i == array.GetLength(0) - 1
                || j == 0
                || j == array.GetLength(1) - 1)
                array[i, j] = 1;
            else array[i, j] = 0;
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Укажите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] userArray = new int[rows, columns];
FrameArray(userArray);
