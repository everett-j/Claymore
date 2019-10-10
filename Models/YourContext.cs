using Microsoft.EntityFrameworkCore;
namespace Claymore.Models
{
    public class YourContext :DbContext
    {
        public YourContext(DbContextOptions<YourContext> options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<PostingEvent> Postings {get;set;}

    }
}