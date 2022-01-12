
using FoodCard.DB;
using FoodCard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodCard.Controllers
{
    public class UserController:Controller
    {
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        public IActionResult AddUser(string Name,string Surname,string TcNumber)
        {
            if (TcNumber is not null)
            {
                using (var db = new FoodCardContext())
                {
                    var user = new UserModel { Name = Name, Surname = Surname, TcNumber = TcNumber };
                    db.Users.Add(user);
                    db.SaveChanges();
                }
            }
            
            //kullanıcı eklenecek
            

            return View();
        }
        public IActionResult AddCard(int CardNumber,string TcNumber)
        {

            if (CardNumber!=0)
            {
               
                using(var db=new FoodCardContext())
                {
                    var user = db.Users.Where(i => i.TcNumber == TcNumber).FirstOrDefault();
                    if (user is not null)
                    {
                        var card = new CardModel { Balance = 0, CardNumber = CardNumber,UserId=user.Id };
                        db.Cards.Add(card);
                        db.SaveChanges();
                    }
                    //burası dolacak*/
                }
            }
            return View();
        }
    }
}
