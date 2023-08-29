namespace NewsLoader
{
    public class FileSaver
    {
        private readonly MyLogger _myLogger;
        public FileSaver(MyLogger myLogger)
        {
            _myLogger = myLogger;
        }
        public Task SaveNewsFile(string filePath, string data)
        {
            try
            {
                File.WriteAllText(filePath, data);
                _myLogger.Logger.Info($"file '{filePath}' is updated");
            }
            catch (Exception ex)
            {
                _myLogger.Logger.Error($"Error! {ex.Message.ToString()}");
            }
            return Task.CompletedTask;

        }

    }
}
