﻿namespace FishMap.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using FishMap.Data.Common.Models;

    public class GroupTrip : BaseDeletableModel<int>
    {
        public GroupTrip()
        {
            this.Guests = new HashSet<UserGroupTrip>();
        }

        public DateTime MeetingTime { get; set; }

        [Range(-90, 90)]
        public float MeetingSpotLatitude { get; set; }

        [Range(-180, 180)]
        public float MeetingSpotLongtitude { get; set; }

        public DateTime FishingTime { get; set; }

        [Range(-90, 90)]
        public float FishingSpotLatitued { get; set; }

        [Range(-180, 180)]
        public float FishingSpotLongtitude { get; set; }

        [Range(1, 10)]
        public int FreeSeats { get; set; }

        [Required]
        public FishingMethod FishingMethod { get; set; }

        public int TargetFishSpeciesId { get; set; }

        public virtual FishSpecies TargetFishSpecies { get; set; }

        public string HostId { get; set; }

        public virtual ApplicationUser Host { get; set; }

        public virtual ICollection<UserGroupTrip> Guests { get; set; }
    }
}