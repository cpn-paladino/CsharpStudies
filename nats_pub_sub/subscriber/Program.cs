using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NATS.Client;

namespace subscriber
{
    class Program
    {
        
        private static string ParserByteStr(byte[] message)
        {
            return Encoding.UTF8.GetString(message);
        }


        private static void SubscribeMsgs()
        {
            var opts = ConnectionFactory.GetDefaultOptions();

            using IEncodedConnection connection = new ConnectionFactory().CreateEncodedConnection(opts);
            connection.OnDeserialize = ParserByteStr;
            var response = "teste1";

            EventHandler<EncodedMessageEventArgs> newMessageEvent = (sender, args) =>
            {   
                args.Message.Ack();             
                string receivedMsg = (string)args.ReceivedObject;
                Console.WriteLine($"Received {receivedMsg}");                
                Console.WriteLine(args.Message.Reply);                
                
                args.Message.Respond(Encoding.UTF8.GetBytes(response));
                Task.Delay(-1).Wait();
                
            };
                
            
            using (IAsyncSubscription subscribe = connection.SubscribeAsync("pub.news.sports","load-balancing-queue",newMessageEvent))
            {

                Console.WriteLine("Waiting messages...");
                while (true){

                }
             

            }
        }        


        static void Main(string[] args)
        {
            Console.WriteLine("Subscriber");
            SubscribeMsgs();
        }
    }


}
