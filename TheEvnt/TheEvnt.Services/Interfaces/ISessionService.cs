using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using TheEvnt.Models;

namespace TheEvnt.Services
{
    public interface ISessionService
    {
        Task<List<Session>> GetSessionsAsync();

        Task<List<Session>> GetSessionsByDayAsync(DateTime date);

        Task<List<Session>> GetSessionsByTrackAsync(string trackId);

        Task<List<Session>> GetSessionsBySpeakerAsync(string speakerId);
    }
}

