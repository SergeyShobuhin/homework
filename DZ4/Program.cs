// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Определяем число и приводим его к первому чётному.
Console.Write("Введите первое число: ");
int number = int.Parse(Console.ReadLine());
int numberN = 2;

// Запускаем итерацию по чётным числам
while (numberN < number)
    {            
        Console.WriteLine(numberN);
        numberN = numberN + 2;
    }

