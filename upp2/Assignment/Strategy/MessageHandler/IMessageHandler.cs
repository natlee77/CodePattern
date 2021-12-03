namespace Design_Patterns_Assignment.Strategy 
{
    internal interface IMessageHandler
    {      
        public ISend SendText { get; set; }
        public void SendMessage(string message);
    }
}