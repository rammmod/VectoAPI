namespace VectoAPI.Models
{
    public class ProcessImageRequest
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public ICollection<ProcessingOperations> Operations { get; set; }
    }

    public class ProcessingOperations
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
