using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.Models;
namespace Task.Controllers
{
    public class HomeController:Controller
    {

        public IActionResult Main()
        {
            List<Slider> sliders = new List<Slider>
            {
                new Slider
                {
                    id=1,
                    image="slider-1.webp",
                    sub_title="New Collection",
                    title="Top Selling!",
                    link="https://google.com"
                },
                new Slider
                {
                    id=2,
                    image="slider-2.webp",
                    sub_title="Top Collection",
                    title="Best Selling!",
                    link="https://youtube.com"
                }
            };

            ViewBag.Sliders = sliders;
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Blog_Details()
        {
            return View();
        }
        public IActionResult Product_Details()
        {
            return View();
        }
        public IActionResult Contact_Us()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
    }
}
