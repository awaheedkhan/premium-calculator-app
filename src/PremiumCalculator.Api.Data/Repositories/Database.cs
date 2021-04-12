using PremiumCalculator.Api.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PremiumCalculator.Api.Data.Repositories
{
    public static class Database
    {
        public static List<Rating> Ratings = new List<Rating> {
            new Rating{ 
                Id = 1,
                Label = "Professional",
                Factor = 1.1
            },
            new Rating{
                Id = 2,
                Label = "White Collar",
                Factor = 1.1
            },
            new Rating{
                Id = 3,
                Label = "Light Manual",
                Factor = 1.1
            },
            new Rating{
                Id = 4,
                Label = "Heavy Manual",
                Factor = 1.1
            },
        };

        public static List<Occupation> Occupations = new List<Occupation>
        {
            new Occupation{
                Id = 1,
                Label = "Cleaner",
                Rating = Ratings.First(rating => rating.Id == 3)
            },
            new Occupation{
                Id = 2,
                Label = "Doctor",
                Rating = Ratings.First(rating => rating.Id == 1)
            },
            new Occupation{
                Id = 3,
                Label = "Author",
                Rating = Ratings.First(rating => rating.Id == 2)
            },
            new Occupation{
                Id = 4,
                Label = "Farmer",
                Rating = Ratings.First(rating => rating.Id == 4)
            },
            new Occupation{
                Id = 5,
                Label = "Mechanic",
                Rating = Ratings.First(rating => rating.Id == 4)
            },
            new Occupation{
                Id = 6,
                Label = "Florist",
                Rating = Ratings.First(rating => rating.Id == 3)
            },
        };



    }
}
