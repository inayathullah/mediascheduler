using System;

namespace zomoxo.mediascheduler.Models
{
    /// <summary>
    /// Schedule Media Details
    /// </summary>
    public class ScheduledMedia
    {
        public string MediaName { get; set; }
        public int Duration { get; set; }
        public DateTime ScheduledTime { get; set; }
    }
}