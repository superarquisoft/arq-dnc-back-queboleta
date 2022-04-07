using Domain.Model.Entities.Base;
using System;

namespace Domain.Model.Entities.Game
{
    public class Game : BaseEntity<long>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public long HomeTeamId { get; set; }

        public string HomeTeamName { get; set; }

        public long AwayTeamId { get; set; }

        public string AwayTeamName { get; set; }

        public long StadiumId { get; set; }

        public string StadiumName { get; set; }

        public DateTime MatchDate { get; set; }

        public bool Finished { get; set; }
    }
}
