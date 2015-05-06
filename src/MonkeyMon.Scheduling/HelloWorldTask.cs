using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonkeyMon.Gathering;
using Quartz;
using Quartz.Impl;

namespace MonkeyMon.Scheduling
{
    public class HelloWorldTask
    {
        public string DoHelloWorld()
        {
            // construct a scheduler factory
            ISchedulerFactory schedFact = new StdSchedulerFactory();

            // get a scheduler
            IScheduler sched = schedFact.GetScheduler();
            sched.Start();

            // define the job and tie it to our HelloJob class
            IJobDetail job = JobBuilder.Create<HelloJob>()
                .WithIdentity("myJob", "group1")
                .Build();

            // Trigger the job to run now, and then every 40 seconds
            ITrigger trigger = TriggerBuilder.Create()
              .WithIdentity("myTrigger", "group1")
              .StartNow()
              .WithSimpleSchedule(x => x
                  .WithIntervalInSeconds(5)
                  .RepeatForever())
              .Build();

            sched.ScheduleJob(job, trigger);
            return "NOOOOO, they're all gonna laugh at you!";
        }
    }

    public class HelloJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Gatherer.Store("NOOOOOOOOOOOOOOOOOOOOOOOOOOO");
        }
    }
}
