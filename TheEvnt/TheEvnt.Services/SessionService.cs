using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using TheEvnt.Models;

namespace TheEvnt.Services
{
    public class SessionService : ISessionService
    {
        public SessionService()
        {
            
        }

        #region ISessionService implementation

        public async Task<List<Session>> GetSessionsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Session>> GetSessionsByDayAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Session>> GetSessionsByTrackAsync(string trackId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Session>> GetSessionsBySpeakerAsync(string speakerId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

