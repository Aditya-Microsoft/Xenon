using System.ComponentModel.DataAnnotations;

namespace XenonAPI.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string RoomNumber { get; set; } = string.Empty;

        [Required]
        public int Capacity { get; set; }

        public int OccupiedBeds { get; set; }

        // One-to-Many relationship: One Room can have multiple Tenants
        public ICollection<Tenant> Tenants { get; set; } = new List<Tenant>();
    }
}
