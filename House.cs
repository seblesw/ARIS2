using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ARIS.Entity
{
    public class House
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Display(Name = "House ID")]
        public string HsId { get; set; } = "";
        public string Boundary { get; set; }
        public Guid ResidentId { get; set; }
        [Display(Name = "House num")]
        public string HouseNo { get; set; }
        [Display(Name = "Area sqr")]
        public double? Area { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dddd, dd MMMM yyyy hh:mm tt}")]
        [Display(Name = "Date created")]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dddd, dd MMMM yyyy hh:mm tt}")]
        [Display(Name = "Date modified")]
        public DateTime? ModifiedDate { get; set; }
        public Resident Resident { get; set; }
    }
}
