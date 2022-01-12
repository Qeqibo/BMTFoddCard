
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodCard.Models
{
    public class CardModel
    {
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public double Balance { get; set; }
        //public DateTime MyProperty { get; set; }
        public int UserId { get; set; }

    }
}
