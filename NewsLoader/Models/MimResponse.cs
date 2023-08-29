namespace NewsLoader.Models
{
    public class MimResponse
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string? status { get; set; }
        public Title? title { get; set; }
        public Title? excerpt { get; set; }
    }

    public class Title
    {
        public string? rendered { get; set; }
    }


    public class MimStoreDto
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string? status { get; set; }
        public string? title { get; set; }
        public string? excerpt { get; set; }


    }

}
