using System;
using ProjectFees;

namespace APP_Test
{
    public partial class ProjectCalculation : System.Web.UI.Page
    {
        public decimal BasePrice = 100.00m;
        protected void Page_Load(object sender, EventArgs e)
        {
            ltBasePrice.Text = BasePrice.ToString("C");
        }

        protected void ddlStates_SelectedIndexChanged (object sender, EventArgs e)
        {
            States states = new States();
            decimal fee = states.GetFeeForState(ddlStates.SelectedValue);
            decimal finalPrice = BasePrice + fee; 
            ltCustomPrice.Text = finalPrice.ToString("C");
        }
    }
}