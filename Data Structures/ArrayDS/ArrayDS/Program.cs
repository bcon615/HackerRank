﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the reverseArray function below.
     */
    static int[] reverseArray(int[] a)
    {
        for (int i = 0; i < a.Length / 2; i++)
        {
            int tmp = a[i];
            a[i] = a[a.Length - i - 1];
            a[a.Length - i - 1] = tmp;
        }

        return a;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] res = reverseArray(arr);

        textWriter.WriteLine(string.Join(" ", res));

        textWriter.Flush();
        textWriter.Close();
    }
}
