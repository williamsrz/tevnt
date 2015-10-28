using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using TheEvnt.Models;

namespace TheEvnt.Services
{
    public class SponsorService : ISponsorService
    {
        public SponsorService()
        {
        }

        #region ISponsorService implementation

        public async Task<Sponsor> GetSponsorAsync(string sponsorId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Sponsor>> GetSponsorsAsync()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

