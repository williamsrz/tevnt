using System;
using System.Collections.Generic;

namespace TheEvnt.Models
{
    public class Track : BaseModel
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

        public List<Session> Sessions
        {
            get;
            set;
        }

        public string CoverImageUrl
        {
            get;
            set;
        }

        public Track()
        {
            Sessions = new List<Session>();
        }
    }
}

