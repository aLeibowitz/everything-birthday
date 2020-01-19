using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace everything_birthday.Models
{
    public class EventEntry
    {
        public int EventEntryId { get; set; }

        [Display(Name = "Whose event is it?")]
        public string CelebrantName { get; set; }

        public EventType EventType { get; set; }

        public Month Month { get; set; }
        public Day Day { get; set; }

        [Display(Name = "Starting from what year? (optional)")]
        public int? Year { get; set; }

        public bool Deleted { get; set; }


        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}