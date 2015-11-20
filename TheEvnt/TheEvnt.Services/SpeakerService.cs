using System;
using System.Threading.Tasks;
using TheEvnt.Models;
using System.Collections.Generic;

namespace TheEvnt.Services
{
    public class SpeakerService : ISpeakerService
    {
        public SpeakerService()
        {
        }

        #region ISpeakerService implementation

        public Task<List<Speaker>> GetSpeakersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Speaker> GetSpeakerAsync(string speakerId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

