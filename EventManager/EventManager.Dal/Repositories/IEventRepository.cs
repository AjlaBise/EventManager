using EventManager.Dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EventManager.Dal.Repositories
{
    public interface IEventRepository
    {
        Task<EventViewModel> GetTopTen(CancellationToken cancellationToken = default);

        Task<EventViewModel> GetEventsPeriod(string eventName, CancellationToken cancellationToken = default);

        Task<EventViewModel> GetById(int id, CancellationToken cancellationToken = default);

        Task<EventViewModel> Insert(EventDto e, CancellationToken cancellationToken = default);

        Task Update(EventDto eventDto, CancellationToken cancellationToken = default);

        Task<bool> Remove(int id, CancellationToken cancellationToken = default);

        Task<EventViewModel> SearchName(string name, CancellationToken cancellationToken = default);

        Task<EventViewModel> SearchByStartDate(DateTime startDate, CancellationToken cancellationToken = default);

        Task<EventViewModel> SearchByEndDate(DateTime endDate, CancellationToken cancellationToken = default);

    }
}