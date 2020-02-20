using System.Collections.Generic;

namespace EfDAL.Models
{
    /// <summary>
    /// Represents a single person.
    /// </summary>
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        /// <summary>
        /// The addresses that are tied to this person.
        /// </summary>
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// The email addresses that are tied to this person.
        /// </summary>
        /// <value></value>
        public List<Email> EmailAddresses { get; set; }
    }
}