using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
  
namespace ambrosia_demeter_api.Models
{
    public class PaymentModel
    {
        [BsonId]
        
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public string ObjectId { get; set; }
        public string personId { get; set; }
        public DateTime date { get; set; }
        public float Amount { get; set; }
        public string Receipt_id { get; set; }
        public string description { get; set; }
    }
}
 