using HotelBookingManager.Repository.Entities;

namespace HotelBookingManager.Repository.Repos
{
    public class CustomerRepo
    {
        private readonly DataContext _context;

        public CustomerRepo()
        {
            //En ny instans av context skapas när repot sätts upp
            _context = new DataContext();
        }

        /// 
        /// SELECT
        /// 

        public List<Customer> GetAllCustomers()
        {
            return _context.Customer.ToList();
        }

        public Customer GetCustomer(int id)
        {
            return _context.Customer.SingleOrDefault(c => c.CustomerID == id);
        }

        public List<Customer> GetAvailableCustomers(DateTime checkIn, DateTime checkOut)
        {
            return _context.Customer
                .Where(c => !_context.Bookings
                .Any(b => b.CustomerID == c.CustomerID &&
                          b.CheckInDate < checkOut &&
                          b.CheckOutDate > checkIn))
                .ToList();
        }

        /// 
        /// INSERT
        /// 

        public void InsertCustomer(Customer customer)
        {
            _context.Customer.Add(customer);

            _context.SaveChanges();
        }

        /// 
        /// UPDATE
        /// 

        // Ändra uppgifter
        public void UpdateCustomer(Customer customerNew)
        {
            Customer customerOld = GetCustomer(customerNew.CustomerID);

            _context.Entry(customerOld).CurrentValues.SetValues(customerNew);

            _context.SaveChanges();
        }

        /// 
        /// DELETE
        /// 

        // Inga bokningar får finnas kopplade
        // Applikationen kontrollerar detta innan en delete sker
        public void DeleteCustomer(int id)
        {
            Customer customer = GetCustomer(id);

            _context.Customer.Remove(customer);

            _context.SaveChanges();
        }
    }
}
