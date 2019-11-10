using System;
using Newtonsoft.Json;
using zomoxo.mediascheduler.Models;
using zomoxo.mediascheduler.Repository;

namespace zomoxo.mediascheduler
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //Read input from user
                //1. fromDate yyyy-MM-dd HH:mm:ss (2019-10-01 10:00:00)
                //2. toDate yyyy-MM-dd HH:mm:ss (2019-10-01 10:30:00)
                
                var mediaRepository = new MediaRepository();
                
                //Create request object based on the above user use Media.json from Media folder
                //Create media object 
                var request = new GenerateScheduleRequest();
                
                //Generate schedule
                var schedule = mediaRepository.GenerateSchedule(new GenerateScheduleRequest());

                //Write schedule as plain text file
                var parsedSchedule = JsonConvert.SerializeObject(schedule);
                var fileName = $"generatedschedule-{request.FromDate}";
                System.IO.File.WriteAllText($@"c:\temp\{fileName}.txt", parsedSchedule);
                Console.WriteLine("Schedule Generated Successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong {e}");
            }

            Console.ReadKey();
        }
    }
}