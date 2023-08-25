using Microsoft.Extensions.Configuration;
using System.IO;
namespace NewsLoader
{
    public class FileSaver
    {
        private readonly MyLogger _myLogger;
        private readonly IConfiguration _configuration;

        public FileSaver(MyLogger myLogger, IConfiguration configuration)
        {
            _myLogger = myLogger;
            _configuration = configuration;
        }
        public Task SaveNewsFile(string data)
        {
            try
            {
                string filePath = _configuration.GetSection("newsStorage").Value;
                File.WriteAllText(path: filePath, data);
                _myLogger.Logger.Info($"file is updated");
            }
            catch (Exception ex)
            {
                _myLogger.Logger.Error($"Error! {ex.Message.ToString()}");
            }
            return Task.CompletedTask;

        }

    }
}
