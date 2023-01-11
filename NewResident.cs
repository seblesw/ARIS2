using System;
using System.ComponentModel.DataAnnotations;
namespace ARIS.Entity
{
    public class NewResident:Resident
    {
        [Display(Name = "Prvivous Address")]
        public string PrvivousAddress { get; set; }
        [Display(Name = "Current Zone")]
        public string CurrentZone { get; set; }
        [Display(Name = "Curren tWoreda")]
        public string CurrentWoreda { get; set; }
        [Display(Name = "Current Kebele")]
        public string CurrentKebele { get; set; }
        public Guid NewResidentId { get; set; }
        [Display(Name = "Upload Leave Document")]
        [DataType(DataType.Upload)]
        public string UploadLeaveDoc { get; set; }

    }
}
