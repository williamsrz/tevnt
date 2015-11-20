using System;
using System.Threading.Tasks;
using TheEvnt.Models;
using System.Collections.Generic;

namespace TheEvnt.Services
{
    public interface ITrackService
    {
        Task<Track> GetTrackAsync(string trackId);

        Task<List<Track>> GetTracksAsync();
    }
}

