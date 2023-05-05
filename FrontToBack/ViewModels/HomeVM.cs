using System;
using FrontToBack.Models;

namespace FrontToBack.ViewModels
{
	public class HomeVM
	{
        public List<Features> features { get; set; }
        public List<OurProjects> ourProjects { get; set; }
        public List<Services> services { get; set; }
        public List<Team> teams { get; set; }
        public List<Testimonial> testimonials { get; set; }
    }
}

