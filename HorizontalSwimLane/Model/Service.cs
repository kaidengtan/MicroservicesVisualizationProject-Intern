namespace HorizontalSwimLane.Model
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Name { get; set; }
        public string Protocol { get; set; }
        public string Action { get; set; }
        public string ElapsedTime { get; set; }
    }
}
