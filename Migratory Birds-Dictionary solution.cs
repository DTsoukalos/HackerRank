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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> theDictionary = new Dictionary<int, int>();
        for (int i = 0; i < arr.Count; i++)
        {
            if (theDictionary.ContainsKey(arr[i]))
            {
                theDictionary[arr[i]]++;
            }
            else
            {
                theDictionary.Add(arr[i], 1);
            }
        }
        int theReturnNumber = 0;
        int theApiaringTimes = 0;
        foreach (var item in theDictionary)
        {
            if (item.Value > theApiaringTimes)
            {
                theReturnNumber = item.Key;
                theApiaringTimes = item.Value;
            }
            else if (item.Value == theApiaringTimes && theReturnNumber > item.Key)
            {
                theReturnNumber = item.Key;
                theApiaringTimes = item.Value;
            }
        }
        return theReturnNumber;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
