using System;
using System.Collections;
using System.Collections.Generic;
using zomoxo.mediascheduler.Models;

namespace zomoxo.mediascheduler.Repository
{
    public interface IMediaRepository
    {
        /// <summary>
        /// Generate Schedule
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Generated Schedule Response</returns>
        GeneratedScheduleResponse GenerateSchedule(GenerateScheduleRequest request);
    }
}