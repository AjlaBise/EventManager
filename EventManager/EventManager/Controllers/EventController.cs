﻿using EventManager.Dal.Repositories;
using EventManager.Dal.ViewModel;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public async Task<IActionResult> GetTopTen ()
        {
            var e = await _eventRepository.GetTopTen();
            return Ok(e);
        }

        [HttpPost]
        public async Task<IActionResult> Insert ([FromBody] EventDto eventDto)
        {
            var e = await _eventRepository.Insert(eventDto);
            return Ok(e);
        }

        [HttpDelete ("{id:int}")]
        public async Task<IActionResult> Remove(int id)
        {
            var e = await _eventRepository.Remove(id);

            return Ok(e);
        }

        [HttpPut]

        public async Task<IActionResult> Update ([FromBody] EventDto eventDto)
        {
            await _eventRepository.Update(eventDto);
            return Ok();
        }
    }
}