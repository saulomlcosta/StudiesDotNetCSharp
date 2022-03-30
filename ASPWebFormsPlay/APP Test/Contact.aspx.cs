using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APP_Test
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            divMessage.Visible = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = $"You said your name is {txtName.Text}, your email is {txtEmail.Text}, your age is {txtAge.Text}, you have {ddlColor.Text} as your favorite color.";

            divMessage.Visible = true;

            ltMessage.Text = message;

        }
    }
}