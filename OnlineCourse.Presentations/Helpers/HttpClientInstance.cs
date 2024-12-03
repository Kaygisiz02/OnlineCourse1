namespace OnlineCourse.Presentations
{
    public static class HttpClientInstance
    {
        public static HttpClient CreateClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7176/api/");
            return client;
        }
    }
}
