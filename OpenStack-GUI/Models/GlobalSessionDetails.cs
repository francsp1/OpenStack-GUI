using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenStack_GUI.Models
{
    class GlobalSessionDetails
    {
        public static class Globals
        {
            private static string Protocol { get; set; }
            private static string Domain { get; set; }
            private static string Port { get; set; }
            private static string Username { get; set; }
            private static string Psername { get; set; }
            private static string UnscopedToken { get; set; }
            private static string ScopedToken { get; set; }
            
            private static string ProjectId { get; set; }

            private static User User { get; set; }

        }
    }
}
