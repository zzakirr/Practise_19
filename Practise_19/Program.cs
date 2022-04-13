using System;
using ClassLibrary;
namespace Practise_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule meetingSchedule = new MeetingSchedule();
            var meet1dat1 = new DateTime(2022, 04, 10, 10, 0, 0);
            var meet1dat2 = new DateTime(2022,04,10, 14, 0, 0);
            meetingSchedule.SetMeeting("imtahan1", meet1dat1, meet1dat2);
            try
            {
                var meet2dat1 = new DateTime(2022, 04, 11, 10, 0, 0);
                var meet2dat2 = new DateTime(2022, 04, 11, 14, 0, 0);
                meetingSchedule.SetMeeting("imtahan1", meet2dat1, meet2dat2);

                var meet3dat1 = new DateTime(2022, 04, 12, 10, 0, 0);
                var meet3dat2 = new DateTime(2022, 04, 12, 14, 0, 0);
                meetingSchedule.SetMeeting("imtahan3", meet3dat1, meet3dat2);
            }
            catch (YetExistMeeting ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            
            foreach (var item in meetingSchedule.meetingList)
            {
                Console.WriteLine(item.MeetingName + "\n" + item.FromDate + "\n" + item.ToDate);
            }

            var afterDate = new DateTime(2022, 04, 11, 0, 0, 0);
            Console.WriteLine(meetingSchedule.FindMeetingsCount(afterDate));

            Console.WriteLine(meetingSchedule.IsExistsMeetingByName("imtahan3") );

            
            foreach (var item in meetingSchedule.GetExistMeetings("imtahan1"))
            {
                Console.WriteLine(item.MeetingName + "\n" + item.FromDate + "\n" + item.ToDate);
            }

        }
    }
}
