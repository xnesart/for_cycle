//Задание 1) Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
Console.WriteLine("Задание 1");
Console.WriteLine("введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B");
int b = int.Parse(Console.ReadLine());
int c = a;
for (int i = 1; i < b; i++)
{
    a *= c;
}
Console.WriteLine(a);
//Задание 2) Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
Console.WriteLine("Задание 2");
Console.WriteLine("введите число");
int value = int.Parse(Console.ReadLine());
for (int i = 1; i <= 1000; i++)
{
    if (i % value == 0)
    {
        Console.WriteLine(i);
    }
}
//Задание 3) Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
Console.WriteLine("Задание 3");
Console.WriteLine("введите число");
int userNumber = int.Parse(Console.ReadLine());
int counter = 0;
for (int i = 1; i < userNumber / 2; i++)
{
    if (i * i < userNumber)
    {
        counter++;
    }
}
Console.WriteLine(counter);
//Задание 4) Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся на 7.
Console.WriteLine("Задание 4");
Console.WriteLine("введите число A");
int userNumberA = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B");
int userNumberB = int.Parse(Console.ReadLine());
int summ = 0;

for (int i = userNumberA; i < userNumberB; i++)
{
    if (i % 7 == 0)
    {
        Console.WriteLine(i);
        summ += i;
    }
}
Console.WriteLine(summ);
//Задание 5) Пользователь вводит положительное число (N).
//Выведите N-ое число ряда Фибоначчи.
//В ряду Фибоначчи каждое следующее число является
//суммой двух предыдущих (1, 1, 2, 3, 5, 8, 13...). Первое и второе считаются равными 1.
Console.WriteLine("Задание 5");
Console.WriteLine("Введите число N");
int uValue = int.Parse(Console.ReadLine());
int fb1 = 1;
int fb2 = 1;
int fibonachi = 1;
if (uValue == 1)
{
    Console.WriteLine(fibonachi);
}
else
{
    for (int i = 2; i < uValue; i++)
    {
        fibonachi = fb1 + fb2;
        fb1 = fb2;
        fb2 = fibonachi;
    }
    Console.WriteLine(fibonachi);
}
Console.ReadLine();

