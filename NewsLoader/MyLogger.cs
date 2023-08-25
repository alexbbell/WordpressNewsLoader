using NLog;

namespace NewsLoader
{
    public class MyLogger
    {
        public ILogger Logger { get; set; }
        public MyLogger()
        {
            Logger = LogManager.Setup()
              .GetCurrentClassLogger();
        }

    }
}
