namespace GeradoresDeMassa.Models
{
    public class GeradorRetorno
    {
        public string type { get; set; }
        public int limit { get; set; }
        public List<string> values { get; set; }

    }
}