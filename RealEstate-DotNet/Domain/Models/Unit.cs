namespace Domain.Models
{
    public class Unit
    {
        public int UnitID { get; set; }
        public int PropertyID { get; set; } // Foreign Key
        public string UnitNumber { get; set; }
        public decimal Size { get; set; } // المساحة بالمتر المربع
        public int Rooms { get; set; } // عدد الغرف
        public int Bathrooms { get; set; } // عدد الحمامات
        public int Floor { get; set; } // الطابق الذي تقع فيه الوحدة
        public Property Property { get; set; } // Navigation Property
    }
}
