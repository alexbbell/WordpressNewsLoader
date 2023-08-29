using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewsLoader;
using NewsLoader.Models;


var configuration = new ConfigurationBuilder()
     //.SetBasePath(Directory.GetCurrentDirectory())
     .AddJsonFile($"appsettings.json");
var config = configuration.Build();
var serviceProvider = new ServiceCollection()
      .AddSingleton<FileSaver>()
      .AddScoped<MyLogger>()
      .AddSingleton<IConfiguration>(config)
      .AddScoped<ApiReader>()
      .AddAutoMapper(typeof(NewsformatProfile))
      .BuildServiceProvider();


Console.WriteLine(config.GetSection("startingText").Value);
var apiReader = serviceProvider.GetRequiredService<ApiReader>();
string jsonFilePath = "datasources.json";
string jsonContent = File.ReadAllText(jsonFilePath);


List<SourceConfig> jsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SourceConfig>>(value: jsonContent);
foreach (var remoteUrl in jsonObject)
{
    List<MimStoreDto> siteNews = apiReader.GetStores(remoteUrl.Url);
    if (siteNews.Count > 0)
    {
        var myService = serviceProvider.GetRequiredService<FileSaver>();
        string text = Newtonsoft.Json.JsonConvert.SerializeObject(siteNews, Newtonsoft.Json.Formatting.Indented);
        _ = myService.SaveNewsFile(remoteUrl.StorePath, text);
    }
}
