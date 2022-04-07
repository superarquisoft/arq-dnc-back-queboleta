using Domain.Model.Entities.Base;
using System;

namespace Domain.Model.Entities.Game
{
    public class Order : BaseEntity<long>
    {
        public DateTime PurchasedAt { get; set; }

        public long UserId { get; set; }

        public long GameId { get; set; }

        public long StadiumId { get; set; }

        public long SeatingId { get; set; }

        public long GrandStandId { get; set; }

        public decimal Price { get; set; }

        public long PaymentId { get; set; }
    }
}
