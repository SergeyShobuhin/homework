// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Определяем числа
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine());

// цикл сравнения чисел, в том числе если они равны
if (firstNumber >= secondNumber & firstNumber >= thirdNumber) 
    {
        Console.WriteLine($"Первое число: {firstNumber} больше");
    }  
if (firstNumber <= secondNumber & secondNumber >= thirdNumber) 
    {
        Console.WriteLine($"Второе чило: {secondNumber} больше");
    }  
if (firstNumber <= thirdNumber & secondNumber <= thirdNumber) 
    { 
        Console.WriteLine($"Третье число: {thirdNumber} - больше");
    }
    
