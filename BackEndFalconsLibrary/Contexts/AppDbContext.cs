using BackEndFalconsLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFalconsLibrary.Contexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Book> Books_List { get; set; }
        public DbSet<User> Falcon_UserList { get; set; }
        public DbSet<Reserve> Reserve { get; set; } 
        public DbSet<Wishlist> Wishlist { get; set; }
        public DbSet<Fine> Fines_List { get; set; }
        public DbSet<Copy> Falcon_Copies_List { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //           .HasOptional(j => j.Reserva)
        //           .WithMany()
        //           .WillCascadeOnDelete(true);
        //    base.OnModelCreating(modelBuilder);
        //}



    }
}
