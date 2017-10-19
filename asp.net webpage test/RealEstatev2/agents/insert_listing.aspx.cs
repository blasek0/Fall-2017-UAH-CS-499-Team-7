using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.IO;

public partial class agents_insert_listing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie _userInfo = Request.Cookies["_userInfo"];


        if (_userInfo == null)
        {
            Response.Redirect("login.aspx");
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie _userInfo = Request.Cookies["_userInfo"];
        _userInfo.Expires = DateTime.Now.AddDays(-1d);
        Response.Cookies.Add(_userInfo);
        Response.Redirect("login.aspx");
    }

    protected void b1_Click(object sender, EventArgs e)
    {
        SqlCommand command;
        string conString = "Data Source=DESKTOP-KFI49LK;Initial Catalog=Housing;Integrated Security=True";
        string agent_id = null;
        string agency_id = null;
        string picture1, picture2, picture3, picture4, picture5, picture6;


        picture1 = Path.GetFileName(pic1.FileName);
        pic1.SaveAs(Server.MapPath("~") + picture1);

        picture2 = Path.GetFileName(pic2.FileName);
        pic2.SaveAs(Server.MapPath("~") + picture2);

        picture3 = Path.GetFileName(pic3.FileName);
        pic3.SaveAs(Server.MapPath("~") + picture3);

        picture4 = Path.GetFileName(pic4.FileName);
        pic4.SaveAs(Server.MapPath("~") + picture4);

        picture5 = Path.GetFileName(pic5.FileName);
        pic5.SaveAs(Server.MapPath("~") + picture5);

        picture6 = Path.GetFileName(pic6.FileName);
        pic6.SaveAs(Server.MapPath("~") + picture6);

        /*
        picture1 = pic1.FileName.ToString();
        picture2 =  pic2.FileName.ToString();
        picture3 =  pic3.FileName.ToString();
        picture4 =  pic4.FileName.ToString();
        picture5 =  pic5.FileName.ToString();
        picture6 =  pic6.FileName.ToString();

        
        byte[] byte1 = Encoding.UTF8.GetBytes(picture1);
        var encode1 = Convert.ToBase64String(byte1);

        byte[] byte2 = Encoding.UTF8.GetBytes(picture2);
        var encode2 = Convert.ToBase64String(byte2);

        byte[] byte3 = Encoding.UTF8.GetBytes(picture3);
        var encode3 = Convert.ToBase64String(byte3);

        byte[] byte4 = Encoding.UTF8.GetBytes(picture4);
        var encode4 = Convert.ToBase64String(byte4);

        byte[] byte5 = Encoding.UTF8.GetBytes(picture5);
        var encode5 = Convert.ToBase64String(byte5);

        byte[] byte6 = Encoding.UTF8.GetBytes(picture6);
        var encode6 = Convert.ToBase64String(byte6);

    */

        byte[] encodePic1 = pic1.FileBytes;
        byte[] encodePic2 = pic2.FileBytes;
        byte[] encodePic3 = pic3.FileBytes;
        byte[] encodePic4 = pic4.FileBytes;
        byte[] encodePic5 = pic5.FileBytes;
        byte[] encodePic6 = pic6.FileBytes;


        HttpCookie reqCookies = Request.Cookies["_userInfo"];
        if(reqCookies != null)
        {
            agent_id = reqCookies["AgentID"].ToString();
            agency_id = reqCookies["AgencyID"].ToString();
        }
        

        using (SqlConnection con = new SqlConnection(conString))
        {

            int agentID;
            int agencyID;
            agentID = Convert.ToInt32(agent_id);
            agencyID = Convert.ToInt32(agency_id);

            
            
            con.Open();
            string sql = "INSERT INTO listing(pic1,pic2,pic3,pic4,pic5,pic6,listing_price,listing_street,listing_state,listing_city,listing_zip,listing_sqFT,listing_description,listing_roomDescription,listing_shortDescription,listing_nameSubDivision,listing_alarmInfo,agent_id,agency_id)VALUES(@img1, @img2, @img3, @img4, @img5, @img6,'" + listing_price.Text + "','" + listing_street.Text + "','" + listing_state.Text + "','" + listing_city.Text + "','" + listing_zip.Text + "','" + listing_sqFT.Text + "','" + listing_description.Text + "','" + listing_roomDescription.Text + "','" + listing_shortDescription.Text + "','" + listing_nameSubDivision.Text + "','" + listing_alarmInfo.Text + "','" + agent_id + "','" + agency_id + "')";

            command = new SqlCommand(sql, con);
            command.Parameters.Add(new SqlParameter("@img1", encodePic1));
            command.Parameters.Add(new SqlParameter("@img2", encodePic2));
            command.Parameters.Add(new SqlParameter("@img3", encodePic3));
            command.Parameters.Add(new SqlParameter("@img4", encodePic4));
            command.Parameters.Add(new SqlParameter("@img5", encodePic5));
            command.Parameters.Add(new SqlParameter("@img6", encodePic6));

            int x = command.ExecuteNonQuery();
                con.Close();
        }
    }
}