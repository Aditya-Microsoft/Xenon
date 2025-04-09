namespace XenonAPI.Models
{
    public class Tenant
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? Email { get; set; }
        public int RoomNumber { get; set; }
        public int? BedNumber { get; set; }
        public decimal RentAmount { get; set; }
        public decimal DepositAmount { get; set; }
        public DateTime RentDueDate { get; set; }
        public DateTime MoveInDate { get; set; }
        public DateTime? MoveOutDate { get; set; }
        public bool IsVacatingSoon => MoveOutDate.HasValue && (MoveOutDate.Value - DateTime.UtcNow).TotalDays <= 20;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;

        // Foreign Key for Room
        public int RoomId { get; set; } // Required FK
        public Room? Room { get; set; }
    }

}
