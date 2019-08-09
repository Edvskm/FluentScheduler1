using System;
using FluentScheduler;

namespace FluentScheduler3.SchedulerJob
{
    public class ScheduledJobRegistry : Registry
    {
        public ScheduledJobRegistry()
        {
            Schedule<MyJob>()
                .NonReentrant() // Only one instance of the job can run at a time
                .ToRunOnceAt(DateTime.Now.AddSeconds(1)) // Delay startup for a while
                .AndEvery(2).Seconds(); // Interval
            //.ToRunOnceIn(3);
            //.ToRunEvery(1).Days().At(10, 10); // run every day at 10:10
            //.ToRunNow().AndEvery(1).Months().OnTheFirst(DayOfWeek.Monday).At(3, 0);

            // Schedule multiple jobs to be run in a single schedule
            //Schedule<MyJob>().AndThen<MyOtherJob>().ToRunNow().AndEvery(5).Minutes();
        }
    }
}
