namespace CallSameMethodInsideTheMethod
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    class Program
    {
        private static int count = 0;
        static void Main(string[] args)
        {
            //Hede();
            Execute();
            Console.ReadKey();
        }

        //Creates StackOverflow
        private static void Hede()
        {
            Console.WriteLine(count++);
            Hede();
        }

        public static void Execute()
        {
            Console.WriteLine(count++);

            SetTimer();
        }

        private static void SetTimer()
        {
            var timer = new System.Timers.Timer { Interval = 10.0  };
            timer.Elapsed += (s, o) =>
            {
                timer.Enabled = false;
                timer.Dispose();
                Execute();
            };

            timer.Enabled = true;
            timer.Start();
        }
    }
}
