namespace consumeAPI_httpclient.Models
{
    public class Post
    {
        public int UserId { get; set; }
        public int id { get; set; }
        public int title { get; set; }

      

        List<Post> pList = new List<Post>();

        public List<Post> GetPostData()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear(); //clear the browser tab setting
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string url = "https://jsonplaceholder.typicode.com/albums";

            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsAsync<List<Post>>();
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