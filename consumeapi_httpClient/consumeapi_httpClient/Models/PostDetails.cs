namespace consumeAPI_httpclient.Models
{
    public class PostDetails
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        List<PostDetails> pList = new List<PostDetails>();

        public List<PostDetails> GetPostData()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear(); //clear the browser tab setting
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string url = "https://jsonplaceholder.typicode.com/posts";

            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsAsync<List<PostDetails>>();
                data.Wait();
                pList = data.Result;
                return pList;

            }
            else
            {
                throw new Exception("Could not get data from server, please contact Admin");
            }

        }
    }
}