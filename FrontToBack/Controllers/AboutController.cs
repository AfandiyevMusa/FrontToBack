using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            AboutVM about = new()
            {
                teams = GetTeamMembers()
            };
            return View(about);
        }

        private List<Team> GetTeamMembers()
        {
            Team t1 = new()
            {
                Id = 1,
                Photo = "team-3.jpg",
                Name = "Musa",
                Position = "Position 1"
            };

            Team t2 = new()
            {
                Id = 2,
                Photo = "team-2.jpg",
                Name = "Murad",
                Position = "Position 2"
            };

            Team t3 = new()
            {
                Id = 3,
                Photo = "team-1.jpg",
                Name = "Nicat",
                Position = "Position 3"
            };

            Team t4 = new()
            {
                Id = 4,
                Photo = "team-4.jpg",
                Name = "Mahir",
                Position = "Position 4"
            };
            List<Team> teams = new() { t1, t2, t3, t4 };
            return teams;
        }
    }
}

