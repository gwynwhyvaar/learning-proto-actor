namespace ProtoActor.Console.Demo.Messages
{
    public class Hello
    {
        // todo: modify this to have a from paramter and field
        public Hello (string who, string message)
        {
            this.Who = who;
            this.MessageText = message;
        }
        public string Who { get; private set; }
        public string MessageText { get; private set; }
    }
}
