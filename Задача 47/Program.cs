// Задайте двумерный массив размером M x N, заполненный случайными вещественными числами.
// M = 3, N = 4
// 0,5 7 -2 0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7 1,9

Console.Clear();

double[,]array = new double[3, 4];
 
for (int i = 0; i < 3; i++)
{
     for (int j = 0; j <4; j++)
    {
         array[i, j] = new Random().NextDouble() * new Random().Next(-20, 20);
         Console.Write("{0}\t", array[i, j]);
    }   
    Console.WriteLine();
}

