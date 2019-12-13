using Grpc.Core;
using ProtoBuf.Grpc.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Shared
{
    public class Client
    {
        private Channel Channel { get; set; }
        public Client(Channel channel)
        {
            Channel = channel;
        }

        public List<User> GetUsers()
        {
            var service = Channel.CreateGrpcService<IUser>();
            var result = service.GetUsers(new QueryRequest()
            {
                WhereClause = "1 = 1"
            });
            return result;
        }
    }
}
