using System;
using FSDevelop.Models;

namespace FSDevelop.Data
{
    public class ProductDAO
    {
        private IConfiguration _configuration;

        public ProductDAO(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<T> RetrieveAll<T>()
        {
            MongoClient client = new MongoClient(
                _configuration.GetConnectionString("MongoConnection"));
                IMongoDatabase db = client.GetDatabase("DBProducts");

            var filter = Builders<T>.Filter.Eq("UserID", userID);

            return db.GetCollection<T>("Catalogo");
        }
    }
}