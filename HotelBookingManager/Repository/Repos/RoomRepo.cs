using HotelBookingManager.Repository.Entities;

namespace HotelBookingManager.Repository.Repos
{
    public class RoomRepo
    {
        private readonly DataContext _context;

        public RoomRepo()
        {
            _context = new DataContext();
        }

        /// 
        /// SELECT
        /// 

        public List<Room> GetAllRooms()
        {
            return _context.Rooms.ToList();
        }

        public Room GetRoom(int id)
        {
            return _context.Rooms.SingleOrDefault(r => r.RoomID == id);
        }

        public List<Room> GetAvailableRooms(int guestAmount, DateTime checkIn, DateTime checkOut)
        {
            var availableRooms = _context.Rooms
                .Where(r => r.Capacity >= guestAmount &&
                        !_context.Bookings
                .Any(b => b.RoomID == r.RoomID &&
                        b.CheckInDate < checkOut &&
                        b.CheckOutDate > checkIn))
                .ToList();

            return availableRooms;
        }

        /// 
        /// INSERT
        /// 

        public void InsertRoom(Room room)
        {
            _context.Rooms.Add(room);

            _context.SaveChanges();
        }

        /// 
        /// UPDATE
        /// 

        public void UpdateRoom(Room roomNew)
        {
            Room roomOld = GetRoom(roomNew.RoomID);

            _context.Entry(roomOld).CurrentValues.SetValues(roomNew);

            _context.SaveChanges();
        }

        /// 
        /// DELETE
        /// 

        public void DeleteRoom(int id)
        {
            Room room = GetRoom(id);

            _context.Rooms.Remove(room);

            _context.SaveChanges();
        }
    }
}
