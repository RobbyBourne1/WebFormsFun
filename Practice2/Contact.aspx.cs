using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectFees2;


namespace Practice2
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            States states = new States();
            decimal fee = states.GetFeeForState(ddStates.SelectedValue);
            ltCustomPrice.Text = fee.ToString("C");

        }
    }
}