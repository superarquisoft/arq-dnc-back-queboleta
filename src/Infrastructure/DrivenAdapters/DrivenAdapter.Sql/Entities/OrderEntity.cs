using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DrivenAdapter.Mongo.Entities
{
    [BsonIgnoreExtraElements]
    public class OrderEntity : BaseEntity
    {
        [BsonElement("order_id")]
        public long Id { get; set; }

        [BsonElement("purchased_at")]
        public DateTime PurchasedAt { get; set; }

        [BsonElement("user_id")]
        public long UserId { get; set; }

        [BsonElement("game_id")]
        public long GameId { get; set; }

        [BsonElement("stadium_id")]
        public long StadiumId { get; set; }

        [BsonElement("seating_id")]
        public long SeatingId { get; set; }

        [BsonElement("grandstand_id")]
        public long GrandStandId { get; set; }

        [BsonElement("price")]
        public decimal Price { get; set; }

        [BsonElement("payment_id")]
        public long PaymentId { get; set; }
    }
}
