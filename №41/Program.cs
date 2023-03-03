/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();
Console.Write("Введите числа (через пробел): ");
int [] fast = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for ( int g = 0; g < fast.Length; g++)
{
    if (fast[g] > 0)
    {
        count ++;
    }
}
Console.WriteLine($"Числа > 0: {count}");