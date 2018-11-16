﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gcpe.Hub.API.Helpers
{
    public class SystemUser
    {
        public SystemUser()
        {
            this.Ministries = new HashSet<Ministry>();
            this.Ministries1 = new HashSet<Ministry>();
            this.Ministries2 = new HashSet<Ministry>();
            this.SystemUser1 = new HashSet<SystemUser>();
            this.SystemUser11 = new HashSet<SystemUser>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public int RoleId { get; set; }
        public string Description { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string JobTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<int> FilterDisplayValue { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDateTime { get; set; }
        public Nullable<int> LastUpdatedBy { get; set; }
        public byte[] TimeStamp { get; set; }
        public System.Guid RowGuid { get; set; }
        public string HiddenColumns { get; set; }

        public virtual ICollection<Ministry> Ministries { get; set; }
        public virtual ICollection<Ministry> Ministries1 { get; set; }
        public virtual ICollection<Ministry> Ministries2 { get; set; }
        public virtual ICollection<SystemUser> SystemUser1 { get; set; }
        public virtual SystemUser SystemUser2 { get; set; }
        public virtual ICollection<SystemUser> SystemUser11 { get; set; }
        public virtual SystemUser SystemUser3 { get; set; }
    }
}
