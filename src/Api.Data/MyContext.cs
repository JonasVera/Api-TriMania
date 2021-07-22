using Microsoft.EntityFrameworkCore;
using Api.Domain.Entities;
using Api.Data.Mapping;

namespace Api.Data

{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MyContext (DbContextOptions<MyContext> options) : base (options) {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(new UserMap().Configure);

        }
    }
}
