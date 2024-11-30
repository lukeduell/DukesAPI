using static DukesAPI.Models.NewsModel;

namespace DukesAPI.Models
{
    public class NewsModel
    {
        public string Headline { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public DateTime PublishedDate { get; set; }
    }
    public class NewsResponse
    {
        public List<NewsModel> News { get; set; }
    }
}
