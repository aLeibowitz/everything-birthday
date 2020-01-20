using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace everything_birthday.Models
{
    public class EventEntry
    {
        public int EventEntryId { get; set; }

        [Required]
        public string CelebrantName { get; set; }

        [Required]
        public EventType EventTypes { get; set; }

        [Required]
        public Month Months { get; set; }

        [Required]
        public Day Days { get; set; }


        public int? Year { get; set; }

        public bool Deleted { get; set; }


        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}