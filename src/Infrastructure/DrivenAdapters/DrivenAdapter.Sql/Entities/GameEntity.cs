using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DrivenAdapter.Mongo.Entities
{
    [BsonIgnoreExtraElements]
    public class GameEntity : BaseEntity
    {
        [BsonElement("game_id")]
        public long Id { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("home_team_id")]
        public long HomeTeamId { get; set; }

        [BsonElement("home_team_name")]
        public string HomeTeamName { get; set; }

        [BsonElement("away_team_id")]
        public long AwayTeamId { get; set; }

        [BsonElement("away_team_name")]
        public string AwayTeamName { get; set; }

        [BsonElement("stadium_id")]
        public long StadiumId { get; set; }

        [BsonElement("stadium_name")]
        public string StadiumName { get; set; }

        [BsonElement("match_date")]
        public DateTime MatchDate { get; set; }

        [BsonElement("finished")]
        public bool Finished { get; set; }
    }
}
