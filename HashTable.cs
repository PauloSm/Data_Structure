using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_File
{
    class HashTable
    {
        public int HashFunc(string s, string[] arr)
        {
            long tot = 0;
            char[] cname;
            cname = s.ToCharArray();
            for (int i = 0; i <= cname.GetUpperBound(0); i++)
                tot += 37 * tot + (int)cname[i];
            tot = tot % arr.GetUpperBound(0);
            if (tot < 0)
                tot += arr.GetUpperBound(0);
            return (int)tot;
        }

        public bool InHash(string s, string[] arr)
        {
            int hval = HashFunc(s, arr);
            if (arr[hval] == s)
                return true;
            else
                return false;
        }



        public void Display(string[] arr)
        {
            for(int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                if (arr[i] != null)
                    Console.WriteLine(i + " " + arr[i]);
            }
        }
    }
}
