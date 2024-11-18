namespace OnlineCourse.UI.Helper
{
    public static class HttpClientİnstansHelper
    {
        public static HttpClient Client()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7176/api");
            return client;
        }
    }
}
