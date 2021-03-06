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

        public List<string> FindOccurrences(int id, CancellationToken cancellation = default)
        {
            List<string> listOfOccurrences = new List<string>();

            var eventDto = _eventManagerDbContext.Events.Where(e => e.Id == id).FirstOrDefault();

            if (eventDto.TimePeriod == Helper.TimePeriod.Daily)
            {
                for (int i = 1; i <= eventDto.Repetition; i++)
                {
                    listOfOccurrences.Add(eventDto.StartDate.AddDays(7 * i).ToLongDateString());
                    var startDate = eventDto.StartDate.AddDays(i).ToShortDateString();
                    var startTime = eventDto.StartDate.AddHours(1).ToShortTimeString();
                    var endTime = eventDto.EndDate.AddHours(2).ToShortTimeString();
                    string concated = String.Concat(startDate, "-", startTime, " - ", endTime, ")");
                    listOfOccurrences.Add(concated);

                }
                return listOfOccurrences;
            }
            else
            {
                for (int i = 1; i <= eventDto.Repetition; i++)
                {
                    listOfOccurrences.Add(eventDto.StartDate.AddDays(7 * i).ToLongDateString());
                    listOfOccurrences.Add(eventDto.EndDate.AddDays(i + 7).ToLongDateString());
                    var startDate = eventDto.StartDate.AddDays(i).ToShortDateString();
                    var endDate = eventDto.EndDate.AddDays(i).ToShortDateString();
                    var startTime = eventDto.StartDate.AddHours(1).ToShortTimeString();
                    var endTime = eventDto.EndDate.AddHours(2).ToShortTimeString();
                    string concated = String.Concat(startDate, "-", endDate, "( ", startTime, " - ", endTime, ")");
                    listOfOccurrences.Add(concated);
                }
                return listOfOccurrences;
            }
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

            foreach (var date in collection)
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
                Repetition = e.Repetition,
                TimePeriod = e.TimePeriod
            };

            await _eventManagerDbContext.Events.AddAsync(eventDomain, cancellationToken);
            await _eventManagerDbContext.SaveChangesAsync(cancellationToken);

            return new EventViewModel(eventDomain);
        }

        public async Task<EventViewModel> MonthlyView(CancellationToken cancellationToken = default)
        {
            var eventsInDb = await _eventManagerDbContext.Events.ToListAsync();

            DateTime date = DateTime.Now;

            var monthlyList = eventsInDb.Where(x => x.StartDate > date && x.StartDate < date.AddDays(30))
            .ToList();

            return new EventViewModel(monthlyList);
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

        public async Task Update(EventDto e, CancellationToken cancellationToken = default)
        {
            var eventDomain = await _eventManagerDbContext.Events.FirstOrDefaultAsync(x => x.Name == e.Name, cancellationToken);

            eventDomain.Name = e.Name;
            eventDomain.Description = e.Description;
            eventDomain.CreatedById = e.CreateById;
            eventDomain.StartDate = e.StartDate;
            eventDomain.EndDate = e.EndDate;
            eventDomain.Repetition = e.Repetition;
            eventDomain.TimePeriod = e.TimePeriod;

            _eventManagerDbContext.Events.Update(eventDomain);
            await _eventManagerDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}