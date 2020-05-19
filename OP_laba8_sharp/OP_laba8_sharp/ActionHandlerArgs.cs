namespace OP_laba8_sharp
{
    public class ActionHandlerArgs
    {
        private string _message;
        private object _sender;
        
        public string Message => _message;
        public object Sender => _sender;

        public ActionHandlerArgs(string message, object sender)
        {
            _message = message;
            _sender = sender;
        }        
    }
}