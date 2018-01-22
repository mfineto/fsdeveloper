using System;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using FSDevelop.Models;
using System.Collections.Generic;

namespace FSDevelop
{
    public class MongoContext
    {
        private IConfiguration _configuration;

        public MongoContext(IConfiguration config)
        {
            _configuration = config;
        }

        public User FindUser(string userID)
        {
            MongoClient client = new MongoClient(
                _configuration.GetConnectionString("MongoConnection"));
            IMongoDatabase db = client.GetDatabase("DBProducts");

            var filter = Builders<User>.Filter.Eq("UserID", userID);

            var users = db.GetCollection<User>("Users");

            return users.Find(filter).FirstOrDefault();
        }

        public List<T> RetrieveAllProducts<T>()
        {
            MongoClient client = new MongoClient(
                _configuration.GetConnectionString("MongoConnection"));
            IMongoDatabase db = client.GetDatabase("DBProducts");

            return db.GetCollection<T>("Products").AsQueryable<T>().ToList<T>();
        }
    }
}
