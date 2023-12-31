﻿// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.

// Если N = 5-> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8  

// <aside>
// ❗ Числа Фибоначчи — числовая ****последовательность,
//  каждый элемент которой равен сумме двух предыдущих.


// В данном коде происходит вычисление чисел Фибоначчи и их вывод на экран.

Console.Clear();

Console.WriteLine("Введите число элементов Фибоначчи:  "); // Сначала пользователю предлагается ввести количество элементов последовательности.
int number = int.Parse(Console.ReadLine());


int firstElement = 0; // Затем задаются начальные значения первого 
int secondElement = 1; // и второго элементов.

Console.Write($"{firstElement}  ");  // Далее выводятся на экран первый 
Console.Write($"{secondElement}  "); //и второй элементы, а затем вычисляются остальные.

for (int i = 3; i <= number; i++) // Цикл for проходит по всем элементам, начиная с третьего (так как первые два уже заданы) и до указанного количества.
{
    int nextElement = firstElement + secondElement; // Для каждого элемента вычисляется следующий путем сложения двух предыдущих.
    Console.Write($"{nextElement}  ");
    firstElement = secondElement; // Затем значения первого и второго элементов обновляются для вычисления следующего элемента.
    secondElement = nextElement;
}

Console.WriteLine();// В конце выводится пустая строка.

