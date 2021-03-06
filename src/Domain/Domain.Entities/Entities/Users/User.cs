using Domain.Model.Base;
using System;

namespace Domain.Model.Users
{
    public class User : BaseEntity<long>
    {
        /// <summary>
        /// TypeDocument
        /// </summary>
        public string TypeDocument { get; set; }

        /// <summary>
        /// Document
        /// </summary>
        public string Document { get; set; }

        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// ConfirmPassword
        /// </summary>
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// BirthDate
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// IsAdult
        /// </summary>
        public bool IsAdult { get; set; }
    }
}
