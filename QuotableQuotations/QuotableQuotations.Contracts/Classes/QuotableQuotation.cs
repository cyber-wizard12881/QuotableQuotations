using System.Runtime.Serialization;

namespace QuotableQuotations.Contracts.Classes
{
    [DataContract]
    public class QuotableQuotation
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string Quote { get; set; }
    }
}
