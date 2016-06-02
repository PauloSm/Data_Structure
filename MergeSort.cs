using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeAlgo
{
    class MergeSort
    {
        public int Merge(int[] Ray)
        {
            int number = Ray.Length;
            if (number < 2)
                return -1; 
            int mid = number / 2;

            int[] left_side = new int[mid];
            int[] right_side = new int[number - mid];

            for (int i = 0; i < left_side.Length; i++)
            {
                left_side[i] = Ray[i];
            }

            int j = 0;
            for (int i = mid; i < Ray.Length; i++)
            {
                right_side[j] = Ray[i];
                j++;
            }
            

            Merge(left_side);
            Merge(right_side);
            Sort(Ray, left_side, right_side);
            return 1;

        }

        public void Sort(int[] main, int[] left, int[] right)
        {
            int l = 0;
            int r = 0;
            int i = 0;

            while (l < left.Length && r < right.Length)
            {
                if (left[l] < right[r])
                {
                    main[i] = left[l];
                    l++;
                }

                else
                {
                    main[i] = right[r];
                    r++;
                }
                i++;
            }
            /*for (int i = 0; i < main.Length; i++)
            {
                if (left[l] < right[r] && l < left.Length)
                {
                    main[i] = left[l];
                    l++;
                }
                else if (r < right.Length)
                {
                    main[i] = right[r];
                    r++;
                }
            }*/
        }
    }
}
