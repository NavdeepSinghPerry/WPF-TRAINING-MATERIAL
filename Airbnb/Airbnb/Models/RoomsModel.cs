namespace Airbnb.Data
{
    public class RoomModel
    {
        public int Id { get; set; }

        public double Price { get; set; }

        public int BedsCount { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string ImgUrl { get; set; }
    }
}