using AutoMapper;
using EventManager.Dal.Context;
using EventManager.Dal.Domain;
using EventManager.Dal.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EventManager.Dal.Repositories
{
    public class SqlServerEventRepository : IEventRepository
    {
        private readonly EventManagerDbContext _eventManagerDbContext;
        private readonly IMapper _mapper;

        public SqlServerEventRepository(EventManagerDbContext eventManagerDbContext, IMapper mapper)
        {
            _eventManagerDbContext = eventManagerDbContext;
            _mapper = mapper;
        }

        public async Task<EventViewModel> GetById(int id, CancellationToken cancellationToken = default)
        {
            var e = await _eventManagerDbContext.Events.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            return new EventViewModel(e);
        }

        public async Task<List<string>> GetEventsPeriod(string eventName, CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;

            var eventNameCollection = await _eventManagerDbContext.Events
                .Where(e => e.Name == eventName).Where(e => e.StartDate.Date > DateTime.Now)
                .ToListAsync(cancellationToken);

            var collection = eventNameCollection.Take(maxTop).ToList();

            List<string> listOfDates = new List<string>();

            foreach(var date in collection)
            {
                listOfDates.Add(date.StartDate.ToString());
            }

            return listOfDates;
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
                Name = e.Name,
                Description = e.Description,
                CreatedById = e.CreateById,
                StartDate = e.StartDate,
                EndDate = e.EndDate,
                Repetition = e.Repetition
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

        public async Task<EventViewModel> SearchByEndDate(DateTime endDate, CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;

            var eventNameCollection = await _eventManagerDbContext.Events
                .Where(b => b.EndDate == endDate)
                .ToListAsync(cancellationToken);

            var collection = eventNameCollection.Take(maxTop).ToList();
            return new EventViewModel(collection);
        }

        public async Task<EventViewModel> SearchByStartDate(DateTime startDate, CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;

            var eventNameCollection = await _eventManagerDbContext.Events
                .Where(b => b.StartDate == startDate)
                .ToListAsync(cancellationToken);

            var collection = eventNameCollection.Take(maxTop).ToList();
            return new EventViewModel(collection);

        }

        public async Task<EventViewModel> SearchName(string name, CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;

            var eventNameCollection = await _eventManagerDbContext.Events
                .Where(b => b.Name.ToLower().IndexOf(name.ToLower()) != -1)
                .ToListAsync(cancellationToken);

            var collection = eventNameCollection.Take(maxTop).ToList();
            return new EventViewModel(collection);
        }

        public async Task Update(EventDto eventDto, CancellationToken cancellationToken = default)
        {
            var eventDomain = await _eventManagerDbContext.Events
                .FirstOrDefaultAsync(x => x.Name == eventDto.Name, cancellationToken);

            
            eventDomain.Name = eventDto.Name;
            eventDomain.Description = eventDto.Description;
            eventDomain.StartDate = eventDto.StartDate;
            eventDomain.EndDate = eventDto.EndDate;

            _eventManagerDbContext.Events.Update(eventDomain);
            await _eventManagerDbContext.SaveChangesAsync(cancellationToken);

        }
    }
}