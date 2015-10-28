using System;
using System.Threading.Tasks;
using TheEvnt.Models;

namespace TheEvnt.Services
{
    public class SpeaketService : ISpeakerService
    {
        public SpeaketService()
        {
        }

        #region ISpeakerService implementation

        public async Task<Speaker> GetSpeakerAsync(string speakerId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

