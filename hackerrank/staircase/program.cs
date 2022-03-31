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

    // Complete the staircase function below.
    static void staircase(int n) {                
        
        //int BaseX = 6; --> Koordinata X tengely mint alap.
        //int HeightY = 6; --> Koordinata y tengely mint magassag.        
        //int n = 6; Igazabol alapbol tartalmazza...
        
        
        
                // (n - 1) --> 6-1 ertek -> " rajz terulet".
          for (int HeightY = n - 1; HeightY >= 0; HeightY--)
            {
                for (int BaseX = 0; BaseX < n; BaseX++)
            {
                //Ha az atlo alatt talalhato az ertek, irjon "#".
                if (BaseX >= HeightY)
                {
                    Console.Write("#");
                }
                
                //Ellenkezo esetben ures ter.
                else
                {
                    Console.Write(" ");
                }
            }
            //Sortoresek a ciklus vegeig.
            Console.WriteLine("");
            }
        
        
        
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
