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

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
                        
        //Helping variables
        int AppleArrayLenght = apples.Length;
        int ResultApplesCount = 0;
        
        for (int i = 0; i < AppleArrayLenght; i++)
        {
            //Apple
            //Calculation formula:(Tree start point - apples[elements of])
            // >= House start point & (Tree start point - apples[elements
            // of]) <= House end point
            if ((a + (apples[i])) >= s & (a + (apples[i])) <= t)
            
            //Counting execution
            ResultApplesCount++;
        }                                
            
            
       //Helping variables                                                 
       int OrangeArrayLenght = oranges.Length;
       int ResultOrangesCount = 0;       
       
       for (int i = 0; i < OrangeArrayLenght; i++)
       {
           //Oranges
           //Same functionality as Apple
           if ((b + (oranges[i])) >= s & (b + (oranges[i])) <= t)
           
           ResultOrangesCount++;                           
       }
                                              
        //Returning the counted amount of fruits each type.
        Console.WriteLine(ResultApplesCount);
        Console.WriteLine(ResultOrangesCount);
       
       
       
        //Syntaxic error in usage of List? Must not allow to return                 ("twice?")
       /* 
        List<int> ResultApples = new List<int>();        
        List<int> InvalidApples = new List<int>();        
        foreach (int aApple in apples)
        {
            if (aApple >= s & aApple <= t)
            {
                ResultApples.Add(aApple);
            }
            else
            {
                InvalidApples.Add(aApple);
            }
        }
        */                
                
        //return ResultApplesCount;
        //return ResultOrangesCount;
    }

    static void Main(string[] args) {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
        ;

        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
        ;
        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
