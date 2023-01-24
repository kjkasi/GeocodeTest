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
                    Name = "119027, Внуково аэропорт, терминал А, Рейсовая 2-я улица, 2 к5",
                    Description = "Внуково, международный аэропорт им. А.Н. Туполева",
                    Longitude = 1,
                    Latitude = 1
                },
                new Place
                {
                    PlaceId = 2,
                    Name = "142015, Домодедово аэропорт, 1",
                    Description = "Домодедово, международный аэропорт им. М.В. Ломоносова",
                    Longitude = 2,
                    Latitude = 2
                },
                new Place
                {
                    PlaceId = 3,
                    Name = "140181, Жуковский аэропорт, Накомвод, 3",
                    Description = "Жуковский, международный аэропорт",
                    Longitude = 3,
                    Latitude = 3
                },
                new Place
                {
                    PlaceId = 4,
                    Name = "141426, Шереметьево аэропорт, Терминал А",
                    Description = "Шереметьево, международный аэропорт им. А.С. Пушкина",
                    Longitude = 4,
                    Latitude = 4
                }
            );
        }
    }
}
