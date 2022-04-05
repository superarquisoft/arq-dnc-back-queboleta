using System;

namespace Domain.Model.Entities.Base
{
    public abstract class BaseEntity<TId> : ICloneable
    {
        /// <summary>
        /// Id
        /// </summary>
        public TId Id { get; set; }

        /// <summary>
        /// Created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// CreatedBy
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// LastModified
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// LastModifiedBy
        /// </summary>
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Clone the current entity
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
