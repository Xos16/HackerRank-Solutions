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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        
        long Nums = arr.Length; //A szamok (mennyisege) egyenlo a tomb hosszaval.
        long MaxNum = 0; //Maximum szam a tombben.
        long MinNum = 0; //Minimum szam a tombben.
        long MaxSum = 0; //Maximum szumma (egyik megoldas).
        long MinSum = 0; //Minimum szumma (egyik megoldas).
        
        MaxNum = arr[0]; //Legnagyobb szam megkeresese.
        
        for (int i = 0; i < Nums; i++)
        
            if (arr[i] > MaxNum)
            
                MaxNum = arr[i];                
        
        
        MinNum = arr[0]; //Legkisebb szam megkeresese.
        
        for(int i = 1; i < Nums; i++)
        
            if(arr[i] < MinNum)
            
                MinNum = arr[i];
                
        //Muvelet vegzes: a Minimum szumma es a legnagyobb szam kulonsege.
        for (int i = 0; i < Nums; i++)
            MinSum = MinSum + arr[i];
            
            Console.Write("" + (MinSum - MaxNum));
                                    
        //Muvelet vegzes: A Maximum szumma es a legkisebb szam kulonbsege.
        for (int i = 0; i < Nums; i++)
            MaxSum = MaxSum + arr[i];
            
            Console.Write(" " + (MaxSum - MinNum));                                
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
