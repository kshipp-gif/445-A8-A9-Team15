using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static _445_A8_A9_Team15.imageVerifier;

namespace _445_A8_A9_Team15
{
    public partial class CaptchaControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImageString.ImageUrl = "imageVerifier.aspx";
        }
    }
}