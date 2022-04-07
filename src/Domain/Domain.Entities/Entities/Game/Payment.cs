using Domain.Model.Entities.Base;

namespace Domain.Model.Entities.Game
{
    public class Payment : BaseEntity<long>
    {
        public string Name { get; set; }
    }
}
