// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B
// В задаче не указано, какой тип у числа А, поэтому использовал double

void PrintInConsole(double res)
{
    Console.WriteLine($"Result of your operation is '{res}'");
}

double DegreeOfNumber(double a, int b)
{
    double result = 1;
    for(int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

Console.Write("Input a number: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input a natural degree: ");
int degree = Convert.ToInt32(Console.ReadLine());

PrintInConsole(DegreeOfNumber(number, degree));
