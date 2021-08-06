using Airbnb;
using Airbnb.Context;
using Airbnb.Data;
using Airbnb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Airbnb.Controllers
{

    public class HomeController : Controller
    {
        RoomsRepository roomDatabase;
     
        public HomeController(RoomsRepository roomDatabase)
        {
            this.roomDatabase = roomDatabase;
        }
        

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> GetRooms(int id)
        {       
            var rooms = await roomDatabase.GetRooms();
            return View(rooms);
            

        }

        public IActionResult GetRoom(int id)
        {
            var rm = roomDatabase.GetRoom(id);
            return View(rm);
        }

        public IActionResult AddRoom(string isSuccess="false")
        {
            ViewData["Success"] = isSuccess;
            return View(new RoomModel());
        }
       
        [HttpPost]
        public async Task<IActionResult> AddRoom(RoomModel model)
        {
            // Add room to database
           int id =await roomDatabase.AddRoom(model);
            if (id > 0)
            {
                ViewData["Success"] = "true";
                return RedirectToAction(nameof(AddRoom), new { isSuccess = "true" });
            }

            return View();
        }

        public IActionResult Details(int id, string name)
        {
            var rm = roomDatabase.GetRoom(id);
            return View(rm);
        }

        
        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Brief(int price, string description)
        {
            ViewBag.Price = price;
            ViewBag.Description = description;
            return View();
        }

        [HttpPost]
        public IActionResult Brief(RoomModel model)
        {
            // Add room to database
           // roomDatabase.AddRoom(model);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
  
}
