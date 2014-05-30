using System;
using System.Threading.Tasks;

namespace EnumWithNoValue2
{
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            const EnumWithNoValue Hede = (EnumWithNoValue)129;
            Console.WriteLine(Hede);
            Console.WriteLine(Hede.ToString());
            Console.WriteLine(Hede.GetType());
            Task.Delay(2000);
        }
    }
}
