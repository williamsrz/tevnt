using System;
using System.Collections.Generic;

namespace TheEvnt.Models
{
    public class Session : BaseModel
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

        public DateTime Day
        {
            get;
            set;
        }

        public DateTime StartAtTime
        {
            get;
            set;
        }

        public DateTime EndAtTime
        {
            get;
            set;
        }

        public Lang Lang
        {
            get;
            set;
        }

        public Complexity Complexity
        {
            get;
            set;
        }

        public string CoverImageUrl
        {
            get;
            set;
        }

        public List<Speaker> Speakers
        {
            get;
            set;
        }

        public string TrakId
        {
            get;
            set;
        }

        public Session()
        {
            Speakers = new List<Speaker>();
        }
    }
}

