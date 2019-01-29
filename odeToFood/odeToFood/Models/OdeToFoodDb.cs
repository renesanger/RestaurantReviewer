using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace odeToFood.Models
{
    public class OdeToFoodDb : DbContext
    {
        public OdeToFoodDb() :base("name = DefaultConnection") 
        {

        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    }
}