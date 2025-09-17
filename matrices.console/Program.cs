using matrices.core;
using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter the value m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Enter the value n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("enter the value p: ");
        int p = int.Parse(Console.ReadLine());

        int[,] A = MatrixOperations.FillMatrixA(m, n);
        int[,] B = MatrixOperations.FillMatrixB(n, p);
        int[,] C = MatrixOperations.Multiply(A, B);

        MostrarMatriz("A", A);
        MostrarMatriz("B", B);
        MostrarMatriz("C", C);
    }

    static void MostrarMatriz(string name, int[,] matrix)
    {
        Console.WriteLine($"\n*** {name} ***");
        int filas = matrix.GetLength(0);
        int columnas = matrix.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
                Console.Write($"{matrix[i, j],4}");
            Console.WriteLine();
        }
    }
}