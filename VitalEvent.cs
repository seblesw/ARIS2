using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ARIS.Entity
{
    public class VitalEvent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid ResidentId { get; set; }             
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }        
        [DataType(DataType.Date)]
        [Display(Name = "Place Of Birth")]
        public DateTime PlaceofCountryBirth { get; set; }
        [Display(Name = "Date Of Certified Issue")]
        public DateTime DateOfCertifiedIssue { get; set; }
        public string Nationality { get; set; }
        [Display(Name = "Name Of Civil RegistrarName")]
        public string NameOfCivilRegistrarName{ get; set; }
        [Display(Name = "Signture")]
        public string Signture { get; set; }
        public Resident Resident { get; set; }  

    }
}
