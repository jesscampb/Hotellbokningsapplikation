using HotelBookingManager.Repository.Entities;

namespace HotelBookingManager.Repository.Repos
{
    public class InvoiceRepo
    {
        private readonly DataContext _context;

        public InvoiceRepo()
        {
            //En ny instans av context skapas när repot sätts upp
            _context = new DataContext();
        }

        /// 
        /// SELECT
        /// 

        public List<Invoice> GetAllInvoices()
        {
            return _context.Invoices.ToList();
        }

        public Invoice GetInvoice(int id)
        {
            return _context.Invoices.SingleOrDefault(i => i.InvoiceID == id);
        }

        /// 
        /// INSERT
        /// 

        // Skapa en faktura vid bokning
        public void InsertInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);

            _context.SaveChanges();
        }

        /// 
        /// UPDATE
        /// 

        // Registrera en inkommen betalning (update)
        public void UpdateInvoice(Invoice invoiceNew)
        {
            Invoice invoiceOld = GetInvoice(invoiceNew.InvoiceID);

            _context.Entry(invoiceOld).CurrentValues.SetValues(invoiceNew);

            _context.SaveChanges();
        }

        /// 
        /// DELETE
        /// 

        // Om ingen betalning inkommit inom 10 dagar från bokningsdatumet
        // så annulleras bokningen (delete)
        // Booking.IsCancelled = true;
        public void DeleteInvoices(int id)
        {
            Invoice invoice = GetInvoice(id);

            _context.Invoices.Remove(invoice);

            _context.SaveChanges();
        }

        public void DeleteInvoiceWithBookingID(int bookingId)
        {
            Invoice invoice = _context.Invoices.SingleOrDefault(i => i.BookingID == bookingId);

            _context.Invoices.Remove(invoice);
            _context.SaveChanges();
        }

        public void DeleteOverdueInvoicesAndBookings()
        {
            var invoicesToRemove = _context.Invoices
                .Where(i => i.DueDate.Date == DateTime.Today)
                .ToList();

            var bookingsToRemove = _context.Bookings
                .Where(b => invoicesToRemove.Select(i => i.BookingID).Contains(b.BookingID))
                .ToList();

            _context.Bookings.RemoveRange(bookingsToRemove);
            _context.Invoices.RemoveRange(invoicesToRemove);

            _context.SaveChanges();
        }
    }
}
