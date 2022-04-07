using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DrivenAdapter.Mongo.Entities
{
    [BsonIgnoreExtraElements]
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string ObjectId { get; set; }

        [BsonElement("created")]
        public DateTime Created { get; set; }

        [BsonElement("created_by")]
        public string CreatedBy { get; set; }

        [BsonElement("lastmodified")]
        public DateTime? LastModified { get; set; }

        [BsonElement("lastmodified_by")]
        public string LastModifiedBy { get; set; }
    }
}
