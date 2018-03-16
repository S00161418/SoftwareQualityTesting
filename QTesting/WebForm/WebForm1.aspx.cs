using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QTesting;

namespace WebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Premium p1 = new Premium();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string[] gender = { "male", "female" };
            DropDownList1.DataSource = gender;
            DropDownList1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            tbxPremium.Text = Convert.ToString(p1.CalculatePremium(Convert.ToInt32(tbxAge.Text), DropDownList1.SelectedItem.Text));



        }
    }
}