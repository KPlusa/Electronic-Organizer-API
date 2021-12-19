﻿using System;
using System.Collections.Generic;

namespace Electronic_Organizer_API.Models
{
    public partial class EndUser
    {
        public EndUser()
        {
            EndUserSecurities = new HashSet<EndUserSecurity>();
            Services = new HashSet<Service>();
            Timetables = new HashSet<Timetable>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }

        public virtual ICollection<EndUserSecurity> EndUserSecurities { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
    }
}
