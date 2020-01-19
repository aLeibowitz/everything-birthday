using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace everything_birthday.Models
{
    public class Day
    {
        public int DayId { get; set; }

        [Display(Name = "Day")]
        public int DayNumber { get; set; }
    }
}