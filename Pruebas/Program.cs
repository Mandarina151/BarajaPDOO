using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            serpiete();
        }

        private static void serpiete()
        {
            int row = 0;
            int[,] matrix1;

            Console.WriteLine("Seleccione las filas y columnas del tablero (NxN)");
            row = Convert.ToInt16(Console.ReadLine());

            matrix1 = new int[row, row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    matrix1[i, j] = 0;
                }
            }

            Console.WriteLine("Mostrando tablero....");
            mostrarMatriz(matrix1);

            Console.WriteLine("Mostrando punto de inicio....");
            int aRow = matrix1.GetLength(0) / 2;
            int aCol = matrix1.GetLength(1) / 2;
            matrix1[aRow, aCol] = 1;
            mostrarMatriz(matrix1);

            Console.WriteLine("Use las flechas para moverse.Si desea cerrar el programa use ESC.");
            Boolean flag = true;
            while (flag)
            {
                flag = checkCompletedMatrix(matrix1);
                if (flag == true)
                {
                    var ch = Console.ReadKey(false).Key;
                    Boolean correctMove = true;
                    switch (ch)
                    {
                        case ConsoleKey.Escape:
                            ShutdownApp();
                            return;
                        case ConsoleKey.UpArrow:
                            aRow--;
                            correctMove = Move(aRow, aCol, matrix1);
                            if (correctMove == false)
                                aRow++;
                            break;
                        case ConsoleKey.DownArrow:
                            aRow++;
                            correctMove = Move(aRow, aCol, matrix1);
                            if (correctMove == false)
                                aRow--;
                            break;
                        case ConsoleKey.RightArrow:
                            aCol++;
                            correctMove = Move(aRow, aCol, matrix1);
                            if (correctMove == false)
                                aCol--;
                            break;
                        case ConsoleKey.LeftArrow:
                            aCol--;
                            correctMove = Move(aRow, aCol, matrix1);
                            if (correctMove == false)
                                aCol++;
                            break;
                    }
                }
            }

            if (flag == false)
                Console.WriteLine("No queda mas Matrix, has ganado");
        }

        private static bool Move(int aRow, int aCol, int[,] matrix1)
        {
            Console.WriteLine("");
            try { 
                if (matrix1[aRow, aCol] == 1)
                {
                    Console.WriteLine("Moviento no valido");
                    mostrarMatriz(matrix1);
                    return false;
                }
                else
                {
                    matrix1[aRow, aCol] = 1;

                } 
            }
             catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Moviento fuera de rango");
                    mostrarMatriz(matrix1);
                    return false;
                }

            mostrarMatriz(matrix1);
            return true;
        }

        private static bool checkCompletedMatrix(int[,] matrix1)
        {
            for (int f = 0; f < matrix1.GetLength(0); f++)
            {
                for (int c = 0; c < matrix1.GetLength(1); c++)
                {
                    if(matrix1[f, c].Equals(0))
                        return true;
                }
               
            }
            return false;
        }

        private static void ShutdownApp()
        {
            Console.WriteLine("Cerrando el programa...");
            Console.WriteLine("");
            Thread.Sleep(5000);
        }

        private static void mostrarMatriz(int[,] matrix1)
        {
            for (int f = 0; f < matrix1.GetLength(0); f++)
            {
                for (int c = 0; c < matrix1.GetLength(1); c++)
                {
                    Console.Write(matrix1[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}