using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;

namespace FSDevelopCarga
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");
            var configuration = builder.Build();

            MongoClient client = new MongoClient(
                configuration.GetConnectionString("MongoConnection"));
            IMongoDatabase db = client.GetDatabase("DBProducts");

            db.DropCollection("Catalogo");
            db.DropCollection("Products");
            db.DropCollection("Users");


            Console.WriteLine("Products...");

            var productsCatalog = db.GetCollection<Produto>("Products");

            var prod1 = new Produto();
            prod1.Name = "Mario Kart 8 Deluxe";
            prod1.Description = "Mario Kart 8 Deluxe is a racing game for the Nintendo Switch, and the first Mario game overall for the console.";
            prod1.Value = 100.75;
            productsCatalog.InsertOne(prod1);

            var prod2 = new Produto();
            prod2.Name = "Xenoblade 2";
            prod2.Description = "Xenoblade Chronicles 2 is an action role-playing game developed by Monolith Soft and published by Nintendo for the Nintendo Switch video game console. ";
            prod2.Value = 120.70;
            productsCatalog.InsertOne(prod2);

            var prod3 = new Produto();
            prod3.Name = "Stardew Valley";
            prod3.Description = "Stardew Valley is an action role-playing game published by Nintendo for the Nintendo Switch video game console. ";
            prod3.Value = 20.55;
            productsCatalog.InsertOne(prod3);

            Console.WriteLine("Users...");

            var userCatalog = db.GetCollection<User>("Users");

            var user1 = new User();
            user1.UserID = "USER01";
            user1.Password = "123456";
            userCatalog.InsertOne(user1);

            var user2 = new User();
            user2.UserID = "USER02";
            user2.Password = "PASSWORD";
            userCatalog.InsertOne(user2);

            Console.WriteLine("Done.");
            Console.ReadKey();
        }
    }
}
