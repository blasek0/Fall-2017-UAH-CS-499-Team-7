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
        HttpCookie _userInfo = Request.Cookies["_userInfo"];        //creates _userInfo cookie


        if (_userInfo != null)
        {
            Response.Redirect("agentMain.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string conString = "Data Source=DESKTOP-KFI49LK;Initial Catalog=Housing;Integrated Security=True";

        using (SqlConnection con = new SqlConnection(conString))
        {
            con.Open();
            string checkUser = "Select count(*) from agent where agent_Uname= '" + TextBoxUN.Text + "'";
            SqlCommand com = new SqlCommand(checkUser, con);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());         //if temp equals 1 then the result for a username came back as true

            if (temp == 1)
            {
                string checkPass = "Select agent_password from agent where agent_Uname= '" + TextBoxUN.Text + "'";
                SqlCommand passCom = new SqlCommand(checkPass, con);
                string password = passCom.ExecuteScalar().ToString();       //checks database for password

                if (password == TextBoxPW.Text)                             //compares password given to one in database. If password is in the database then we create a cookie. Store in it agent_id and agency_id then redirect user to main page.
                {
                    string getAgentID = "Select agent_id from agent where agent_Uname ='" + TextBoxUN.Text + "'";
                    SqlCommand getID = new SqlCommand(getAgentID, con);
                    string agent_id = getID.ExecuteScalar().ToString();

                    string getAgencyID = "Select agency_id from agent where agent_Uname ='" + TextBoxUN.Text + "'";
                    SqlCommand getAID = new SqlCommand(getAgencyID, con);
                    string agency_id = getAID.ExecuteScalar().ToString();

                    HttpCookie _userInfo = new HttpCookie("_userInfo");
                    _userInfo["AgencyID"] = agency_id;
                    _userInfo["AgentID"] = agent_id;
                    Response.Cookies.Add(_userInfo);
                    


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