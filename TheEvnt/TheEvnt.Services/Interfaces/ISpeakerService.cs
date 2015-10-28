using System;
using TheEvnt.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TheEvnt.Services
{
    public interface ISpeakerService
    {
        Task<Speaker> GetSpeakerAsync(string speakerId);

        Task<List<Speaker>> GetSpeakersAsync();
    }
}

