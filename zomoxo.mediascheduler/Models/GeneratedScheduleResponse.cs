using System.Collections.Generic;

namespace zomoxo.mediascheduler.Models
{
    /// <summary>
    /// Schedule Resource
    /// </summary>
    public class GeneratedScheduleResponse
    {
        public int TotalRequestedDuration { get; set; }
        public int MediaDuration { get; set; }
        public int RemainingDuration { get; set; }
        public IList<ScheduledMedia> ScheduledMedia { get; set; }
    }
}