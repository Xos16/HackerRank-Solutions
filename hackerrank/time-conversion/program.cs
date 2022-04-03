using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        
        //(DateTime)s = DateTime.NextFormat
        
        //DateTime NextFormat;
        
        //A szukseges (convert) formatum (egy) kodja: "HH:mm:ss"
        
        //DateTime NextFormat = Convert.ToDateTime(s);
        //Elso opcionalis megoldas
                                            
        //string s = NextFormat.ToString("HH:mm:ss")
        //Masodik opcionalis megoldas
        
        //DateTime NextFormat = DateTime.Parse(s);
        //Harmadik opcionalis megoldas
        
        //string s = NextFormat.ToString("HH:mm:ss");
        //Nem lehet megegyszer felhasznalni "s"-t ...
        
        //Logikai lepesek:
        //0. s string konvertacioja datetimera
        //Hasznalhato (osszeegyeztetheto) legyenek a tipusok
        
        //1. DateTime NextFormat = Az atkonvertalt s stringgel (es ertekevel!) (?)
        //Ertek "egyeztetes". -> Egy atalakitando idorol van szo.
        
        //2. printing,(?) Console.Write(NextFormat.ToString("HH:mm:ss"));
        //Kiiras es 24 oras formatum alakitas.
        
        //Convert.ToDateTime(s);
        
        //DateTime NextFormat = DateTime.ParseExact(s, "hh:mm:ss tt");
        //Fos
        
            DateTime NextFormat = DateTime.ParseExact(s,  "hh:mm:sstt",      
            CultureInfo.CurrentCulture);
        
        //DateTime NextFormat = Convert.ToDateTime("HH:mm:ss");
        //s = NextFormat.ToString("HH:mm:ss");
        //DateTime NewNextFormat = Convert.ToDateTime(s);
        
        //A szopas  fo targya: Solution.cs(43,16): error CS0029: Cannot implicitly convert type `System.DateTime' to `string'
        
        
        return NextFormat.ToString("HH:mm:ss");      
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
