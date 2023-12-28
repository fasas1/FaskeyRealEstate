using FaskeyAtlantic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaskeyAtlantic.Infrastructure.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Estate> Estates { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Estate>().HasData(
				new Estate
					  {
						Id = 1,
						Name = "Banana Ville Resort",
						Description = "Neatly used 2 bedroom penthouse.  Unit - The unit covers the entire floor, with two massive balconies in front and back, you may decided to add additional rooms in front if you wish but you are not allowed to\r\nadd another floor as the approved amount of floors within the estate is four(4).Content from Nigeria Property Centre",
						Price = 4800,
						Occupancy= 5,
						ImageUrl= "https://www.pexels.com/photo/blue-lounger-beside-swimming-pool-221457/",
						Sqft = 1700
					  },
					 new Estate
					 {
						Id = 2,
						Name = "Exclusive Luxury Mansion",
						Description = "Neatly used 3 bedroom. invater - The unit comes with 20-solar panels and 10kva invater - this invater lasts for 12hours and it takes 2 A/cs but all units A/cs are connected to it, you decide which 2 A/cs to leave ON . But\r\nthe light in Osborne Forshore is superb - 23hours and most times it goes for days.Content from Nigeria Property Centre",
						Price = 3800,
						Occupancy = 7,
						 ImageUrl = "https://www.pexels.com/photo/construction-house-architecture-luxury-53610/",
						Sqft = 1300
					  },
					  new Estate
					  {
				        Id = 3,
						Name = "Shuqroh Ville",
						Description = "Neatly used 2 bedroom penthouse.  Unit - The unit covers the entire floor, with two massive balconies in front and back, you\r\nmay decided to add additional rooms in front if you wish but you are not allowed to\r\nadd another floor as the approved amount of floors within the estate is four(4).Content from Nigeria Property Centre",
						Price = 1400,
						  Occupancy = 4,
						  ImageUrl = "https://www.pexels.com/photo/white-concrete-2-storey-house-206172/",
						Sqft = 1100
					  }
				);
		}
	}
}
