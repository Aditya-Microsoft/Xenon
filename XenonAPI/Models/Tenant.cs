namespace XenonAPI.Models
{
    public class Tenant
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? Email { get; set; }
        public int RoomNumber { get; set; }
        public int? BedNumber { get; set; } // Nullable if it's a single-tenant room
        public decimal RentAmount { get; set; }
        public decimal DepositAmount { get; set; }
        public DateTime RentDueDate { get; set; }
        public DateTime MoveInDate { get; set; }
        public DateTime? MoveOutDate { get; set; } // Nullable if they haven't moved out
        public bool IsVacatingSoon => MoveOutDate.HasValue && (MoveOutDate.Value - DateTime.UtcNow).TotalDays <= 20;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }

}
