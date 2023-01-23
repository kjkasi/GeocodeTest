using GeocodeApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeocodeApi.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Place> PlaceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Place>().HasData(
                new Place
                {
                    PlaceId = 1,
                    PlaceName = "ya.ru",
                    PlaceDesc = "3"
                },
                new Place
                {
                    PlaceId = 2,
                    PlaceName = "ay.ru",
                    PlaceDesc = "4"
                }
            );
        }
    }
}
