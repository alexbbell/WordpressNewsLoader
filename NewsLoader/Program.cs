// See https://aka.ms/new-console-template for more information
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewsLoader;
using NewsLoader.Models;

Console.WriteLine("Hello, World!");

var configuration = new ConfigurationBuilder()
     .AddJsonFile($"appsettings.json");
var config = configuration.Build();


var serviceProvider = new ServiceCollection()
      .AddSingleton<FileSaver>()
      .AddScoped<MyLogger>()
      .AddSingleton<IConfiguration>(config)
      .AddScoped<ApiReader>()
      .AddAutoMapper(typeof(NewsformatProfile))
      .BuildServiceProvider();


var apiReader = serviceProvider.GetRequiredService <ApiReader>();
List<MimStoreDto> siteNews = apiReader.GetStores();



if (siteNews.Count > 0)
{
    var myService = serviceProvider.GetRequiredService<FileSaver>();

    string text = Newtonsoft.Json.JsonConvert.SerializeObject(siteNews, Newtonsoft.Json.Formatting.Indented);
    _ = myService.SaveNewsFile(text);

}

Console.WriteLine(siteNews);