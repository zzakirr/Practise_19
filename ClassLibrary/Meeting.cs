using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibrary
{
    public class Meeting
    {
        public DateTime FromDate = new DateTime();
        public DateTime ToDate = new DateTime();
        
        public string  MeetingName { get; set; }
    }
}
