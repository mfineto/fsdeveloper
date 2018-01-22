using MongoDB.Bson;

namespace FSDevelopCarga
{
    public class User
    {
        public ObjectId _id { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
    }

    public class Produto
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
    }
}
