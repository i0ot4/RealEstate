using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class FinancialDetail
    {
        [Key]
        public int DetailId { get; set; } // Primary Key
        public int PropertyId { get; set; } // Foreign Key
        public decimal PropertyCost { get; set; }
        public decimal TransactionExpenses { get; set; }
        public decimal InvestmentCost { get; set; }
        public decimal AnnualGrossRent { get; set; }
        public decimal ServiceFees { get; set; }
        public decimal MaintenanceCost { get; set; }
        public decimal AdministrationCost { get; set; }
    }
}
