using System;
using System.Threading.Tasks;
using TheEvnt.Models;
using System.Collections.Generic;

namespace TheEvnt.Services
{
    public class TrackService : ITrackService
    {
        public TrackService()
        {
        }

        #region ITrackServices implementation

        public async Task<Track> GetTrackAsync(string trackId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TheEvnt.Models.Track>> GetTracksAsync()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

