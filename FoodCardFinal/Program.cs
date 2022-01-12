using FoodCard.DB;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FoodCard
{
    /*public class Card
    {
        public int Id{ get; set; }
        public int CardNumber { get; set; }
        public double Balance { get; set; }
        //public DateTime MyProperty { get; set; }

    }*/
   /* public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int TcNumber { get; set; }
    }*/
    /*public class FoodCardContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=FoodCard.db");
        }
        
    }*/
}
