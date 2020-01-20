using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using everything_birthday.Models;

namespace everything_birthday.ViewModels
{
    public class EventEntryViewModel
    {
        public EventEntry EventEntry { get; set; }
        public List<EventType> EventTypes { get; set; }
        public List<Month> Months { get; set; }
        public List<Day> Days { get; set; }
    }
}