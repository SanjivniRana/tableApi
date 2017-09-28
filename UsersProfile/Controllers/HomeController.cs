using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersProfile.Models;

namespace UsersProfile.Controllers
{
    public class HomeController : Controller
    {
        UserContext context;
        public HomeController()
        {
            context = new UserContext();
        }

        // GET: Home
        public ActionResult Index()
        {
            var userList = new List<UserInfo1>();
            return View(context.UserInfoes.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            var states = context.States.ToList();
            var countries = context.Countries.ToList();
            var viewModel = new UserViewModel
            {
                UserInfo = new UserInfo1(),
                States = states,
                Countries = countries
            };

            return View("Create", viewModel);
        }
        [HttpPost]
        public ActionResult Create(UserInfo1 user)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new UserViewModel
                {
                    UserInfo = user,
                    States = context.States.ToList(),
                    Countries = context.Countries.ToList()
                };

                return View("Create", viewModel);
            }
            if (user.Id == 0)
                context.UserInfoes.Add(user);
            else
            {
                State1 m1 = new State1();
                Country1 m2 = new Country1();
                var userInDb = context.UserInfoes.Single(c => c.Id == user.Id);
                userInDb.Name = user.Name;
                userInDb.DOB = user.DOB;
                user.State = m1.Name;
                userInDb.State = user.State;
                user.Country = m2.Name;
                userInDb.Country = user.Country;

            }

            context.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult FillCity(string country)
        {
            var states = context.States.Where(c => c.CountryID == country);
            return Json(states, JsonRequestBehavior.AllowGet);
        }
    }
}