using System;
using System.Threading.Tasks;
using TheEvnt.Models;
using System.Collections.Generic;

namespace TheEvnt.Services
{
    public interface ITrackServices
    {
        Task<Track> GetTrackAsync(string trackId);

        Task<List<Track>> GetTracksAsync();
    }
}

