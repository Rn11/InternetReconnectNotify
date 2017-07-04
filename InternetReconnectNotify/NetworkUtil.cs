using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetReconnectNotify
{
    class NetworkUtil
    {
        public bool checkNetwork(String url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            using (WebResponse response = (HttpWebResponse)request.GetResponse())
            {
                try
                {
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
