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

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        
        float RatioPos = 0;
        int PosCount = 0;
        float RatioNeg = 0;
        int NegCount = 0;
        float RatioZero = 0;
        int ZeroCount = 0;
        
        for (int i = 0; i < arr.Count(); i++)
        {
            if (arr[i] > 0)
            {
                PosCount += +1;
                /*Console.WriteLine(PosCount);
                Console.WriteLine("Noveltem a pozitivak szamat");*/
            }
        }
        
        for (int i = 0; i < arr.Count(); i++)
        {
            if (arr[i] < 0)
            {
                NegCount += +1;
            }
        }
        
        for (int i = 0; i < arr.Count(); i++)
        {
            if (arr[i] == 0)
            {
                ZeroCount += +1;
            }
        }
        
       RatioPos = (float)PosCount / (float)arr.Count();
       /*Console.WriteLine(PosCount);
       Console.WriteLine("PosCount");
       Console.WriteLine(arr.Count());
       Console.WriteLine("arr.Count");       
       Console.WriteLine(RatioPos);
       Console.WriteLine("RatioPos");*/       
       RatioNeg = (float)NegCount / (float)arr.Count();       
       RatioZero = (float)ZeroCount / (float)arr.Count();
       
       Console.WriteLine(RatioPos);
       Console.WriteLine(RatioNeg);
       Console.WriteLine(RatioZero);
        
        /*float RandomNumber = 0.4f;
        Console.WriteLine(RandomNumber);*/
        
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
