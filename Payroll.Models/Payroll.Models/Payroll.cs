using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Models
{
    public class Payroll
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public string Description { get; set; }
        public string DeductionOrAddition { get; set; }
        public string TaxCategory { get; set; }
        public string ItemName { get; set; }
        public decimal Amount { get; set; }
    }
}
