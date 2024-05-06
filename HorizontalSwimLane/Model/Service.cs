namespace HorizontalSwimLane.Model
{
    public class Service
    {
        public int Id { get; set; }
        public string TraceId { get; set; }
        public string ServiceName { get; set; }
        public string? ActionName { get; set; }
        public string? Protocol { get; set; }
        public string? Message { get; set; }
        public string Level { get; set; }
        public float? ElapsedTime { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
