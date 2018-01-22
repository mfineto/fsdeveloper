using System.Data.SqlClient;
using Dapper;
using FSDevelop.Models;
using Microsoft.Extensions.Configuration;

namespace FSDevelop.Data
{
    public class UsersDAO
    {
        private IConfiguration _configuration;

        public UsersDAO(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public User Find(string userID)
        {
            MongoClient client = new MongoClient(
                _configuration.GetConnectionString("MongoConnection"));
                IMongoDatabase db = client.GetDatabase("DBProducts");

            var filter = Builders<T>.Filter.Eq("UserID", userID);

            return db.GetCollection<T>("Catalogo")
                .Find(filter).FirstOrDefault();
        }
    }
}