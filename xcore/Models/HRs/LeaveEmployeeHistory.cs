﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class LeaveEmployeeHistory
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required]
        public string EmployeeId { get; set; }

        public string LeaveTypeId { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Current { get; set; } = 0;

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Change { get; set; } = 0;

        // Use define cộng hay chua
        public int Month { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public int Year { get; set; }

        public string Description { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime UpdatedOn { get; set; } = DateTime.Now;

    }
}
