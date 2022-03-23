using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenStack_GUI.Models
{
    public static class GlobalSessionDetails
    {
        public static string Protocol { get; set; } = null;
        public static string Domain { get; set; } = null;
        public static string Port { get; set; } = null;
        public static string Username { get; set; } = null;
        public static string Password { get; set; } = null;
        public static string UnscopedToken { get; set; } = null;
        public static string ScopedToken { get; set; } = null;

        public static string ProjectId { get; set; } = null;

        public static User User { get; set; }

        public static bool GetUnscopedToken()
        {
            try
            {
                // POST TO KEYSTONE API (IDENTITY)
                var myWebClient = new WebClient();
                myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";

                //JSON body to be send in the post 
                String jsonToSend = "" +
                        "{" +
                            "\"auth\": {" +
                                "\"identity\": {" +
                                    "\"methods\": [" +
                                        "\"password\"" +
                                    "]," +
                                    "\"password\": {" +
                                        "\"user\": {" +
                                            "\"name\": \"" + Username + "\"," +
                                            "\"domain\": {" +
                                                "\"name\": \"Default\"" +
                                            "}," +
                                            "\"password\": \"" + Password + "\"" +
                                        "}" +
                                    "}" +
                                "}" +
                            "}" +
                        "}";
                //---------------------

                //Send Post to KEYSTONE API (identity)
                var responseString = myWebClient.UploadString(Protocol + "://" + Domain + ":" + Port + "/identity/v3/auth/tokens/", jsonToSend);

                //Get the token from response headers

                WebHeaderCollection myWebHeaderCollection = myWebClient.ResponseHeaders;

                for (int i = 0; i < myWebHeaderCollection.Count; i++)
                {
                    if (myWebHeaderCollection.GetKey(i) == "X-Subject-Token")
                    {
                        UnscopedToken = myWebHeaderCollection.Get(i); // SAVE THE UNSCOPED TOKEN 
                    }
                }

                return true;
            } catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Something went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }


}
