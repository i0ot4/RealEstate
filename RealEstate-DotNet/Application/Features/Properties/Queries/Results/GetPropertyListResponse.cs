namespace Application.Features.Properties.Queries.Results
{
    public class GetPropertyListResponse
    {
        public Guid Id { get; set; } // Primary Key
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; } // تاجير - تمليك -إستثمار
        public int Status { get; set; } // متاح 0 - مباع 1 - ممول 2
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int? NumberOfApartments { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalSales { get; set; }
    }
}
