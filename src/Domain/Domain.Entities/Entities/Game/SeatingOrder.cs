using Domain.Model.Entities.Base;

namespace Domain.Model.Entities.Game
{
    public class SeatingOrder : BaseEntity<long>
    {
        public long StadiumId { get; set; }

        public long GrandStandId { get; set; }

        public long SeatingId { get; set; }

        public long GameId { get; set; }
    }
}
