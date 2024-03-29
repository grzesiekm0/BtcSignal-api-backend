﻿using BtcSignal.Api.Sheduler.Jobs;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerDemoService.JobFactory
{
    class MyJobFactory : IJobFactory
    {
        private readonly IServiceProvider service;
        public MyJobFactory(IServiceProvider serviceProvider)
        {
            service = serviceProvider;
        }
        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
           /* var jobDetail = bundle.JobDetail;
            return (IJob)service.GetService(jobDetail.JobType);*/

            return service.GetRequiredService<QuartzJobRunner>();
        }

        public void ReturnJob(IJob job)
        {
            
        }
    }
}
