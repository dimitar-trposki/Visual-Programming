using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV2_DebugConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            try
            {
                int element = array[7];
                Console.WriteLine(element);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}
