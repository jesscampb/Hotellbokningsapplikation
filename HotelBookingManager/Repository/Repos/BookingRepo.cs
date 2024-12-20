using HotelBookingManager.Repository.Entities;

namespace HotelBookingManager.Repository.Repos
{
    public class BookingRepo
    {
        private readonly DataContext _context;

        public BookingRepo()
        {
            //En ny instans av context skapas när repot sätts upp
            _context = new DataContext();
        }

        /// 
        /// SELECT
        /// 

        // På ett datum eller datumintervall och antal personer
        // Se alla lediga rum i sökresultatet
        public List<Booking> GetAllBookings()
        {
            return _context.Bookings.ToList();
        }

        public Booking GetBooking(int id)
        {
            return _context.Bookings.SingleOrDefault(b => b.BookingID == id);
        }

        public bool HasBooking(int customerId)
        {
            return _context.Bookings.Any(b => b.CustomerID == customerId);
        }

        /// 
        /// INSERT
        /// 

        // En eller flera nätter per kund
        // Ej boka rum på ett upptaget datum
        public void InsertBooking(Booking booking)
        {
            _context.Bookings.Add(booking);

            _context.SaveChanges();
        }

        /// 
        /// UPDATE
        /// 

        // Ändra en bokning (update)
        public void UpdateBooking(Booking bookingNew)
        {
            Booking bookingOld = GetBooking(bookingNew.BookingID);

            _context.Entry(bookingOld).CurrentValues.SetValues(bookingNew);

            _context.SaveChanges();
        }

        /// 
        /// DELETE
        /// 

        // Avboka ett rum (delete)
        public void DeleteBooking(int id)
        {
            Booking booking = GetBooking(id);

            _context.Bookings.Remove(booking);

            _context.SaveChanges();
        }
    }
}
