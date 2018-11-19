﻿using System;
using System.ComponentModel.DataAnnotations;
using Gcpe.Hub.API.Helpers;

namespace Gcpe.Hub.API.ViewModels
{
    public class NewsReleaseLogViewModel
    {
        public int Id { get; set; }
        public System.Guid ReleaseId { get; set; }
        public System.DateTimeOffset DateTime { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        public virtual NewsRelease Release { get; set; }
        public virtual User User { get; set; }
    }
}
