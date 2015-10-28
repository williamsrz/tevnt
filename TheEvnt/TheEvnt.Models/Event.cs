using System;
using System.Collections.Generic;

namespace TheEvnt.Models
{
    public class Event : BaseModel
    {
        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string CoverImageUrl
        {
            get;
            set;
        }

        public string RegistrationUrl
        {
            get;
            set;
        }

        public string WebsiteUrl
        {
            get;
            set;
        }

        public List<Sponsor> Sponsors
        {
            get;
            set;
        }

        public Event()
        {
            Sponsors = new List<Sponsor>();
        }
    }
}

