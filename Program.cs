// Задать массив из 8 элементов и вывести их на экран

Console.Clear();

int[] mass = new int[8];
Random rnd = new Random();

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rnd.Next(10, 100);
    Console.Write(mass[i] + "     ");
}