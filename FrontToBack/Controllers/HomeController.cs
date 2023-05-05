using FrontToBack.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FrontToBack.ViewModels;

namespace FrontToBack.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        HomeVM home = new()
        {
            features = GetAllFeatures(),
            services = GetAllServices(),
            ourProjects = GetAllOurProjects(),
            teams = GetTeamMembers(),
            testimonials = GetTestimonials()
        };
        return View(home);
    }

    private List<Features> GetAllFeatures()
    {
        Features f1 = new()
        {
            Id = 1,
            Name = "Musa",
            Logo = "icon-5.png",
            Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusamus, soluta?"
        };
        Features f2 = new()
        {
            Id = 2,
            Name = "Murad",
            Logo = "icon-8.png",
            Info = "tetur Lorem ipsum dolor sit amet consecadipisicing elit. Accusamus, soluta?"
        };
        Features f3 = new()
        {
            Id = 3,
            Name = "Rasul",
            Logo = "icon-10.png",
            Info = "amet consectetur adipisilor sicing elit. Accusamus, Lorem ipsum dot soluta?"
        };
        Features f4 = new()
        {
            Id = 4,
            Name = "Mahir",
            Logo = "icon-6.png",
            Info = "Accusamus, soluta? Lorem ipsum dolor consectetur adipisicin sit ametg elit. Accusamus, soluta?"
        };

        List<Features> features = new() { f1, f2, f3, f4 };
        return features;
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