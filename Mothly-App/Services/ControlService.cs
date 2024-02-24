namespace Mothly_App.Services
{
    public interface IControlService
    {
        IList<string> Messages { get; }
        IList<string> GetChatMessages();
        Task<IList<string>> GetChatMessagesAsync();
        void AddMessage(string sender, string message);
    }

    public class ControlService : IControlService
    {
        private IList<string> _chatMessages;

        public IList<string> Messages
        {
            get { return _chatMessages; }
        }

        public IList<string> GetChatMessages()
        {
            return _chatMessages;
        }

        public Task<IList<string>> GetChatMessagesAsync() => Task.FromResult(_chatMessages);

        public void AddMessage(string sender, string message)
        {
            var encodedMsg = $"{sender}: {message}";
            Messages.Insert(0, encodedMsg);
        }

        public ControlService()
        {
            _chatMessages = new List<string>();
        }
    }
}
