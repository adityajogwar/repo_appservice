using System;
using System.Web.UI;

namespace WebApplication
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMessage.Text = "Welcome to my ASP.NET web application hosted on IIS 7!";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lblMessage.Text = "Hello, " + name + "! Thanks for submitting the form.";
        }
    }
}
