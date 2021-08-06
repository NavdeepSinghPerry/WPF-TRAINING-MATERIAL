using System.Collections.Generic;
using System.Threading.Tasks;

namespace Airbnb.Data
{
    public interface IRoomsRepository
    {
        Task<int> AddRoom(RoomModel roomModel);
        void DeleteRoom(int id);
        RoomModel GetRoom(int id);
        Task<List<RoomModel>> GetRooms();
    }
}