namespace ARIS.Entity
{
    public interface IUnitOfWork
    {
        IRepository<Resident> Residents { get; }
        IRepository<House> Houses { get; }
        IRepository<Userr> Userres { get; }
        IRepository<Payment> Payments { get; }
        IRepository<NewResident> NewResidents { get; }
        IRepository<Person> Persons { get; }
        IRepository<BirthCertefcate> BirthCertefcates { get; }
        IRepository<MarrageCerteficate> MarrageCerteficates { get; }
        IRepository<DeathCerteficate> DeathCerteficates { get; }
        IRepository<VitalEvent> VitalEvents { get; }
    }
}
