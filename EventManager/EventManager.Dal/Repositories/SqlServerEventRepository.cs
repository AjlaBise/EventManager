using EventManager.Dal.Context;
using EventManager.Dal.Domain;
using EventManager.Dal.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EventManager.Dal.Repositories
{
    public class SqlServerEventRepository : IEventRepository
    {
        private readonly EventManagerDbContext _eventManagerDbContext;


        public SqlServerEventRepository(EventManagerDbContext eventManagerDbContext)
        {
            _eventManagerDbContext = eventManagerDbContext;
        }

        public async Task<EventViewModel> GetById(int id, CancellationToken cancellationToken = default)
        {
            var e = await _eventManagerDbContext.Events.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            return new EventViewModel(e);
        }

        public async Task<EventViewModel> GetTopTen(CancellationToken cancellationToken = default)
        {
            const int maxTen = 10;
            var collection = await _eventManagerDbContext.Events.Take(maxTen).ToListAsync(cancellationToken);
            return new EventViewModel(collection);
        }

        public async Task<EventViewModel> Insert(EventDto e, CancellationToken cancellationToken = default)
        {
            var eventDomain = new Event
            {
                Id = e.Id,
                Name = e.Name,
                Description = e.Description,
                CreatedById = e.CreateById,
            };

            await _eventManagerDbContext.Events.AddAsync(eventDomain, cancellationToken);
            await _eventManagerDbContext.SaveChangesAsync(cancellationToken);

            return new EventViewModel(eventDomain);
        }

        public async Task<bool> Remove(int id, CancellationToken cancellationToken = default)
        {
            var eventEntity = await _eventManagerDbContext.Events.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            _eventManagerDbContext.Events.Remove(eventEntity);
            await _eventManagerDbContext.SaveChangesAsync(cancellationToken);
            return true;

        }

        public async Task Update(EventDto eventDto, CancellationToken cancellationToken = default)
        {
            var eventDomain = await _eventManagerDbContext.Events.FirstOrDefaultAsync(x => x.Id == eventDto.Id, cancellationToken);

            eventDomain.Id = eventDto.Id;
            eventDomain.Name = eventDto.Name;
            eventDomain.Description = eventDto.Description;

            _eventManagerDbContext.Events.Update(eventDomain);
            await _eventManagerDbContext.SaveChangesAsync(cancellationToken);
             
        }
    }
}