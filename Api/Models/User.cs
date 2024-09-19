using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Names { get; set; }
        public string? LastNames { get; set; }
        public string? Email { get; set; }
    }
}