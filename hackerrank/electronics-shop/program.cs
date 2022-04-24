using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the getMoneySpent function below.
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b) {
        
        int currentPrice = 0;
        
        Array.Sort(keyboards);
        Array.Sort(drives);
        
        if ((keyboards[0] + drives[0]) > b )
        {   
            return -1;
        }
        
        List<int> prices = new List<int>();
        
        for (int i = 0; i < keyboards.Count(); i++)
        {
            
            for (int j = 0; j < drives.Count(); j++)
            {
                int pairs;
                pairs = keyboards[i] + drives[j];
                prices.Add(pairs);
            }
        }
        
        prices.Sort();
        
        /*IEnumerable<int>*/int pairsQuery = 
            (from pairs in prices
            where pairs <= b
            select pairs).Last();
            
        
        return pairsQuery;
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);

        textWriter.WriteLine(moneySpent);

        textWriter.Flush();
        textWriter.Close();
    }
}
