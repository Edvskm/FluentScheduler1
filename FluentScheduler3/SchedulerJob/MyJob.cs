using System;
using FluentScheduler;

namespace FluentScheduler3.SchedulerJob
{
    public class MyJob : IJob
    {
        public void Execute()
        {
            // Execute your scheduled task here
            Console.WriteLine("the Job time is {0:HH:mm:ss}", DateTime.Now);
        }
    }
}
