using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace everything_birthday.Models
{
    public class BirthdayEntry
    {
        public int BirthdayEntryId { get; set; }

        [Display(Name = "Whose birthday?")]
        public string BirthdayPersonName { get; set; }

        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; } 

        public Month Month { get; set; }
        public Day Day { get; set; }
        public int? Year { get; set; }
        public bool Deleted { get; set; }


        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}