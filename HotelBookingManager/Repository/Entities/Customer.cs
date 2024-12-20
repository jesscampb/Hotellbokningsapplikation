using System.ComponentModel.DataAnnotations;

namespace HotelBookingManager.Repository.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        // Navigation properties
        public virtual List<Booking> Bookings { get; set; }
    }
}
