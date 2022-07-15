namespace Twenty2.Schedule.Api.Entities
{ 
    public class Work
    {
        public long Id { get; set; }

        public TimeSpan AssuredCompletion { get; set; }

        public TimeSpan CalculatedCompletion { get; set; }
    }
}

