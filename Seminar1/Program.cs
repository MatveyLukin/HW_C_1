/*

// Seminar_C#

//1 задача
 
Console.Write("Введите целое число");
int value = Convert.ToInt32(Console.ReadLine());
int kvadrat_value = value * value;
Console.Write("Квадрат данного числа равен ");
Console.WriteLine(kvadrat_value);


//2 задача

Console.Write("Введите первое число");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int value2 = Convert.ToInt32(Console.ReadLine());

int kvadrat_value2 = value2 * value2;

if (kvadrat_value2 == value1)
{
    Console.WriteLine("Квадрат второго числа соответствует первому числу");
}
else
{
    Console.WriteLine("Искомых соответствий невыявлено");
}



//3 задача

Console.Write("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 7 && number >= 1)
{
    if (number == 1)
    {
        Console.WriteLine("понедельник");
    }
    if (number == 2)
    {
        Console.WriteLine("вторник");
    }
    if (number == 3)
    {
        Console.WriteLine("среда");
    }
    if (number == 4)
    {
        Console.WriteLine("четверг");
    }
    if (number == 5)
    {
        Console.WriteLine("пятница");
    }
    if (number == 6)
    {
        Console.WriteLine("суббота");
    }
    if (number == 7)
    {
        Console.WriteLine("воскресенье");
    }
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}




//4 задача

Console.Write("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
int neg_n = n * (-1);

while (neg_n <= n)
{
    Console.WriteLine(neg_n);
    neg_n++;
}




//3 задача(switch)

Console.Write("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1;
        {
            Console.WriteLine("понедельник");
            break
    }
    case 2;
        {
            Console.WriteLine("вторник");
            break
    }
    case 3;
        {
            Console.WriteLine("среда");
            break
    }
    case 4;
        {
            Console.WriteLine("четверг");
            break
    }
    case 5;
        {
            Console.WriteLine("пятница");
            break
   case 6;
        {
            Console.WriteLine("суббота");
            break
    }
    case 7;
        {
            Console.WriteLine("воскресенье");
            break
     }
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}

*/


/*

// Домашняя работа C#_1_1



Console.Write("Введите первое число ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int value2 = Convert.ToInt32(Console.ReadLine());

if (value1 > value2)
{
    Console.WriteLine("первое число больше второго ");
}
else
{
    Console.WriteLine("второе число больше первого");
}

if (value1 == value2)
{
    Console.WriteLine("числа равны");
}



// Домашняя работа C#_1_2

Console.Write("Введите первое число ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int value2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int value3 = Convert.ToInt32(Console.ReadLine());
int max = value1;

if (value2 > value1)
{
    max = value2;
}
else
{
    max = value1;
}

if (value3 > max)
{
    Console.Write("максимальное число равно ");
    Console.WriteLine(value3);
}
else
{
    Console.Write("максимальное число равно ");
    Console.WriteLine(max);
}



// Домашняя работа C#_1_3

Console.Write("Введите целое число ");
int value = Convert.ToInt32(Console.ReadLine());


if (value % 2 == 0)
{
    Console.Write(value);
    Console.WriteLine("  является чётным числом");
}
else
{
    Console.Write(value);
    Console.WriteLine(" является нечётным числом");
}



// Домашняя работа C#_1_4

Console.Write("Введите натуральное число ");
int N = Convert.ToInt32(Console.ReadLine());
int middle = 2;

while (middle < N && middle > 1)
{
    Console.WriteLine(middle);
    middle += 2;
}

*/
