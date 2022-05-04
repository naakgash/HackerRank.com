using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        
        int a;
        double b;
        string c;
        
        a = Convert.ToInt32(Console.ReadLine().Trim());
        b = Convert.ToDouble(Console.ReadLine().Trim());
        c = Console.ReadLine();

        Console.WriteLine(i + a);
        Console.WriteLine("{0:F1}", d + b);
        Console.WriteLine(s + c);

    }
}