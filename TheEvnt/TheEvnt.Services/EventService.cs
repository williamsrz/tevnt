using System;
using System.Threading.Tasks;
using TheEvnt.Models;

namespace TheEvnt.Services
{
    public class EventService : IEventService
    {
        public EventService()
        {
        }

        #region IEventService implementation

        public async Task<Event> GetEventAsync()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

