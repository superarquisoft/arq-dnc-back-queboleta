using MongoDB.Bson.Serialization.Attributes;

namespace DrivenAdapter.Mongo.Entities
{
    [BsonIgnoreExtraElements]
    public class PaymentEntity : BaseEntity
    {
        [BsonElement("payment_id")]
        public long Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }
    }
}
