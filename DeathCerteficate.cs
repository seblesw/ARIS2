using System;
using System.ComponentModel.DataAnnotations;
namespace ARIS.Entity
{
    public class DeathCerteficate:VitalEvent
    {
        [Display(Name = "Deceased Name")]
        public string DeceasedName { get; set; }
        [Display(Name = "Deceased Father Name")]
        public string DeceasedFatehrName { get; set; }
        [Display(Name = "Deceased Last Name")]
        public string DeceasedLastName { get; set; }
        [Display(Name = "Title/Rank")]
        public string Title { get; set; }
        [Display(Name = "Place Of Death")]
        [DataType(DataType.Date)]
        public DateTime PlaceOfDeath { get; set; }
        [Display(Name = "Date Of Death")]
        [DataType(DataType.Date)]
        public DateTime DateOfDeath { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Death Registration")]
        public DateTime DateOfDeathRegistration { get; set; }
    }
}
