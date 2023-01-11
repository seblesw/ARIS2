using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ARIS.Entity
{
    public class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid ResidentId { get; set; }
        public double AmountPaid { get; set; }
        public string Status { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dddd, dd MMMM yyyy hh:mm tt}")]
        [Display(Name = "Date paid")]
        public DateTime PaidDate { get; set; }
        public virtual Resident Resident { get; set; }

    }
}
