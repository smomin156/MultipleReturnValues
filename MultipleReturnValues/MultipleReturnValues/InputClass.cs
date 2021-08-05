using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleReturnValues
{
    static class InputClass
    {
        //using out 
        public static void FindMinMax1(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];
            foreach (int count in arr)
            {
                if (count <= min)
                {
                    min = count;
                }
                if (count >= max)
                {
                    max = count;
                }
            }

        }
        //using ref
        public static void FindMinMax2(int[] arr, ref int min, ref int max)
        {
            
            foreach (int count in arr)
            {
                if (count <= min)
                {
                    min = count;
                }
                if (count >= max)
                {
                    max = count;
                }
            }

        }

        //using array
        public static int[] FindMinMax3(int[] arr)
        {
            int[] minMax=new int[2];
            minMax[0] = arr[0];
            minMax[1] = arr[1];
            foreach (int count in arr)
            {
                if (count <=minMax[0])
                {
                    minMax[0] = count;
                }
                if (count >= minMax[1])
                {
                    minMax[1] = count;
                }
            }
            return minMax;
        }
        //returning struct
        
        public static MinMax FindMinMax4(int[] arr)
        {
            MinMax value = new MinMax();
            value.min = arr[0];
            value.max = arr[1];
            foreach (int count in arr)
            {
                if (count <= value.min)
                {
                    value.min = count;
                }
                if (count >= value.max)
                {
                    value.max = count;
                }
            }
            return value;
        }
        //using tuple
        public static Tuple<int,int> FindMaxMin5(int[] arr)
        {
            int min = arr[0];
            int max = arr[1];
            foreach (int count in arr)
            {
                if (count <=min)
                {
                    min = count;
                }
                if (count >= max)
                {
                    max = count;
                }
            }
            return new Tuple<int, int>(min,max);
        }
        //using object as return
        public static MinMax1 FindMinMax6(int[] arr)
        {
            MinMax1 value = new MinMax1();
            value.Min = arr[0];
            value.Max = arr[1];
            foreach (int count in arr)
            {
                if (count <= value.Min)
                {
                    value.Min = count;
                }
                if (count >= value.Max)
                {
                    value.Max = count;
                }
            }
            return value;
        }

    }
    public struct MinMax
    {
        public int min;
        public int max;
    }

    public class MinMax1
    {
        int min;
        int max;
        public int Min { get { return min; } set { min = value; } }
        public int Max { get { return max; } set {max=value; } }
    }
}
