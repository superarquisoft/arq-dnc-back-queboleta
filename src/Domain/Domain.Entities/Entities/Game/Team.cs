using Domain.Model.Entities.Base;

namespace Domain.Model.Entities.Game
{
    public class Team : BaseEntity<long>
    {
        public string Name { get; set; }

        public string Image { get; set; }
    }
}
