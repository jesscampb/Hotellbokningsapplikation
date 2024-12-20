using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingManager.Repository.Entities
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }

        [Required]
        [StringLength(10)]
        public string RoomNumber { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        [StringLength(20)]
        public string RoomType { get; set; }

        [Required]
        public int ExtraBedAmount { get; set; }

        // Navigation properties
        public virtual List<Booking> Bookings { get; set; }
    }
}
