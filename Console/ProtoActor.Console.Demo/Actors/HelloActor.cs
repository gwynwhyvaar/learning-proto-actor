using Proto;
using ProtoActor.Console.Demo.Messages;
using System;
using System.Threading.Tasks;
namespace ProtoActor.Console.Demo.Actors
{
    public class HelloActor : IActor
    {
        public Task ReceiveAsync(IContext context)
        {
            var msg = context.Message;
            if (msg is Hello hi)
            {
                System.Console.WriteLine($"<{System.Environment.UserName}@{System.Environment.MachineName}>\nTo: {hi.Who}\nMessage: {hi.MessageText}\nDate: {DateTime.Now}");
            }
            return Actor.Done;
        }
    }
}
