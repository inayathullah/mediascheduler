namespace zomoxo.mediascheduler.Models
{
    /// <summary>
    /// Holds media properties
    /// </summary>
    public class Media
    {
        public string MediaName { get; set; }
        public int Duration { get; set; }
        public string NumberOfTimesToPlay { get; set; }
        public int Priority { get; set; }
    }
}