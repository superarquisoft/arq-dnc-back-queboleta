using MongoDB.Bson.Serialization.Attributes;

namespace DrivenAdapter.Mongo.Entities
{
    [BsonIgnoreExtraElements]
    public class GrandstandEntity : BaseEntity
    {
        [BsonElement("grandstand_id")]
        public long Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("stadium_id")]
        public long StadiumId { get; set; }
    }
}
