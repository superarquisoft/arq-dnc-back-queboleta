using Domain.Model.Entities.Base;

namespace Domain.Model.Entities.Game
{
    public class Stadium : BaseEntity<long>
    {
        public string Name { get; set; }

        public string Image { get; set; }

        public int Capacity { get; set; }

        public int GrandStands { get; set; }
    }
}
