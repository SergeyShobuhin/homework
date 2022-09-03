// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Определяем числа
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

// цикл сравнения чисел, в том числе если они равны
if (firstNumber < secondNumber) {
    Console.WriteLine($"Первое число: {firstNumber} - меньше, Второе число: {secondNumber} - больше");
    }  else if (firstNumber == secondNumber) {
    Console.WriteLine($"Первое число: {firstNumber} и Второе чило: {secondNumber}  равны!!!");
    }  else { 
        Console.WriteLine($"Второе число: {secondNumber} - меньше, Первое число: {firstNumber} - больше");

    }