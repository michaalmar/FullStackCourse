﻿using GigHub.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();


        public ActionResult Index()
        {
            var upcommingGigs = _context
                .Gigs.Include(g => g.Artist)
                .Include(g=> g.Genre)
                .Where(g => g.DateTime > DateTime.Now);

            return View(upcommingGigs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}