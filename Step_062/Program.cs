﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int M = 4, N = 4;
  int[,] arr = new int[M, N];

  int i = 0;
  int j = -1;

  int row = 0;
  int col = 1;                                     // движение в право

  int t = 1;
  while (t <= M * N)
  {
    if (
          (i + row >= 0 & i + row < M) &&
          (j + col >= 0 & j + col < N) &&
          arr[i + row, j + col] == 0
        )
    {
      i += row;
      j += col;
      arr[i, j] = t++;
    }
    else if (col == 1)
    {
      row = 1;
      col = 0;
    }
    else if (row == 1)
    {
      col = -1;
      row = 0;
    }
    else if (col == -1)
    {
      col = 0;
      row = -1;
    }
    else if (row == -1)
    {
      row = 0;
      col = 1;
    }
  }

  for (i = 0; i < M; i++)
  {
    for (j = 0; j < N; j++)
      Console.Write("{0,4}", arr[i, j]);
    Console.WriteLine();
  } 
    