using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            OurProjectVM ourProject = new()
            {
                ourProjects = GetAllOurProjects()
            };
            return View(ourProject);
        }

        private List<OurProjects> GetAllOurProjects()
        {
            OurProjects op1 = new()
            {
                Id = 1,
                Name = "Musa",
                Logo = "project-3.jpg",
                Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusamus, soluta?"
            };
            OurProjects op2 = new()
            {
                Id = 2,
                Name = "Mahir",
                Logo = "project-1.jpg",
                Info = "tetur Lorem ipsum dolor sit amet consecadipisicing elit. Accusamus, soluta?"
            };
            OurProjects op3 = new()
            {
                Id = 3,
                Name = "Rasul",
                Logo = "project-4.jpg",
                Info = "amet consectetur adipisilor sicing elit. Accusamus, Lorem ipsum dot soluta?"
            };
            OurProjects op4 = new()
            {
                Id = 4,
                Name = "Nicat",
                Logo = "project-2.jpg",
                Info = "Accusamus, soluta? Lorem ipsum dolor consectetur adipisicin sit ametg elit. Accusamus, soluta?"
            };

            List<OurProjects> ourProjects = new() { op1, op2, op3, op4 };
            return ourProjects;
        }
    }
}