using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DAL.Shared
{
    [DataContract]
    public class QueryRequest
    {
        [DataMember(Order = 1)]
        public string WhereClause { get; set; }
        [DataMember(Order = 2)]
        public object Parameters { get; set; }
        [DataMember(Order = 3)]
        public string OrderBy { get; set; }
        [DataMember(Order = 4)]
        public int? Limit { get; set; }
    }

    [DataContract]
    public class SelectResponse<T>
    {
        [DataMember(Order = 1)]
        public List<T> Rows { get; set; }
        [DataMember(Order = 2)]
        public string Error { get; set; }
    }
}
