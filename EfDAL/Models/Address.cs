namespace EfDAL.Models
{
    /// <summary>
    /// Represents a single address.
    /// </summary>
    public class Address
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int PersonId { get; set; }

        public Person Person { get; set; }
    }
}