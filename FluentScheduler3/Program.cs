using FluentScheduler;
using FluentScheduler3.SchedulerAction;
using FluentScheduler3.SchedulerJob;
using System;

namespace FluentScheduler3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World at {0:HH:mm:ss}", DateTime.Now);
            // Scheduler Action
            JobManager.Initialize(new ActionRegistry());

            // Scheduler Job
            // Start the scheduler
            JobManager.Initialize(new ScheduledJobRegistry());

            // Wait for something
            Console.ReadLine();

            // Stop the scheduler
            JobManager.StopAndBlock();
        }
    }
}
