using System.Net;
using System.Text.Json;

using var client = new WebClient();

var count = client.DownloadString("https://jsonplaceholder.typicode.com/posts");

var posts = JsonSerializer.Deserialize<List<Post>>(count);
{
    PropertyNameCaseInsensitive = true
});


class Post
{
    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public string body { get; set; }
    public override string ToString()
    {
        return base.ToString();
    }
}