using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingManager.Repository.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public bool IsPaid { get; set; }

        [ForeignKey("Booking")]
        public int BookingID { get; set; }

        // Navigation properties
        public virtual Booking Booking { get; set; }
    }
}
