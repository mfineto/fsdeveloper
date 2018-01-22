using MongoDB.Bson;

namespace FSDevelop.Models
{
    public class Produto
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
    }
}