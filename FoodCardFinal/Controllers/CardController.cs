
using FoodCard.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodCard.Controllers
{
    public class CardController:Controller
    {
        private readonly ILogger<CardController> _logger;

        public CardController(ILogger<CardController> logger)
        {
            _logger = logger;
        }
        public IActionResult GetBalance(int CardNumber)
        {
           
            if (CardNumber!=0)
            {
                Console.WriteLine(HttpContext.Request.Query["CardId"].ToString());
                using (var db = new FoodCardContext())
                {
                    var balance = db.Cards.Where(i=>i.CardNumber==CardNumber).FirstOrDefault();
                    if (balance is not null)
                    {
                        Console.WriteLine(balance.Balance);
                    }
                    
                        
                }
            }
            //burada bakiyeyi viewde  göster
            
            
            return View();
        }
        public IActionResult LoadBalance(int CardNumber,double Balance)
        {
            if (CardNumber!=0)
            {
                using (var db = new FoodCardContext())
                {
                    var card = db.Cards.Where(i => i.CardNumber == CardNumber).FirstOrDefault();
                    if (card is not null)
                    {

                        card.Balance = card.Balance + Balance;
                        db.SaveChanges();
                    }
                }
            }
            return View();
        }
    }
}
