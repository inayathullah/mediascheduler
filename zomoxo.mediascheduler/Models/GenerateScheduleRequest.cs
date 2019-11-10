using System;
using System.Collections.Generic;

namespace zomoxo.mediascheduler.Models
{
    /// <summary>
    /// Schedule Request Payload
    /// </summary>
    public class GenerateScheduleRequest
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public IList<Media> Medias { get; set; }
    }
}