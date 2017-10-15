using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;


public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string conString = "Data Source=DESKTOP-KFI49LK;Initial Catalog=Housing;Integrated Security=True";

        using (SqlConnection con = new SqlConnection(conString))
        {
            con.Open();
            string checkUser = "Select count(*) from agent where agent_Uname= '" + TextBoxUN.Text + "'";
            SqlCommand com = new SqlCommand(checkUser, con);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

            if (temp == 1)
            {
                string checkPass = "Select agent_password from agent where agent_Uname= '" + TextBoxUN.Text + "'";
                SqlCommand passCom = new SqlCommand(checkPass, con);
                string password = passCom.ExecuteScalar().ToString();

                if (password == TextBoxPW.Text)
                {
                    Session["New"] = TextBoxUN.Text;          //Creates a session and stores username inside
                    Response.Write("Correct Password");
                    Response.Redirect("agentMain.aspx");   //used to redirect to new page
                }
                else
                {
                    Response.Write("Incorrect Username or password");
                }
            }
            else
            {
                Response.Write("Username is not correct");
            }

        }









    }
}