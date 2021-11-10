using System;
using System.Text;
using System.Threading;
using NATS.Client;

namespace publisher
{
    class Program
    {       

        private static byte[] parserStrBytes(string message)
        {
            return Encoding.UTF8.GetBytes(message);
        }

        private static void publishMsgs()
        {
            var opts = ConnectionFactory.GetDefaultOptions();
            
            ConnectionFactory cf = new ConnectionFactory();
            using (IConnection connection = cf.CreateConnection(opts))
            {
                int defaultWaiting = 100;
                int count = 0;
                while (count < 1000)
                {
                    string message = $"msg pub ex num: {++count}";
                    Console.WriteLine($"I'm publishing {message}");
                    byte[] encoded_message = parserStrBytes(message);
                    connection.Publish(
                        "pub.news.sports",
                        encoded_message);
                    Thread.Sleep(defaultWaiting);
                }
                Console.WriteLine($"I published {count} msgs!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nats Publisher");
            publishMsgs();
        }
    }
}
