using Microsoft.EntityFrameworkCore;
using EfDAL.Models;

namespace EfDAL.DataAccess
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options)
        {

        }

        // Add DbSets Here
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> EmailAddresses { get; set; }
    }
}