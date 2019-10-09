namespace Forum.Services.DataTransferObjects.Post
{
    public class PostListDTO
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string UserCreator { get; set; }
        public double AvgRating { get; set; }
    }
}