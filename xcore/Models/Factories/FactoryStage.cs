﻿using Common.Utilities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    // Công đoạn
    public class FactoryStage : Common
    {
        [BsonId]
        // Mvc don't know how to create ObjectId from string
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        // model WorkFactory
        public string WorkCode { get; set; }

        [Required]
        public string Name { get; set; }

        public string Alias { get; set; }
    }
}
