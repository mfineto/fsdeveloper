using System;
using MongoDB.Bson;

namespace FSDevelop.Models
{
    public class User
    {
        public ObjectId _id { get; set; }
        public string UserID { get; set; }
        public string Password { get; set;}
    }
}