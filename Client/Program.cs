using Grpc.Core;
using System;

namespace DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new Channel("127.0.0.1:9000", ChannelCredentials.Insecure);
            var services = new Shared.Client(channel);
            var result = services.GetUsers();
        }
    }
}
