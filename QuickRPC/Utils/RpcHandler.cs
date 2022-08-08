namespace QuickRPC.Utils
{
    public sealed class RpcHandler
    {
        public DiscordRpcClient rpcClient;
        private string _clientId;
        public string? logText;
        private bool? _logSuccess;
        private ConsoleLogger _logger;

        static RpcHandler() { }

        private RpcHandler()
        {

        }

        public static RpcHandler Instance { get; } = new RpcHandler();

        public void Initialise(string givenClientId)
        {
            _clientId = givenClientId ?? string.Empty;
            rpcClient = new DiscordRpcClient(_clientId);
            _logger = new ConsoleLogger() { Level = DiscordRPC.Logging.LogLevel.Warning };
            rpcClient.Logger = _logger;
            rpcClient.Initialize();
        }

        public Task StartPresence(string clientId, RichPresence presence)
        {
            Initialise(clientId);
            if (rpcClient.IsDisposed)
                return Log("Parameters met... Client Starting");

            rpcClient.SetPresence(presence);
            return Log("Client Started");
        }


        public Task Log(object content)
        {
            var log = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            var convertedContent = content.ToString();
            log.Information(convertedContent);
            _logSuccess = true;

            return Task.CompletedTask;
        }

        public Task PausePresence()
        {
            rpcClient.ClearPresence();
            return Log("Presence Cleared");
            
        }
        public Task EndPresence()
        {
            rpcClient.Dispose();
            return Log("Presence Cleared and Client Disposed");
        }

    }
}
