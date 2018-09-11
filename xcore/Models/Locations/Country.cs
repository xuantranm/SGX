﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Country
    {
        [BsonId]
        // Mvc don't know how to create ObjectId from string
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required]
        // Apply standard ISO Code (2 character)
        // https://www.w3schools.com/tags/ref_country_codes.asp
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public string Alias { get; set; }

        public string Language { get; set; }
    }
}
