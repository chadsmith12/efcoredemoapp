using Microsoft.EntityFrameworkCore;

namespace EfDAL.DataAccess
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options)
        {

        }
    }
}