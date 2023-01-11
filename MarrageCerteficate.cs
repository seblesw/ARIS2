using System;
using System.ComponentModel.DataAnnotations;
namespace ARIS.Entity
{
    public class MarrageCerteficate:VitalEvent
    {
        [Display(Name = "Wife Name")]
        public string WifeName { get; set; }
        [Display(Name = "Wife Father Name")]
        public string WifeFatehrName { get; set; }
        [Display(Name = "Wife Last Name")]
        public string WifeLastName { get; set; }
        [Display(Name = "Husband Name")]
        public string HusbandName { get; set; }
        [Display(Name = " Hasband Father Name")]
        public string HusbandFartherName { get; set; }
        [Display(Name = "Hasband Last Name")]
        public string HusbandLastName { get; set; }
        [Display(Name = "Father Name")]
        public DateTime DateOfMarrage { get; set; }
        [Display(Name = "Father Name")]
        public string PlaceOfMarrgeRegistration { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Marrge")]
        public string DateOfMarrge { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Marrge Registration")]
        public string DateOfMarrgeRegistration { get; set; }


    }
}
