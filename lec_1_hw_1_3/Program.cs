using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec_1_hw_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите целое число (от {0} до {1}):", ushort.MinValue, ushort.MaxValue);
                ushort num = Convert.ToUInt16(Console.ReadLine());
                const ushort mask = 1;
                int size = sizeof(ushort) * 8;
                Console.WriteLine("Число после обнуления последнего бита = {0}", num & ~(mask << (size - 1)));
            }
            catch(FormatException)
            {
                Console.WriteLine("Введено не целое число (либо превышен диапазон)!!!");
            }
        }
    }
}
