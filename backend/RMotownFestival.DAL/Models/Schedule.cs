using System;

namespace RMotownFestival.DAL.Models
{
    public class ScheduleItem
    {
        public int Id { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public Stage Stage { get; set; }
        public int StageId { get; set; }
        public DateTime Time { get; set; }
    }
}
