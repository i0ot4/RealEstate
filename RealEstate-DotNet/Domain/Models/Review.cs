namespace Domain.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; } // Foreign Key
        public int PropertyID { get; set; } // Foreign Key
        public int Rating { get; set; } // تقييم (من 1 إلى 5)
        public string Comment { get; set; }

        public User User { get; set; } // Navigation Property
        public Property Property { get; set; } // Navigation Property
    }
}
