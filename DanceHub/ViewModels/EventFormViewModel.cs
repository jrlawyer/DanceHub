using DanceHub.Models;
using System.Collections.Generic;


namespace DanceHub.ViewModels
{
    public class EventFormViewModel
    {
        public string Location { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int EventType { get; set; }
        public IEnumerable<EventType> EventTypes { get; set; }
    }
}