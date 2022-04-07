using Domain.Model.Entities.Base;

namespace Domain.Model.Entities.Game
{
    public class Grandstand : BaseEntity<long>
    {
        public string Name { get; set; }

        public long StadiumId { get; set; }
    }
}
