namespace NewsLoader.Models
{
    public class MimResponse
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Status { get; set; }
        public Title? Title { get; set; }
        public Title? Excerpt { get; set; }
        public string? Link { get; set; }
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
        public string? link { get; set; }

    }

}
