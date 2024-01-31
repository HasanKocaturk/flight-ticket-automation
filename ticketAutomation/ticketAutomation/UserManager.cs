using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketAutomation
{
    public static class UserManager
    {
        private static int loggedInUserId;

        public static int LoggedInUserId
        {
            get { return loggedInUserId; }
        }

        public static void SetLoggedInUserId(int userId)
        {
            loggedInUserId = userId;
        }
    }

}
