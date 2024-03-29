﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicLovers.Core.Models.Entities
{
    public class Following
    {
        public ApplicationUser Follower { get; set; }
        public ApplicationUser Followee { get; set; }
        public string FollowerId { get; set; }
        public string FolloweeId { get; set; }
    }
}