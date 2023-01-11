using ARIS.Entity;
using System;
namespace ARIS.Infrastructor
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DataSource _dbContext;

        public UnitOfWork()
        {
            _dbContext = new DataSource();
        }
        IRepository<Resident> IUnitOfWork.Residents => new Repository<Resident>(_dbContext);
        IRepository<House> IUnitOfWork.Houses => new Repository<House>(_dbContext);
        IRepository<Userr> IUnitOfWork.Userres => new Repository<Userr>(_dbContext);
        IRepository<VitalEvent> IUnitOfWork.VitalEvents => new Repository<VitalEvent>(_dbContext);
        IRepository<Person> IUnitOfWork.Persons => new Repository<Person>(_dbContext);
        IRepository<NewResident> IUnitOfWork.NewResidents => new Repository<NewResident>(_dbContext);
        IRepository<BirthCertefcate> IUnitOfWork.BirthCertefcates => new Repository<BirthCertefcate>(_dbContext);
        IRepository<DeathCerteficate> IUnitOfWork.DeathCerteficates => new Repository<DeathCerteficate>(_dbContext);
        IRepository<MarrageCerteficate> IUnitOfWork.MarrageCerteficates => new Repository<MarrageCerteficate>(_dbContext);
        IRepository<Payment> IUnitOfWork.Payments => new Repository<Payment>(_dbContext);
        private bool _disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
