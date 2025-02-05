# Wordpress NewsLoader 

## Summary

The console utility to load the previews of the last news from the Wordpress sites. It makes requests to a WordPress site and saves the data in the JSON file. 

It's good to use if you want to show the previews of the news on external site or if you just want to decrease the quantity of the API or DB Requests.

You can easily load the full content of the posts from WordPress site

The example of the result JSON
```json
  [
    {
    "id": 1232,
    "date": "2023-08-21T08:17:39",
    "status": "publish",
    "title": "C# method to create a UNC directory recursively and return the path",
    "excerpt": "<p>I will write down the useful method. I used it several times and it works good. It&#8217;s C# method to create a UNC directory recursively and return the path.</p>\n"
  }
  ]
```

in the 'datasource.json' file you can set multiple resources for downloading the content and filenames to store the data respectively.
```json
 [
    {
      "Url": "https://markimarta.com/wp-json/wp/v2/posts",
      "StorePath": "c:\\Temp\\mimnews.json"
    },
    {
      "Url": "https://markimarta.ru/wp-json/wp/v2/posts",
      "StorePath": "c:\\Temp\\mimrunews.json"
    }
  ]
```


## Prerequisites
- AutoMapper 13.0.1
- Microsoft.NETCore.App 8
- Microsoft.Extensions.Configuration 9.0.1
- Microsoft.Extensions.Configuration.Json 9.0.1
- Microsoft.Extensions.DependencyInjection 9.0.1
- NLog 5.5.0
- Newtonsoft.Json 13.0.3
- RestSharp 112.1.0


## Solution

| Solution    | Author(s)                                                     |
| ----------- | ------------------------------------------------------------- |
| NewsLoader  | Aleksei Beliaev, https://www.linkedin.com/in/aleksei-beliaev/ |



## Version history

| Version | Date                | Comments          |
| ------- | ------------------- | ----------------- |
| 1.2.3   | Februar 05, 2025    | build for net 8, updated dependencies   |
| 1.2.2   | September 14, 2023  | Full Url added    |
| 1.2.1   | September 11, 2023  | Dev / prod config |
| 1.2     | August 29, 2023     | Multiple load     |
| 1.1     | August 28, 2023     | JSON simplified   |
| 1.0     | August 25, 2023     | Initial release   |


## Minimal Path to Awesome

- Clone this repository
- Ensure that you are at the solution folder
- update the values in 'appsettings.json' - remote url and where to store text data
- update the log-file location in nlog.config
- compile and execute

