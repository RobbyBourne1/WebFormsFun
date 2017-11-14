using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice2
{
    public partial class _Default : Page
    {
        private List<MyToDo> MyToDos;
        protected void Page_Load(object sender, EventArgs e)
        {
            divMessage.Attributes.Add("style", "color:green");

            if(!Page.IsPostBack)
            {
                Session["MyToDos"] = new List<MyToDo>();
            }
        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Contact");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = string.Format("Name is {0} and number is {1} and age is {2}. favorite color is {3}",
                txtName.Text, txtNumber.Text, txtAge.Text, ddColor.SelectedValue);
            ltMessage.Text = message;
        }

        protected void btnToDo_Click(object sender, EventArgs e)
        {
            UpdateToDos();
            BindToDos();
        }

        private void UpdateToDos()
        {
            if(Session["MyToDos"] != null)
            {
                MyToDos = (List<MyToDo>)Session["MyToDos"];
            }
            else
            {
                MyToDos = new List<MyToDo>();
            }

            MyToDos.Add(new MyToDo(txtToDo.Text, calendarToDo.SelectedDate));

            Session["MyToDos"] = MyToDos;
        }

        private void BindToDos()
        {
            rptToDO.DataSource = MyToDos;
            rptToDO.DataBind();
        }

        public class MyToDo
        {
            public string ToDoName { get; set; }
            public string ToDoDate { get; set; }
            public MyToDo(string todoName, DateTime todoDate)
            {
                ToDoName = todoName;
                ToDoDate = todoDate.ToShortDateString();
            }
        }
    }
}