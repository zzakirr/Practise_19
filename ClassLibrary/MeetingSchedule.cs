using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MeetingSchedule
    {
        public List<Meeting> meetingList = new List<Meeting>();
        public void SetMeeting(string fullname,DateTime from,DateTime to)
        {
            Meeting meeting = new Meeting();
            //Console.WriteLine("Name:");
            meeting.MeetingName = fullname;
            //Console.WriteLine("baslama tarixi");
            meeting.FromDate = from;
            //Console.WriteLine("bitmetarixi");
            meeting.ToDate = to;
           if(meetingList.Count == 0)
            {
                meetingList.Add(meeting);
                return;
            }
                
            bool check = true;
            foreach (var item in meetingList)
            {
                if((to>item.FromDate && to<item.ToDate)|| (from > item.FromDate && from < item.ToDate))
                    check = false;
            }
            if (check)
                meetingList.Add(meeting);
            else
                throw new YetExistMeeting("Bu tarixde meeting var!");
        }
        public int FindMeetingsCount(DateTime dateTime)
        {
            //List<Meeting> newMeetingList = new List<Meeting>();
            /*int count = 0;
            foreach (var item in meetingList)
            {
                if (item.FromDate > dateTime)
                    count++;
            }
            return count; */
            Predicate<Meeting> predicate = x => x.FromDate > dateTime;
            int count = 0;
            foreach (var item in meetingList.FindAll(predicate))
            {
                count++;
            }
            return count;
        }
        public bool IsExistsMeetingByName(string name)
        {
            Predicate<Meeting> predicate = x => x.MeetingName == name;
            return meetingList.Exists(predicate);
        }
        public List<Meeting> GetExistMeetings(string name)
        {
            List<Meeting> newMeetings = new List<Meeting>();
            Predicate<Meeting> predicate = x => x.MeetingName == name;
            foreach (var item in meetingList.FindAll(predicate))
            {
                newMeetings.Add(item);
            }
            return newMeetings;
        }

    }
}
