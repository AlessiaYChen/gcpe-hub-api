﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gcpe.Hub.API.Helpers
{
    public class Tag
    {
        public Tag()
        {
            this.NewsReleases = new HashSet<NewsRelease>();
        }

        public System.Guid Id { get; set; }
        public string Key { get; set; }
        public string DisplayName { get; set; }
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<NewsRelease> NewsReleases { get; set; }
    }
}
