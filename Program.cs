// Задайте двумерный массив. Поменяйте местами первую и последнюю строку массива
Console.WriteLine("Введите количество строк");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int pol = Convert.ToInt32(Console.ReadLine());

int[,] GenAr() {
int[,] array = new int[str, pol];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 100);
    }
} return array;
}

void PrintAr(int[,] array) {
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    } Console.WriteLine();
} 

}

int[,] Replasment(int[,] array) {
int[,] doub = array.Clone() as int[,];
for (int i = 0; i < array.GetLength(0); i++)
{
    if (i == str - 1)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[0,j] = doub[str - 1, j];
           array[str - 1,j] = doub[0, j];
        }
    }
} return array;


}

int[,] newAr = GenAr();
PrintAr(newAr);
Console.WriteLine("_____________________");
Replasment(newAr);
PrintAr(newAr);
