using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinElemeOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var oRnd = new Random();
            Console.WriteLine("Input a count of elements:");
            int.TryParse(Console.ReadLine(), out var nElems);
            if (nElems == 0)
            {
                Console.WriteLine("Empty arrays not allowed");
                Console.Read();
                return;
            }
            Console.WriteLine($"Generating array by filling {nElems}:");
            int[] iNumbers = new int[nElems];
            for (int i = 0; i < nElems; i++)
            {
                iNumbers[i] = oRnd.Next(1, 100);
                Console.Write(iNumbers[i] + " ");
            }
            var iMin = iNumbers[0];
            var nIndex = 0;
            for (int i = 1; i < nElems; i++)
            {
                if (iNumbers[i] < iMin)
                {
                    iMin = iNumbers[i];
                    nIndex = i;
                }
            }
            Console.WriteLine($"\r\nFound minimum element:{iMin} with index {nIndex}");
            Console.Read();
        }
    }
}
