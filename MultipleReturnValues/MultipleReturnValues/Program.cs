using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleReturnValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 40, 30, 5 };
            int min1,max1;
            //using out
            InputClass.FindMinMax1(arr,out min1,out max1);
            Console.WriteLine("---Min value:{0}  Max value:{1}---Using out", min1, max1);

            //using ref
            int min2 = arr[0];
            int max2 = arr[0];
            InputClass.FindMinMax2(arr, ref min2, ref max2);
            Console.WriteLine("---Min value:{0}  Max value:{1}---Using ref", min2, max2);

            //using array
            int[] minMax=InputClass.FindMinMax3(arr);
            Console.WriteLine("---Min value:{0}  Max value:{1}---using array", minMax[0], minMax[1]);

            //using struct
            MinMax value = InputClass.FindMinMax4(arr);
            Console.WriteLine("---Min value:{0}  Max value:{1}---using struct", value.min, value.max);

            //using tuple
            var tupVar = InputClass.FindMaxMin5(arr);
            Console.WriteLine("---Min value:{0}  Max value:{1}---using tuple", tupVar.Item1,tupVar.Item2 );
            
            //using object
            MinMax1 obj = InputClass.FindMinMax6(arr);
            Console.WriteLine("---Min value:{0}  Max value:{1}---using object", obj.Min, obj.Max);
            Console.ReadLine();
        }

    }
}
