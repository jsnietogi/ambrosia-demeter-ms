using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace ambrosia_demeter_api.examples
{
    class Class1
    { // un bson para subir al database y subirlo a la base de datos
        BsonDocument document = new BsonDocument
        {
                 { "student_id", 10000 },
                 { "scores", new BsonArray
                     {
                     new BsonDocument{ {"type", "exam"}, {"score", 88.12334193287023 } },
                     new BsonDocument{ {"type", "quiz"}, {"score", 74.92381029342834 } },
                     new BsonDocument{ {"type", "homework"}, {"score", 89.97929384290324 } },
                     new BsonDocument{ {"type", "homework"}, {"score", 82.12931030513218 } }
                     }
                 },
                 { "class_id", 480}
        };
        //"collection".InsertOne(document);

        //pasar lista de bases a una lista y las imprime
        //var dbList = dbClient.ListDatabases().ToList();\
        /*Console.WriteLine("The list of databases on this server is: ");
             foreach (var db in dbList)
             {
                 Console.WriteLine(db);
             }*/

        //crear un filtro para un dato especifico y buscar en caso de no encontrar devolver el primer dato y lo imprime
        //var filter = Builders<BsonDocument>.Filter.Eq("student_id", 10000);
        //var firstDocument = collection.Find(filter).FirstOrDefault();
        //Console.WriteLine(firstDocument.ToString());

        //o

        //var firstDocument = collection.Find(c => c.assignedTo.Id == "user".Id).FirstOrDefault(); user biene del metodo
    }
}
