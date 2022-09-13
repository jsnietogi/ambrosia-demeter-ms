using System;
using MongoDB.Bson;
using MongoDB.Driver;
using ambrosia_demeter_api.Models;
using ambrosia_demeter_api.access;

namespace ambrosia_demeter_api
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 7, 24);
            PaymentModel payment = new PaymentModel { Amount = 240, personId = "so", date = dt, description = "na", Receipt_id = "a164" };
            dataAccess data = new dataAccess();
            data.createDebt(payment);
             
            data.GetAllPaymentsUser("so");
            /*
            
            var paymenst = new PaymentModel { Amount = 240, personId = "so", date = dt, description = "na", Receipt_id = "a164" };
            collection.InsertOne(paymenst);*/

        }

      
    }

  
}


