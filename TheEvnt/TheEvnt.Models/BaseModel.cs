using System;

namespace TheEvnt.Models
{
    public class BaseModel
    {
        public string Id
        {
            get;
            set;
        }

        public DateTime CreatedAt
        {
            get;
            set;
        }

        public DateTime UpdatedAt
        {
            get;
            set;
        }

        public DateTime Version
        {
            get;
            set;
        }

        public bool Deleted
        {
            get;
            set;
        }
    }
}

