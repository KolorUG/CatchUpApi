using CatchUppApi.Models;
using Microsoft.EntityFrameworkCore;


namespace CatchUppApi.DbContexts
{
    public class CatchUpDbContext : DbContext
    {
        public CatchUpDbContext(DbContextOptions<CatchUpDbContext> options) : base(options)
        {            
        }

        public DbSet<Address> Adresses {get; set;}
        public DbSet<Offer> Offers {get; set;}
        public DbSet<Order> Orders {get; set;}
        public DbSet<Rating> Raitings {get; set;}   
        public DbSet<Schedule> Schedules {get; set;}
        public DbSet<Student> Studens {get; set;}   
        public DbSet<User> Users {get; set;}   



    }
}