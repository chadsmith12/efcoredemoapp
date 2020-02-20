namespace EfDAL.Models
{
    /// <summary>
    /// Represents a single email.
    /// </summary>
    public class Email
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public int PersonId { get; set; }

        public Person Person { get; set; }
    }
}