using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            ServiceVM service = new()
            {
                services = GetAllServices(),
                testimonials = GetTestimonials()
            };
            return View(service);
        }

        private List<Services> GetAllServices()
        {
            Services s1 = new()
            {
                Id = 1,
                Name = "Mahir",
                Logo = "icon-1.png",
                Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusamus, soluta?"
            };
            Services s2 = new()
            {
                Id = 2,
                Name = "Rasul",
                Logo = "icon-3.png",
                Info = "tetur Lorem ipsum dolor sit amet consecadipisicing elit. Accusamus, soluta?"
            };
            Services s3 = new()
            {
                Id = 3,
                Name = "Murad",
                Logo = "icon-7.png",
                Info = "amet consectetur adipisilor sicing elit. Accusamus, Lorem ipsum dot soluta?"
            };
            Services s4 = new()
            {
                Id = 4,
                Name = "Musa",
                Logo = "icon-2.png",
                Info = "Accusamus, soluta? Lorem ipsum dolor consectetur adipisicin sit ametg elit. Accusamus, soluta?"
            };
            Services s5 = new()
            {
                Id = 5,
                Name = "Nicat",
                Logo = "icon-9.png",
                Info = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ad doloremque ipsa quis.t ametg elit. Accusamus, soluta?"
            };
            Services s6 = new()
            {
                Id = 6,
                Name = "Ramil",
                Logo = "icon-4.png",
                Info = "m ipsum dolor sit amet  dolor sit amet, consectetur adipisicing elit.consdolor consectetur adipisicin sit ametg elit. Accusamus, soluta?"
            };

            List<Services> services = new() { s1, s2, s3, s4, s5, s6 };
            return services;
        }

        private List<Testimonial> GetTestimonials()
        {
            Testimonial t1 = new()
            {
                Id = 1,
                Photo = "testimonial-2.jpg",
                About = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusamus, soluta?",
                Name = "Murad",
                Position = "Position 1"
            };
            Testimonial t2 = new()
            {
                Id = 2,
                Photo = "testimonial-1.jpg",
                About = "ectetur adipisicing elit. AcLorem ipsum dolor sit amet conscusamus, soluta?",
                Name = "Musa",
                Position = "Position 2"
            };
            Testimonial t3 = new()
            {
                Id = 3,
                Photo = "testimonial-2.jpg",
                About = "t consectetur adipisicing elit. Accusamus, soluta?Lorem ipsum dolor sit ame",
                Name = "Ali",
                Position = "Position 3"
            };
            Testimonial t4 = new()
            {
                Id = 4,
                Photo = "testimonial-4.jpg",
                About = "Accusamus, soluta?Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                Name = "Remzi",
                Position = "Position 4"
            };

            List<Testimonial> testimonials = new() { t1, t2, t3, t4 };
            return testimonials;
        }
    }
}

