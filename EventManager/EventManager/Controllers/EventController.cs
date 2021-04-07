using EventManager.Dal.Repositories;
using EventManager.Dal.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EventManager.Controllers
{
    [Route("api/[controller]/[action]")]
    public class EventController : Controller
    {
        private readonly IEventRepository _eventRepository;

        public EventController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var e = await _eventRepository.GetById(id);
            return Ok(e);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetEventsPeriod(string name)
        {
            var e = await _eventRepository.GetEventsPeriod(name);
            return Ok(e);
        }

        [HttpGet]
        public async Task<IActionResult> GetTopTen()
        {
            var e = await _eventRepository.GetTopTen();
            return Ok(e);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] EventDto eventDto)
        {
            try
            {
                var e = await _eventRepository.Insert(eventDto);
                return Ok(e);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Remove(int id)
        {
            var e = await _eventRepository.Remove(id);

            return Ok(e);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] EventDto eventDto)
        {
            try
            {
                await _eventRepository.Update(eventDto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet("{name}")]
        public async Task<IActionResult> SearchName(string name)
        {
            var events = await _eventRepository.SearchName(name);
            return Ok(events);
        }

        [HttpGet("{startDate}")]
        public async Task<IActionResult> SearchByStartDate(DateTime startDate)
        {
            var events = await _eventRepository.SearchByStartDate(startDate);
            return Ok(events);
        }

        [HttpGet("{endDate}")]
        public async Task<IActionResult> SearchByEndDate(DateTime endDate)
        {
            var events = await _eventRepository.SearchByEndDate(endDate);
            return Ok(events);
        }
    }
}