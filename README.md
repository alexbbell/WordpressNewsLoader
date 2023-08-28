# Wordpress NewsLoader 

## Summary

Console utility to load the previews of the last news from the Wordpress sites. It makes requests to a WordPress site and saves the data in the JSON file. 

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

## Prerequisites
- AutoMapper 12.0.1
- AutoMapper.Extensions.Microsoft.DependencyInjection 12.0.1
- Microsoft.NETCore.App 6.0.16
- Microsoft.Extensions.Configuration 7.0.0
- Microsoft.Extensions.Configuration.Json 7.0.0
- Microsoft.Extensions.DependencyInjection 7.0.0
- NLog 5.2.3
- Newtonsoft.Json 13.0.3
- RestSharp 110.2.0


## Solution

| Solution    | Author(s)                                                     |
| ----------- | ------------------------------------------------------------- |
| NewsLoader  | Aleksei Beliaev, https://www.linkedin.com/in/aleksei-beliaev/ |



## Version history

| Version | Date             | Comments        |
| ------- | ---------------- | --------------- |
| 1.1     | August 28, 2023  | JSON simplified |
| 1.0     | August 25, 2023  | Initial release |


## Minimal Path to Awesome

- Clone this repository
- Ensure that you are at the solution folder
- update the values in 'appsettings.json' - remote url and where to store text data
- update the log-file location in nlog.config
- compile and execute

