using AutoMapper;
using NewsLoader.Models;
using RestSharp;

namespace NewsLoader
{
    public class ApiReader
    {
        private readonly IMapper _mapper;
        public ApiReader(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<List<MimResponse>> GetNews(string remoteUrl)
        {
            var client = new RestClient();
            var request = new RestRequest(remoteUrl, Method.Get);
            request.AddParameter("page", 1);
            request.AddParameter("per_page", 10);
            request.AddParameter("order", "desc");
            return await client.GetAsync<List<MimResponse>>(request);
        }

        public List<MimStoreDto> GetStores(string remoteUrl)
        {
            var mimStores = _mapper.Map<IEnumerable<MimResponse>, IEnumerable<MimStoreDto>>(GetNews(remoteUrl).Result).ToList();
            return mimStores;

        }


    }
}
