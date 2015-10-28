using System;

namespace TheEvnt.Models
{
    public class Sponsor : BaseModel
    {
        public string Name
        {
            get;
            set;
        }

        public string LogoImageUrl
        {
            get;
            set;
        }

        public string WebsiteUrl
        {
            get;
            set;
        }
    }
}

