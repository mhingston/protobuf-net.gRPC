using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace DAL.Shared
{
    [ServiceContract]
    public interface IUser
    {
        List<User> GetUsers(QueryRequest request);
    }

    [Table("Users")]
    [DataContract]
    public class User
    {
        [Key]
        [DataMember(Order = 1)]
        public int UserID { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
    }

    public class UserService : IUser
    {
        List<User> IUser.GetUsers(QueryRequest request)
        {
            return new List<User>()
            {
                new User(){ UserID = 1, Name = "Joe Bloggs"}
            };
        }
    }
}
