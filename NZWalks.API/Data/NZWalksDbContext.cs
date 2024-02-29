using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet <Difficulty> Difficulties { get; set; }
        public DbSet <Region> Regions { get; set; }
        public DbSet <Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed the data for Difficulties
            // Easy,Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("40a660bc-ea82-469f-b0e6-1322482746b3"),
                    Name = "Easy"
                },

                new Difficulty()
                {
                    Id = Guid.Parse("01a7342f-a82a-4b76-b303-e9f4b0927f3b"),
                    Name = "Medium"
                },

                new Difficulty()
                {
                    Id = Guid.Parse("0861718d-0920-464d-bbc7-4eb720e888a8"),
                    Name = "Hard"
                }
            };


            // Seed Difficulties to the dattabase
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed Data For Regions

            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.Parse("ae666ceb-0221-4183-8e61-e95e184c1279"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.leeabbamonte.com%2Fwp-content%2Fuploads%2F2016%2F02%2FIMG_4179.jpg&f=1&nofb=1&ipt=c6afc719bc45e35a0076bc77848472833663f5ccef20dac9159f6fd59a23e7be&ipo=images"
                },

                 new Region
                {
                    Id = Guid.Parse("761dd6b7-5add-42e3-a081-6189ef5ebb67"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdn.discover-the-world.com%2Fapp%2Fuploads%2F2018%2F05%2Fnew-zealand-northland-cape-reinga-lighthouse-istk-1200x630-c-center.jpg&f=1&nofb=1&ipt=49dc02140639525552bfea1763eca24cd3d41c850a05089e75c9c6d04e4ca8e4&ipo=images"
                },

                  new Region
                {
                    Id = Guid.Parse("f853f9ee-183a-4d57-bfa9-03ed5ddd8e0c"),
                    Name = "Bay of Plenty",
                    Code = "BOP",
                    RegionImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.pinimg.com%2Foriginals%2Fff%2Fac%2Fb1%2Fffacb1b93f5ce672d8c2ecf1090048d1.jpg&f=1&nofb=1&ipt=30bbb7082bae74b11aa83632ec8ac42fd9ab18394e1cd747047a7d8a9b03a749&ipo=images"
                },

                   new Region
                {
                    Id = Guid.Parse("8019b47e-bbcf-4914-a8bd-0d4d02bfdfe3"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.wallpapers-for-desktop.eu%2Fdesktop%2F8203-panorama-city-new-of-wellington-8203-zeland.jpg&f=1&nofb=1&ipt=5e93a00d8be8d944e8f1d41189b2a85f31c74deba09819aa9e3332bff88aee10&ipo=images"
                },

                    new Region
                {
                    Id = Guid.Parse("d9bdf6d0-cbe8-4d79-84b5-fb49a3d75e86"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://4.bp.blogspot.com/-WqNGc3CpgS8/T2EXOD0POzI/AAAAAAAAA2I/WxXLG1vxQEc/s1600/P1010843.jpg"
                },

                     new Region
                {
                    Id = Guid.Parse("ed40882b-c926-4a52-9251-e031a1b4c0f6"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = "https://a.travel-assets.com/findyours-php/viewfinder/images/res70/180000/180773-South-Island.jpg"
                }

            };

            modelBuilder.Entity<Region>().HasData(regions);

        }


    }
}
