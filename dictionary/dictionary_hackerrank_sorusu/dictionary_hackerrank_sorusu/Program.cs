using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var n = int.Parse(Console.ReadLine());
        Dictionary<string, int> telefonRehberi = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {
            var giris = Console.ReadLine().Split(' ');
            var isim = giris[0];
            var numara = int.Parse(giris[1]);
            telefonRehberi.Add(isim, numara);
        }
        for (int i = 0; i < n; i++)
        {
            var isim = Console.ReadLine();
            if (telefonRehberi.ContainsKey(isim))
            {
                int numara = telefonRehberi[isim];
                Console.WriteLine(isim + "=" + numara);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

    }
}