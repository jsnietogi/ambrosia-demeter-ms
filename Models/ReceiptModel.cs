using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ambrosia_demeter_api.Models
{
    class ReceiptModel
    {
        [BsonId]

        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public string ObjectId { get; set; }
        public string ReceiptId { get; set; }
        public DateTime due_date { get; set; }
        public DateTime overdue_date { get; set; }
    }
}
