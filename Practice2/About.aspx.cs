using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice2
{
    public partial class About : Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            bool isPostBack = Page.IsPostBack;
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            labeInit.Text = "Text Set During Init";
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
           
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            bool isPostBack = Page.IsPostBack;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPageLoad.Text = "Text set during page load";

            if(Page.IsPostBack)
            {
                lblPostBack.Text = "Info has been Posted Back";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            
        }

        protected void Page_Unload(object sender, EventArgs e)
        {

        }


    }
}