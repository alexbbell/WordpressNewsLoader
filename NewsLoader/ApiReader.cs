
using NewsLoader.Models;
using RestSharp;

namespace NewsLoader
{
    public class ApiReader
    {

        
        public async Task<List<MimResponse>> GetNews(string remoteUrl)
        {
            var client = new RestClient();
            var request = new RestRequest(remoteUrl, Method.Get);
            request.AddParameter("page", 1);
            request.AddParameter("per_page", 10);
            request.AddParameter("order", "desc");
            return await client.GetAsync<List<MimResponse>>(request);
        }

        public async Task<List<MimStoreDto>> GetStores(string remoteUrl)
        {
            //var mimStores = _mapper.Map<IEnumerable<MimResponse>, IEnumerable<MimStoreDto>>(GetNews(remoteUrl).Result).ToList();

            var data = await GetNews(remoteUrl);
            var dataList = data.ToList();
            var mimStores = new List<MimStoreDto>();

            dataList.ForEach(x =>
            {
                mimStores.Add( new MimStoreDto()
                {
                    date = x.Date,
                    excerpt = x.Excerpt.rendered,
                    id = x.Id,
                    link = x.Link,
                    status = x.Status,
                    title = x.Title.rendered
                });
            });


            return mimStores;

        }


    }
}
