using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;

namespace FrontendTrainingApp
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:54802/api/values/1");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            lblStatus.Text = string.Format("{0} - {1}", (int)response.StatusCode, response.StatusCode);
            lblFromBackend.Text = response.Content;
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            var client = new RestClient(string.Format("http://localhost:54802/api/{0}", txtInput.Text));
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            lblStatus.Text = string.Format("{0} - {1}", (int)response.StatusCode, response.StatusCode);
            lblFromBackend.Text = response.Content;
        }
    }
}