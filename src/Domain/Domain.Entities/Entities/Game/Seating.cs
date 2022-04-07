using Domain.Model.Entities.Base;

namespace Domain.Model.Entities.Game
{
    public class Seating : BaseEntity<long>
    {
        public string Code { get; set; }

        public long GrandStandId { get; set; }

        public long StadiumId { get; set; }

        public bool Purchased { get; set; } = false;

        public string Category { get; set; }

        public decimal Price { get; set; }
    }
}
