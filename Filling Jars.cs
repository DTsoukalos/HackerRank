using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'solve' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY operations
     */

    public static ulong solve(int n, List<List<int>> operations)
    {
        ulong candys = 0;
        for (int i = 0; i < operations.Count; i++)
        {
            candys += (ulong)operations[i][2] * ((ulong)operations[i][1] - (ulong)operations[i][0] + 1);

        }

        ulong final = candys / (ulong)n;
        return final;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> operations = new List<List<int>>();

        for (int i = 0; i < m; i++)
        {
            operations.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(operationsTemp => Convert.ToInt32(operationsTemp)).ToList());
        }

        ulong result = Result.solve(n, operations);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
