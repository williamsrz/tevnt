using System;
using System.Threading.Tasks;
using TheEvnt.Models;
using System.Collections.Generic;

namespace TheEvnt.Services
{
    public interface ISponsorService
    {
        Task<Sponsor> GetSponsorAsync(string sponsorId);

        Task<List<Sponsor>> GetSponsorsAsync();
    }
}

