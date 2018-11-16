﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gcpe.Hub.API.Helpers
{
    public class Ministry
    {
        public Ministry()
        {
            this.Languages = new HashSet<MinistryLanguage>();
            this.NewsReleases = new HashSet<NewsRelease>();
            this.NewsReleaseLeads = new HashSet<NewsRelease>();
            this.Sectors = new HashSet<Sector>();
            this.Children = new HashSet<Ministry>();
            this.Services = new HashSet<MinistryService>();
            this.Topics = new HashSet<MinistryTopic>();
            this.Newsletters = new HashSet<MinistryNewsletter>();
        }

        public System.Guid Id { get; set; }
        public string Key { get; set; }
        public int SortOrder { get; set; }
        public string DisplayName { get; set; }
        public string Abbreviation { get; set; }
        public bool IsActive { get; set; }
        public string MinisterEmail { get; set; }
        public string MinisterPhotoUrl { get; set; }
        public string MinisterPageHtml { get; set; }
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
        public string MinisterAddress { get; set; }
        public string MinisterName { get; set; }
        public string MinisterSummary { get; set; }
        public Nullable<System.Guid> ParentId { get; set; }
        public string MinistryUrl { get; set; }
        public Nullable<int> ContactUserId { get; set; }
        public Nullable<int> SecondContactUserId { get; set; }
        public string WeekendContactNumber { get; set; }
        public Nullable<System.DateTimeOffset> EodFinalizedDateTime { get; set; }
        public Nullable<int> EodLastRunUserId { get; set; }
        public Nullable<System.DateTimeOffset> EodLastRunDateTime { get; set; }
        public string DisplayAdditionalName { get; set; }

        public virtual ICollection<MinistryLanguage> Languages { get; set; }
        public virtual ICollection<NewsRelease> NewsReleases { get; set; }
        public virtual ICollection<NewsRelease> NewsReleaseLeads { get; set; }
        public virtual ICollection<Sector> Sectors { get; set; }
        public virtual NewsRelease TopRelease { get; set; }
        public virtual NewsRelease FeatureRelease { get; set; }
        public virtual Ministry Parent { get; set; }
        public virtual ICollection<Ministry> Children { get; set; }
        public virtual ICollection<MinistryService> Services { get; set; }
        public virtual ICollection<MinistryTopic> Topics { get; set; }
        public virtual ICollection<MinistryNewsletter> Newsletters { get; set; }
        public virtual SystemUser ContactUser { get; set; }
        public virtual SystemUser EodLastRunUser { get; set; }
        public virtual SystemUser SecondContactUser { get; set; }
    }
}
