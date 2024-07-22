using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reckonwrit_drill.async
{
    /// <summary>
    /// This class intent is to explore and understand async programming.
    /// </summary>
    internal class TaskDelaying
    {
        private Stopwatch stopwatch;

        public TaskDelaying() => stopwatch = new Stopwatch();
        public async Task Perform()
        {
            stopwatch.Start();

            var delayedTask = DelayedMessage(stopwatch);

            await AsyncSecondMessage(stopwatch);

            await delayedTask;
        }
        public static async Task DelayedMessage(Stopwatch stopwatch)
        {
            Console.WriteLine($"Task 1: I work slow... ({stopwatch.ElapsedMilliseconds} ms)");
            await Task.Delay(new Random().Next(1000, 6000));
            Console.WriteLine($"Task 1: Done! ({stopwatch.ElapsedMilliseconds} ms)");

        }
        public static async Task AsyncSecondMessage(Stopwatch stopwatch)
        {

            Console.WriteLine($"Task 2: I work fast! ({stopwatch.ElapsedMilliseconds} ms)");
            await Task.Delay(1);
            Console.WriteLine($"Task 2: Done! ({stopwatch.ElapsedMilliseconds} ms)");
        }

    }
}
