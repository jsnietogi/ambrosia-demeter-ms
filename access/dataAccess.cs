using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using ambrosia_demeter_api.Models;

namespace ambrosia_demeter_api.access
{
    public class dataAccess
    {
        private const string connectionString = "mongodb://127.0.0.1:27017";
        //string connectionString = "mongodb+srv://rootuser:rootpass@cluster0.pazycer.mongodb.net/?retryWrites=true&w=majority";
        private const string databaseName = "ambrosia_demeter_dbs";
        private const string Colpay = "Payments";
        private const string Colrec = "Receipt";

        private IMongoCollection<T> connectToMongo<T>(in String collection)
        {
            MongoClient client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            return db.GetCollection<T>(collection);
        
        }

        public void getAllPayments()
        {
            var results = connectToMongo<PaymentModel>(Colpay).Find(_ => true);
            foreach (var result in results.ToList())
            {
                Console.WriteLine(value: $"{result.personId}: {result.Receipt_id} {result.Amount} {result.date} {result.description}");
            }
        }
        public int createDebt(PaymentModel payment)
        {
            var collection = connectToMongo<PaymentModel>(Colpay);
            collection.InsertOne(payment);
            return 201;
        }
        
        public void GetAllPaymentsUser(string userId)
        {
            var collection = connectToMongo<PaymentModel>(Colpay);
            var results = collection.Find(c => c.personId == userId);
            foreach (var result in results.ToList())
            {
                Console.WriteLine(value: $"{result.personId}: {result.Receipt_id} {result.Amount} {result.date} {result.description}");
            }
        }
    }
}
