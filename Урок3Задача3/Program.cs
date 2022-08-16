// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
System.Console.WriteLine();

System.Console.Write("Введите число:   ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);


int[] GetCubeTable(int N)
{
    int[] cubs = new int[N + 1];
    for (int i = 1; i < cubs.Length; i++)
    {
        cubs[i] = i * i * i;
    }
    return cubs;
}

void PrintCubs(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($"{i} ^ 3 = ");
        System.Console.WriteLine(array[i]);
    }
}

int[] CubeTable = GetCubeTable(N);
PrintCubs(CubeTable);