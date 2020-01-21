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
        [Display(Name = "Their Name")]
        public string CelebrantName { get; set; }

        
        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }


        
        public int MonthId { get; set; }
        public Month Month { get; set; }

        
        public int DayId { get; set; }
        public Day Day { get; set; }
        
        [Range(4,4)]
        public int? Year { get; set; }

        public bool Deleted { get; set; }


        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}