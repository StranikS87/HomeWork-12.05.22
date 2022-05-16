// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


int[] mass = new int[10];
int count = 0;
 
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-100, 100);
}

for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");