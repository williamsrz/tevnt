using System;
using TheEvnt.Models;
using System.Threading.Tasks;

namespace TheEvnt.Services
{
    public interface IEventService
    {
        Task<Event> GetEventAsync();
    }
}

