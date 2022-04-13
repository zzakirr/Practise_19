using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class YetExistMeeting:Exception
    {
        public YetExistMeeting(string message):base(message)
        {

        }
    }
}
