using FluentScheduler;
using System;

namespace FluentScheduler3.SchedulerAction
{
    public class ActionRegistry : Registry
    {
        public ActionRegistry()
        {
            Action someMethod = () =>
            {
                Console.WriteLine("the Action time is {0:HH:mm:ss}", DateTime.Now);
            };

            this.Schedule(someMethod).ToRunNow();
        }
    }
}
