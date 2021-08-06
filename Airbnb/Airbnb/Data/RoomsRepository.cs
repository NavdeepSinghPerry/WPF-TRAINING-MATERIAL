using Airbnb.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airbnb.Data
{
    public class RoomsRepository : IRoomsRepository
    {
        private List<RoomModel> rooms = new List<RoomModel>();
        private AirbnbContext _airbnbContext;

        public RoomsRepository(AirbnbContext airbnbContext)
        {
            _airbnbContext = airbnbContext;
            //rooms.Add(new RoomModel { Id = 1, BedsCount = 2, Description = "This is two bed room", Address = "1A/216", Price = 1000, ImgUrl = "/Images/14809965.jpg" });
            //rooms.Add(new RoomModel { Id = 2, BedsCount = 1, Description = "This is one bed room", Address = "1A/217", Price = 500, ImgUrl = "/Images/205684046.jpg" });
            //rooms.Add(new RoomModel { Id = 3, BedsCount = 3, Description = "This is three bed room", Address = "1A/218", Price = 2000, ImgUrl = "/Images/cq5dam.web.1280.1280.jpeg" });
            //rooms.Add(new RoomModel { Id = 4, BedsCount = 4, Description = "This is FOUR bed room", Address = "1A/219", Price = 5000, ImgUrl = "/Images/download.jpg" });
            //rooms.Add(new RoomModel { Id = 1, BedsCount = 2, Description = "This is two bed room", Address = "1A/216", Price = 1000, ImgUrl = "/Images/14809965.jpg" });
            //rooms.Add(new RoomModel { Id = 2, BedsCount = 1, Description = "This is one bed room", Address = "1A/217", Price = 500, ImgUrl = "/Images/205684046.jpg" });
        }

        public RoomModel GetRoom(int id)
        {
            return rooms.Where(m => m.Id == id).FirstOrDefault();
        }

        public async Task<List<RoomModel>> GetRooms()
        {
            List<RoomModel> roomModels = new List<RoomModel>();
            var models = await _airbnbContext.Rooms.ToListAsync();
            foreach (var mdl in models)
            {
                var model = new RoomModel
                {
                    Price = mdl.Price,
                    Description = mdl.Description,
                    Address = mdl.Address,
                    BedsCount = mdl.BedsCount,
                    ImgUrl = mdl.ImgUrl
                };
                roomModels.Add(model);
            }

            return roomModels;
        }

        public async Task<int> AddRoom(RoomModel roomModel)
        {
            var model = new RoomDatabase
            {
                Price = roomModel.Price,
                Description = roomModel.Description,
                Address = roomModel.Address,
                BedsCount = roomModel.BedsCount,
                ImgUrl = roomModel.ImgUrl
            };

            await _airbnbContext.Rooms.AddAsync(model);
            await _airbnbContext.SaveChangesAsync();
            rooms.Add(roomModel);

            return model.Id;
        }

        public void DeleteRoom(int id)
        {

        }
    }
}
