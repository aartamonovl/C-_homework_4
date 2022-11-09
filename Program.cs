// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B
// В задаче не указано, какой тип у числа А, поэтому использовал double

// void PrintInConsole(double res)
// {
//     Console.WriteLine($"Result of your operation is '{res}'");
// }

// double DegreeOfNumber(double a, int b)
// {
//     double result = 1;
//     for(int i = 1; i <= b; i++)
//     {
//         result *= a;
//     }
//     return result;
// }

// Console.Write("Input a number: ");
// double number = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input a natural degree: ");
// int degree = Convert.ToInt32(Console.ReadLine());

// PrintInConsole(DegreeOfNumber(number, degree));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// void PrintInConsole(int res)
// {
//     Console.WriteLine($"Sum digits of your number is '{res}'");
// }

// int SumDigitsOfNumber(int number)
// {
//     int sum = 0;
//     if(number < 0) number *= -1;
//     while(number > 0)
//     {
//         sum += number%10;
//         number /= 10;
//     }
//     return sum;
// }

// Console.Write("Input an intreger number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// PrintInConsole(SumDigitsOfNumber(number));

// Задача 29: Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.

int[] CreateRandArray(int n)
{
    int[] arr = new int[n];
    for (int index = 0; index < n; index++)
    {
        arr[index] = new Random().Next(1,100);
    }
    return arr;
}

void PrintInConsole(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b]");
    Console.WriteLine();
}

Console.Write("Input a size of the array (it must be greater than 0): ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 0) PrintInConsole(CreateRandArray(num));
else Console.WriteLine("Try again!");