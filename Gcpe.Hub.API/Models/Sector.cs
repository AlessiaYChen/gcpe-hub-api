﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gcpe.Hub.API.Helpers
{
    public class Sector
    {
        public Sector()
        {
            this.Languages = new HashSet<SectorLanguage>();
            this.NewsReleases = new HashSet<NewsRelease>();
            this.Ministries = new HashSet<Ministry>();
        }

        public System.Guid Id { get; set; }
        public string Key { get; set; }
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }
        public string DisplayName { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string MiscHtml { get; set; }
        public string MiscRightHtml { get; set; }
        public string TwitterUsername { get; set; }
        public string FlickrUrl { get; set; }
        public string YoutubeUrl { get; set; }
        public string AudioUrl { get; set; }
        public string FacebookEmbedHtml { get; set; }
        public string YoutubeEmbedHtml { get; set; }
        public string AudioEmbedHtml { get; set; }
        public Nullable<System.Guid> TopReleaseId { get; set; }
        public Nullable<System.Guid> FeatureReleaseId { get; set; }

        public virtual ICollection<SectorLanguage> Languages { get; set; }
        public virtual ICollection<NewsRelease> NewsReleases { get; set; }
        public virtual ICollection<Ministry> Ministries { get; set; }
        public virtual NewsRelease TopRelease { get; set; }
        public virtual NewsRelease FeatureRelease { get; set; }
    }
}
