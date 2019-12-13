using System;
using Grpc.Core;
using ProtoBuf.Grpc.Server;
using DAL.Shared;

namespace DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Grpc.Core.Server()
            {
                Ports = { new ServerPort("127.0.0.1", 9000, ServerCredentials.Insecure) }
            };

            server.Services.AddCodeFirst(new UserService());
            server.Start();
            Console.ReadKey();
        }
    }
}
