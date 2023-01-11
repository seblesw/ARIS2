using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ARIS.Entity
{
    public class Resident:Person
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Country  of Birth")]
        public string CountyOfBirth { get;set; }
        [Display(Name = "Zone of the Birth Place")]
        public string ZoneOfBirth { get; set; }
        [Display(Name = "Woreda of Birth Place")]
        public string WoredaOfBirth { get; set; }
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }
        [Display(Name = "Mother Name")]
        public string MotherName { get; set; }
        [Display(Name = "Matital Status")]
        public MaritalStatus MaritalStatus { get; set; }
        [Display(Name = "Ralationship")]
        public Relationship Relationship { get; set; }
        [Display(Name = "Occupation")]
        public string Occupation { get; set; }

        [DisplayName("Upload Fingureprint")]
        [Display(Name = "Fingureprint")]
        [DataType(DataType.Upload)]
        public string FingurePrint { get; set; }
        //public HttpPostedFileBase FingurePrint { get; set; }
        //public string BirtCeretefcate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dddd, dd MMMM yyyy hh:mm tt}")]
        [Display(Name = "Date created")]
        public DateTime CreatedDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dddd, dd MMMM yyyy hh:mm tt}")]
        [Display(Name = "Date modified")]
        public DateTime? ModifiedDate { get; set; }
        //public string FullName => $"{FirstName} {MiddleName} {LastName}";
        //public HttpPostedFileBase BirthCertefcate { get; set; }

    }
}
