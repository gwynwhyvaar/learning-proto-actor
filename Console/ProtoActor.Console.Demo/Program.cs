using Proto;
using ProtoActor.Console.Demo.Actors;
using ProtoActor.Console.Demo.Messages;
using System;
namespace ProtoActor.Console.Demo
{
    class Program
    {
        static Props Props;
        static ActorSystem ActorSystem;
        static void Init()
        {
            ActorSystem = new ActorSystem();
            Props = Props.FromProducer(() => new HelloActor());
        }
        static void Main(string[] args)
        {
            // remember to call our init()
            Init();
            // todo: use this as a parameter to the Message Immutable class
            var userName = $"<{Environment.UserDomainName}>";
            System.Console.WriteLine($"Hello! {userName}, please press ENTER to start your session!");
            System.Console.ReadLine();
            System.Console.WriteLine("Enter a Message to Send: ");
            var message = System.Console.ReadLine();
            System.Console.WriteLine("Enter recipients (**TIP: seperate email addresses with ',' to send to multiple users): ");
            var emailAddresses = System.Console.ReadLine();
            // we start the magic here
            var id = ActorSystem.Root.Spawn(Props);
            ActorSystem.Root.Send(id, new Hello(emailAddresses,
                message));
            System.Console.ReadLine();
        }
    }
}
