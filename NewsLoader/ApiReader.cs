using AutoMapper;
using Microsoft.Extensions.Configuration;
using NewsLoader.Models;
using RestSharp;

namespace NewsLoader
{
    public class ApiReader
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public ApiReader(IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _mapper = mapper;
        }
        public async Task<List<MimResponse>> GetNews()
        {

            string remoteUrl = _configuration.GetSection("remoteUrl").Value;
            var client = new RestClient();
            var request = new RestRequest(remoteUrl, Method.Get);
            request.AddParameter("page", 1);
            request.AddParameter("per_page", 10);
            request.AddParameter("order", "desc");
            return await client.GetAsync<List<MimResponse>>(request);
        }


        public List<MimStoreDto> GetStores()
        {
            var mimStores = _mapper.Map<IEnumerable<MimResponse>, IEnumerable<MimStoreDto>>(GetNews().Result).ToList();
            return mimStores;

        }


    }
}
