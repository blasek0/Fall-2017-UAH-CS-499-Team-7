using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class users_display_houses : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection("Data Source=DESKTOP-KFI49LK;Initial Catalog=Housing;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "select * from listing NATURAL JOIN agency";
        cmd.CommandText = "SELECT listing.listing_id, agency.agency_id, listing.listing_zip, listing.pic1, listing.listing_price, listing.listing_street, listing.listing_state, listing.listing_city, listing.listing_zip, listing.listing_sqFT, agency.agency_name FROM agency INNER JOIN listing ON listing.agency_id = agency.agency_id";
        cmd.ExecuteNonQuery();
        

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        d1.DataSource = dt;     //d1 is defined in the source portion of this website page
        d1.DataBind();

        con.Close();
    }
}