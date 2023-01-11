using System.ComponentModel.DataAnnotations;
namespace ARIS.Entity
{
    public class BirthCertefcate:VitalEvent
    {
        [Display(Name = "Native Name")]
        public string Name { get; set; }
        [Display(Name = "Mother Name")]
        public string MotherName { get; set; }
        [Display(Name = "RegionCityAdmnstration")]
        public string RegionCityAdmnstration { get; set; }
        [Display(Name = "Zone City Admnstration")]
        public string ZoneCityAdmnstration { get; set; }

    }
}
