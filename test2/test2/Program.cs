using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Drawing;


namespace test2
{

    #region Nate's input

    public class SQL_Connection
    {

        public SQL_Connection() { }

        public void openConnection()
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-QM2SFGD;Initial Catalog=Housing;Integrated Security=True";
            connection.Open();
        }

        public void closeConnection()
        {
            connection.Close();
        }
        #region functions that affect the listing database.
        #region Adding a listing

        public void AddListing(Image smallImage, Image largeImage, int listingPrice, String street, String city,
                               String state, String zip, int squareFootage, char[] agentID, char[] agencyID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               "INSERT INTO TABLENAME (smallImage, largeImage, listingPrice, listingStreet, listingCity, listingState, "
                               + "listingZip, listingSquareFootage, agentID, agencyID) VALUES (@smallImage, @largeImage, @listingPrice, "
                               + "@listingStreet, @listingCity, @listingState, @listingZip, @listingSquareFootage, @agentID, @agencyID)";
                    // For each variable just start inserting stuff
                    command.Parameters.Add("@smallImage", SqlDbType.Image);
                    command.Parameters.Add("@largeImage", SqlDbType.Image);
                    command.Parameters.Add("@listingPrice", SqlDbType.Int);
                    command.Parameters.Add("@listingStreet", SqlDbType.NChar);
                    command.Parameters.Add("@listingCity", SqlDbType.NChar);
                    command.Parameters.Add("@listingState", SqlDbType.NChar);
                    command.Parameters.Add("@listingZip", SqlDbType.NChar);
                    command.Parameters.Add("@listingSquareFootage", SqlDbType.Int);
                    command.Parameters.Add("@agentID", SqlDbType.NVarChar);
                    command.Parameters.Add("@agencyID", SqlDbType.NVarChar);

                    command.Parameters["@smallImage"].Value = smallImage;
                    command.Parameters["@largeImage"].Value = largeImage;
                    command.Parameters["@listingPrice"].Value = listingPrice;
                    command.Parameters["@listingStreet"].Value = street.ToCharArray();
                    command.Parameters["@listingCity"].Value = city.ToCharArray();
                    command.Parameters["@listingState"].Value = state.ToCharArray();
                    command.Parameters["@listingZip"].Value = zip.ToCharArray();
                    command.Parameters["@squareFootage"].Value = squareFootage;
                    command.Parameters["@agentID"].Value = agentID;
                    command.Parameters["@agencyID"].Value = agencyID;

                    command.ExecuteNonQuery();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }


        }

        #endregion

        #region updating parts of a listing

        public void UpdatePhotoSmall(Image replacementImage, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET smallImage = @smallImage WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@smallImage", SqlDbType.Image);

                    command.Parameters["@smallImage"].Value = replacementImage;

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }

        public void UpdatePhotoLarge(Image replacementImage, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET largePhoto = @largePhoto WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@largeImage", SqlDbType.Image);

                    command.Parameters["@largeImage"].Value = replacementImage;

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdatePhotoOne(Image replacementImage, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoOne = @extraPhotoOne WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@extraPhotoOne", SqlDbType.Image);

                    command.Parameters["@extraPhotoOne"].Value = replacementImage;

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdatePhotoTwo(Image replacementImage, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoTwo = @extraPhotoTwo WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@extraPhotoTwo", SqlDbType.Image);

                    command.Parameters["@extraPhotoTwo"].Value = replacementImage;

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdatePhotoThree(Image replacementImage, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoThree = @extraPhotoThree WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@extraPhotoThree", SqlDbType.Image);

                    command.Parameters["@extraPhotoThree"].Value = replacementImage;

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdatePhotoFour(Image replacementImage, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoFour = @extraPhotoFour WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@extraPhotoFour", SqlDbType.Image);

                    command.Parameters["@extraPhotoFour"].Value = replacementImage;

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdatePhotoFive(Image replacementImage, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoFive = @extraPhotoFive WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@extraPhotoFive", SqlDbType.Image);

                    command.Parameters["@extraPhotoFive"].Value = replacementImage;

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }


        public void UpdateListingPrice(int replacementPrice, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingPrice = @listingPrice WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@listingPrice", SqlDbType.Int);

                    command.Parameters["@listingPrice"].Value = replacementPrice;

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateStreet(string replacementStreet, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingStreet = @listingStreet WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@listingStreet", SqlDbType.NChar);

                    command.Parameters["@listingStreet"].Value = replacementStreet.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateCity(string replacementCity, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingCity = @listingCity WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@listingCity", SqlDbType.NChar);

                    command.Parameters["@listingCity"].Value = replacementCity.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateState(string replacementState, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingState = @listingState WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@listingState", SqlDbType.NChar);

                    command.Parameters["@listingState"].Value = replacementState.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateZip(string replacementZip, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingZip = @listingZip WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@listingZip", SqlDbType.NChar);

                    command.Parameters["@listingZip"].Value = replacementZip.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateSquareFootage(int replacementSquareFootage, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingSquareFootage = @listingSquareFootage WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@listingSquareFootage", SqlDbType.Int);

                    command.Parameters["@listingSquareFootage"].Value = replacementSquareFootage;

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateDescription(string replacementDescription, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingDescription = @listingDescription WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@listingDescription", SqlDbType.NVarChar);

                    command.Parameters["@listingDescription"].Value = replacementDescription.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateRoomDescription(string replacementRoomDescription, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingRoomDescription = @listingRoomDescription WHERE ",
                                                "listingID='", listingID, "'");
                    command.Parameters.Add("@listingRoomDescription", SqlDbType.NVarChar);

                    command.Parameters["@listingRoomDescription"].Value = replacementRoomDescription.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateSubdivision(string replacementSubdivision, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingSubdivision = @listingSubdivision WHERE ",
                                                "listingID='", listingID, "'");

                    command.Parameters.Add("@listingSubdivision", SqlDbType.NVarChar);
                    command.Parameters["@listingSubdivision"].Value = replacementSubdivision.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        // I don't know if this will work correctly, but it should. -Nate
        public void IncrementDailyHitCount(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingDailyHitCount = listingDailyHitCount + 1 WHERE ",
                                                "listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void ResetDailyHitCount(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingDailyHitCount = 0 WHERE ",
                                                "listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }


        public void UpdateLifetimeHitCount(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingLifetimeHitCount = listingDailyHitCount + listingLifetimeHitCount WHERE ",
                                                "listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAlarmInfo(string replacementAlarmInfo, char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingAlarmInfo = @listingAlarmInfo WHERE ",
                                                "listingID='", listingID, "'");
                    // For each variable just start inserting stuff
                    command.Parameters.Add("@listingAlarmInfo", SqlDbType.NVarChar);

                    command.Parameters["@listingAlarmInfo"].Value = replacementAlarmInfo.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        #endregion

        // This region sets a value to null if used on part of a listing.
        #region deleting part of a listing/removing a listing

        public void RemovePhotoOne(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoOne = NULL WHERE ",
                                                "listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemovePhotoTwo(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoTwo = NULL WHERE ",
                                                "listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemovePhotoThree(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoThree = NULL WHERE ",
                                                "listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemovePhotoFour(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoFour = NULL WHERE ",
                                                "listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemovePhotoFive(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoFive = NULL WHERE ",
                                                "listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemoveSquareFootage(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingSquareFootage = NULL WHERE ",
                                                "listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemoveDescription(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingDescription = NULL WHERE ",
                                                "listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemoveRoomDescription(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingRoomDescription = NULL WHERE ",
                                                "listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemoveSubdivision(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingSubdivision = NULL WHERE ",
                                                "listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemoveAlarmInfo(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingAlarmInfo = NULL WHERE ",
                                                "listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemoveListing(char[] listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("DELETE FROM TABLENAME WHERE listingID='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        #endregion


        #region Retrieving info for listing.

        // Get the number of listings (total).
        public int GetTotalNumberOfListings()
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT COUNT(*) FROM TABLENAME";
                    result = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    result = -1;
                }
            }
            return result;
        }

        // Get the number of listings (from the agent).
        public int GetTotalNumberOfListingsFromAgent(char[] agentID)
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = String.Concat("SELECT COUNT(*) FROM TABLENAME WHERE agentID ='", agentID, "'");
                    result = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    result = -1;
                }
            }
            return result;
        }

        // Get the number of listings (from an agency).
        public int GetTotalNumberOfListingsFromAgency(char[] agencyID)
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = String.Concat("SELECT COUNT(*) FROM TABLENAME WHERE agencyID ='", agencyID, "'");
                    result = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    result = -1;
                }
            }
            return result;
        }

        // Get all listings within a given square footage range.
        public DataTable GetListingsFilterBySquareFootage(int squareFootLow, int squareFootHigh)
        {
            DataTable table = new DataTable();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                        String.Concat("SELECT ALL smallPhoto, listingPrice, listingStreet, listingCity, listingState, ",
                                      "listingZip, listingSquareFootage, agentID, agencyID FROM TABLENAME WHERE ",
                                         "listingSquareFootage BETWEEN @low AND @high");

                    command.Parameters.Add("@low", SqlDbType.Int);
                    command.Parameters.Add("@high", SqlDbType.Int);
                    command.Parameters["@low"].Value = squareFootLow;
                    command.Parameters["@high"].Value = squareFootHigh;

                    table.Columns.Add("smallPhoto");
                    table.Columns.Add("listingPrice");
                    table.Columns.Add("listingStreet");
                    table.Columns.Add("listingCity");
                    table.Columns.Add("listingState");
                    table.Columns.Add("listingZip");
                    table.Columns.Add("listingSquareFootage");
                    table.Columns.Add("agentID");
                    table.Columns.Add("agencyID");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            return table;
        }

        // Get all listings within a given price range.
        public DataTable GetListingsFilterByPriceRange(int costLow, int costHigh)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                        String.Concat("SELECT ALL smallPhoto, listingPrice, listingStreet, listingCity, listingState, ",
                                      "listingZip, listingSquareFootage, agentID, agencyID FROM TABLENAME WHERE ",
                                         "listingPrice BETWEEN @low AND @high");

                    command.Parameters.Add("@low", SqlDbType.Int);
                    command.Parameters.Add("@high", SqlDbType.Int);
                    command.Parameters["@low"].Value = costLow;
                    command.Parameters["@high"].Value = costHigh;

                    table.Columns.Add("smallPhoto");
                    table.Columns.Add("listingPrice");
                    table.Columns.Add("listingStreet");
                    table.Columns.Add("listingCity");
                    table.Columns.Add("listingState");
                    table.Columns.Add("listingZip");
                    table.Columns.Add("listingSquareFootage");
                    table.Columns.Add("agentID");
                    table.Columns.Add("agencyID");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            return table;
        }

        // Get all listings matching the searched zip code.
        public DataTable GetListingsFilterByZipCode(string zip)
        {
            DataTable table = new DataTable();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                        String.Concat("SELECT ALL smallPhoto, listingPrice, listingStreet, listingCity, listingState, ",
                                      "listingZip, listingSquareFootage, agentID, agencyID FROM TABLENAME WHERE ",
                                         "listingZip = @searchZip");

                    command.Parameters.Add("@searchZip", SqlDbType.NChar);
                    command.Parameters["@searchZip"].Value = zip.ToCharArray();

                    table.Columns.Add("smallPhoto");
                    table.Columns.Add("listingPrice");
                    table.Columns.Add("listingStreet");
                    table.Columns.Add("listingCity");
                    table.Columns.Add("listingState");
                    table.Columns.Add("listingZip");
                    table.Columns.Add("listingSquareFootage");
                    table.Columns.Add("agentID");
                    table.Columns.Add("agencyID");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            return table;
        }

        // Get all listings, no filtering.
        public DataTable GetAllListings()
        {
            DataTable table = new DataTable();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                        String.Concat("SELECT ALL smallPhoto, listingPrice, listingStreet, listingCity, listingState, ",
                                          "listingZip, listingSquareFootage, agentID, agencyID FROM TABLENAME");

                    table.Columns.Add("smallPhoto");
                    table.Columns.Add("listingPrice");
                    table.Columns.Add("listingStreet");
                    table.Columns.Add("listingCity");
                    table.Columns.Add("listingState");
                    table.Columns.Add("listingZip");
                    table.Columns.Add("listingSquareFootage");
                    table.Columns.Add("agentID");
                    table.Columns.Add("agencyID");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            return table;
        }

        #endregion

        #endregion

        #region functions that affect the agent database.

        #region Add an agent to the database.
        public void AddAgent(string agent_Fname, string agent_Lname, string agent_Uname, string agent_password, string agent_number,
                             string agent_email, int agency_id, string agent_number2)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               "INSERT INTO agent (agent_Fname, agent_Lname, agent_Uname, agent_password, agent_number, agent_email, agency_id,"
                               + "agent_number2) VALUES (@agent_Fname, @agent_Lname, @agent_Uname, @agent_password,  @agent_number, @agent_email, @agency_id, "
                               + "@agent_number2)";
                    // For each variable just start inserting stuff
                    command.Parameters.Add("@agent_Fname", SqlDbType.NVarChar);
                    command.Parameters.Add("@agent_Lname", SqlDbType.NVarChar);
                    command.Parameters.Add("@agent_Uname", SqlDbType.NVarChar);
                    command.Parameters.Add("@agent_password", SqlDbType.NVarChar);
                    command.Parameters.Add("@agent_number", SqlDbType.NVarChar);
                    command.Parameters.Add("@agent_email", SqlDbType.NVarChar);
                    command.Parameters.Add("@agency_id", SqlDbType.NVarChar);
                    command.Parameters.Add("@agent_number2", SqlDbType.NVarChar);

                    command.Parameters["@agent_Fname"].Value = agent_Fname.ToCharArray();
                    command.Parameters["@agent_Lname"].Value = agent_Lname.ToCharArray();
                    command.Parameters["@agent_Uname"].Value = agent_Uname.ToCharArray();
                    command.Parameters["@agent_password"].Value = agent_password.ToCharArray();
                    command.Parameters["@agent_number"].Value = agent_number.ToCharArray();
                    command.Parameters["@agent_email"].Value = agent_email.ToCharArray();
                    command.Parameters["@agency_id"].Value = agency_id;
                    command.Parameters["@agent_number2"].Value = agent_number2.ToCharArray();

                    command.ExecuteNonQuery();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }


        }
        #endregion

        #region Update parts of an agent in the agent database.

        public void UpdateAgentFirstName(string firstName, int agent_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE agent SET agent_Fname = @agent_Fname WHERE ",
                                                "agent_id='", agent_id, "'");
                    command.Parameters.Add("@agent_Fname", SqlDbType.NVarChar);

                    command.Parameters["@agent_Fname"].Value = firstName.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAgentLastName(string lastName, int agent_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE agent SET agent_Lname = @agent_Lname WHERE ",
                                             "agent_id='", agent_id, "'");
                    command.Parameters.Add("@agent_Lname", SqlDbType.NVarChar);

                    command.Parameters["@agent_Lname"].Value = lastName.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAgentUsername(string userName, int agent_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE agent SET agent_Uname = @agent_Uname WHERE ",
                                             "agent_id='", agent_id, "'");
                    command.Parameters.Add("@agent_Uname", SqlDbType.NVarChar);

                    command.Parameters["@agent_Uname"].Value = userName.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAgentPassword(string password, int agent_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE agent SET agent_password = @agent_password WHERE ",
                                             "agent_id='", agent_id, "'");
                    command.Parameters.Add("@agent_password", SqlDbType.NVarChar);

                    command.Parameters["@agent_password"].Value = password.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAgentNumber(string phoneNumber, int agent_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE agent SET agent_number = @agent_number WHERE ",
                                                "agent_id='", agent_id, "'");
                    command.Parameters.Add("@agent_number", SqlDbType.NVarChar);

                    command.Parameters["@agent_number"].Value = phoneNumber.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAgentEmail(string email, int agent_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE agent SET agent_email = @agent_email WHERE ",
                                                "agent_id='", agent_id, "'");
                    command.Parameters.Add("@agent_email", SqlDbType.NVarChar);

                    command.Parameters["@agent_email"].Value = email.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        #endregion

        #region Delete an agent
        public void DeleteAgent(int agent_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("DELETE FROM agent WHERE agent_id='", agent_id, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        #endregion

        #region Retrieve stuff from the agent database.

        public int GetTotalNumberOfAgentsUsingService()
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT COUNT(*) FROM agent";
                    result = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    result = -1;
                }
            }
            return result;
        }

        public int GetTotalNumberOfAgentsWithAgency(int agency_id)
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = String.Concat("SELECT COUNT(*) FROM agent WHERE agency_id='", agency_id, "'");
                    result = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    result = -1;
                }
            }
            return result;
        }

        public string GetAgentFirstName(int agent_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = String.Concat("SELECT agent_Fname FROM agent WHERE agent_id='", agent_id, "'");
                    result = Convert.ToString(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    result = "error";
                }
            }
            return result;
        }

        public string GetAgentLastName(int agent_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = String.Concat("SELECT agent_Lname FROM agent WHERE agent_id='", agent_id, "'");
                    result = Convert.ToString(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    result = "error";
                }
            }
            return result;
        }

        public string GetAgentUserName(int agent_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = String.Concat("SELECT agent_Uname FROM agent WHERE agent_id='", agent_id, "'");
                    result = Convert.ToString(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    result = "error";
                }
            }
            return result;
        }

        public bool GetAgentPassword(int agent_id, string enteredPassword)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = String.Concat("SELECT agent_passwd FROM agent WHERE agent_id='", agent_id, "'");
                    result = Convert.ToString(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    result = "error";
                }
            }
            return String.Equals(enteredPassword, result);
        }

        public string GetAgentPhoneNumber(int agent_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = String.Concat("SELECT agent_number FROM agent WHERE agent_id='", agent_id, "'");
                    result = Convert.ToString(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    result = "error";
                }
            }
            return result;
        }

        public string GetAgentEmail(int agent_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = String.Concat("SELECT agent_email FROM agent WHERE agent_id='", agent_id, "'");
                    result = Convert.ToString(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    result = "error";
                }
            }
            return result;
        }

        public int GetAgencyOfAgent(int agent_id)
        {
            int result = -1;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = String.Concat("SELECT agency_id FROM agent WHERE agent_id='", agent_id, "'");
                    result = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    result = -1;
                }
            }
            return result;
        }

        public DataTable GetAgent(int agent_id)
        {
            DataTable table = new DataTable();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                        String.Concat("SELECT ALL agent_Fname, agent_Lname, agent_number, agent_email, agency_id ",
                                      "FROM agent WHERE agent_id='",agent_id, "'");

                    table.Columns.Add("agent_Fname");
                    table.Columns.Add("agent_Lname");
                    table.Columns.Add("agent_number");
                    table.Columns.Add("agent_email");
                    table.Columns.Add("agency_id");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            return table;
        }

        public DataTable GetAllAgents()
        {
            DataTable table = new DataTable();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                        String.Concat("SELECT ALL agent_Fname, agent_Lname, agent_number, agent_email, agent_id, ",
                                          "agency_id FROM agent");

                    table.Columns.Add("agent_Fname");
                    table.Columns.Add("agent_Lname");
                    table.Columns.Add("agent_number");
                    table.Columns.Add("agent_email");
                    table.Columns.Add("agent_id");
                    table.Columns.Add("agency_id");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            return table;
        }

        public DataTable GetAllAgentsFromAgency(int agency_id)
        {
            DataTable table = new DataTable();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                        String.Concat("SELECT ALL agent_Fname, agent_Lname, agent_number, agent_email, agent_id ",
                                      "FROM agent WHERE agency_id='", agency_id, "'");

                    table.Columns.Add("agent_Fname");
                    table.Columns.Add("agent_Lname");
                    table.Columns.Add("agent_number");
                    table.Columns.Add("agent_email");
                    table.Columns.Add("agent_id");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            return table;
        }

        #endregion

        #endregion



        #region functions that affect the agency database.

        #region Add an agency to the database.
        public void AddAgency(string agency_name, string agency_email, string agency_phone, string agency_street,
                              string agency_city, string agency_state, string agency_zip)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               "INSERT INTO TABLENAME (agency_name, agency_email, agency_phone, agency_street, agency_city, agency_state, "
                               + "agency_zip) VALUES (@agency_name, @agency_email, @agency_phone, @agency_street, @agency_city, @agency_state, "
                               + "@agency_zip)";
                    // For each variable just start inserting stuff
                    command.Parameters.Add("@agency_name", SqlDbType.NVarChar);
                    command.Parameters.Add("@agency_email", SqlDbType.NVarChar);
                    command.Parameters.Add("@agency_phone", SqlDbType.NVarChar);
                    command.Parameters.Add("@agency_street", SqlDbType.NVarChar);
                    command.Parameters.Add("@agency_city", SqlDbType.NVarChar);
                    command.Parameters.Add("@agency_state", SqlDbType.NVarChar);
                    command.Parameters.Add("@agency_zip", SqlDbType.NVarChar);

                    command.Parameters["@agency_name"].Value = agency_name.ToCharArray();
                    command.Parameters["@agency_email"].Value = agency_email.ToCharArray();
                    command.Parameters["@agency_phone"].Value = agency_phone.ToCharArray();
                    command.Parameters["@agency_street"].Value = agency_street.ToCharArray();
                    command.Parameters["@agency_city"].Value = agency_city.ToCharArray();
                    command.Parameters["@agency_state"].Value = agency_state.ToCharArray();
                    command.Parameters["@agency_zip"].Value = agency_zip;

                    command.ExecuteNonQuery();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
        }
        #endregion

        #region Update parts of an agent in the agency database.

        public void UpdateAgencyName(string name, char[] agencyID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET agency_name = @agency_name WHERE ",
                                                "agencyID='", agencyID, "'");
                    command.Parameters.Add("@agency_name", SqlDbType.NVarChar);

                    command.Parameters["@agency_name"].Value = name.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAgencyEmail(string email, char[] agencyID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET agency_email = @agency_email WHERE ",
                                                "agencyID='", agencyID, "'");
                    command.Parameters.Add("@agency_email", SqlDbType.NVarChar);

                    command.Parameters["@agency_email"].Value = email.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAgencyPhone(string phoneNumber, char[] agencyID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET agent_number = @agent_number WHERE ",
                                                "agencyID='", agencyID, "'");
                    command.Parameters.Add("@agent_number", SqlDbType.NVarChar);

                    command.Parameters["@agent_number"].Value = phoneNumber.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAgencyStreet(string street, char[] agencyID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET agency_street = @agency_street WHERE ",
                                                "agencyID='", agencyID, "'");
                    command.Parameters.Add("@agency_street", SqlDbType.NVarChar);

                    command.Parameters["@agency_street"].Value = street.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAgencyCity(string city, char[] agencyID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET agency_city = @agency_city WHERE ",
                                                "agencyID='", agencyID, "'");
                    command.Parameters.Add("@agency_city", SqlDbType.NVarChar);

                    command.Parameters["@agency_city"].Value = city.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAgencyState(string state, char[] agencyID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET agency_state = @agency_state WHERE ",
                                                "agencyID='", agencyID, "'");
                    command.Parameters.Add("@agency_state", SqlDbType.NVarChar);

                    command.Parameters["@agency_state"].Value = state.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAgencyZip(string zip, char[] agencyID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET agency_zip = @agency_zip WHERE ",
                                                "agencyID='", agencyID, "'");
                    command.Parameters.Add("@agency_zip", SqlDbType.NVarChar);

                    command.Parameters["@agency_zip"].Value = zip.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        #endregion

        #region Remove/Delete items in the agency database.
        public void DeleteAgency(char[] agencyID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("DELETE FROM TABLENAME WHERE agencyID='", agencyID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        #endregion

        #region Retrieve stuff from the agency database.

        public int GetTotalNumberOfAgencies()
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT COUNT(*) FROM TABLENAME";
                    result = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    result = -1;
                }
            }
            return result;
        }

        public DataTable GetAllAgencies()
        {
            DataTable table = new DataTable();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT ALL agency_name, agency_email, agency_phone, agency_street, agency_city, "
                                          + "agency_state, agency_zip FROM TABLENAME";

                    table.Columns.Add("agency_name");
                    table.Columns.Add("agency_email");
                    table.Columns.Add("agency_phone");
                    table.Columns.Add("agency_street");
                    table.Columns.Add("agency_city");
                    table.Columns.Add("agency_state");
                    table.Columns.Add("agency_zip");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            return table;
        }

        public DataTable GetAgency(char[] agencyID)
        {
            DataTable table = new DataTable();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                        String.Concat("SELECT ALL agency_name, agency_email, agency_phone, agency_street, agency_city, ",
                                      "agency_state, agency_zip FROM TABLENAME WHERE agencyID='", agencyID, "'");

                    table.Columns.Add("agency_name");
                    table.Columns.Add("agency_email");
                    table.Columns.Add("agency_phone");
                    table.Columns.Add("agency_street");
                    table.Columns.Add("agency_city");
                    table.Columns.Add("agency_state");
                    table.Columns.Add("agency_zip");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            return table;
        }


        #endregion

        #endregion




        public void getText(DataTable myTable)
        {
            DataRow row = myTable.Rows[0];
            String outputString = myTable.Columns["testDescription"].ToString();
            Console.WriteLine(outputString);
            outputString = row["testDescription"].ToString();
            Console.WriteLine(outputString);
        }

        private SqlConnection connection;
        private SqlCommand command;

    }
    #endregion

    //************************************************************************
    class Program
    {
        static void Main(string[] args)
        {
            string conString = "Data Source=DESKTOP-QM2SFGD;Initial Catalog=Housing;Integrated Security=True";

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SQL_Connection tester = new SQL_Connection();

            //connect to sql database 
            if (con.State == System.Data.ConnectionState.Open)
            {
                //initilize data to variables
                string name = "Destruction";
                string email = "death.org";
                string phone = "6669996666";
                string street = "666 Street";
                string state = "666 City";
                string city = "999 Death Row";
                string agency_zip = "66666";

                string fName = "BENJ";
                string lName = "stateFarm";
                string userName = "Jake";
                string password = "fromStateFarm";
                string number = "345559999";
                string email2 = "Jake@stateFarm";
                int agency_id = 5;
                string number2 = "1234567890";
                int agent_id = 10;

                //begin testing code here
                //******************************//
                //char[] a = agency_id.ToCharArray();
                //char[] b = agent_id.ToCharArray();

                //******************************//
                //end testing code here
                tester.openConnection();
                string temp1 = tester.GetAgentEmail(2);
                DataTable temp = tester.GetAgent(2);
                //test table
                foreach (DataRow row in temp.Rows)
                {
                    Console.WriteLine("----------row------------");
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write("item:  ");
                        Console.WriteLine(item);
                    }
                }

                //Console.WriteLine();
                //tester.AddAgent(fName, lName, userName,password,number2, email2, agency_id, number2);
                //Int16 zip = 3580;

                //int zip = 45678;
                // string q = "insert into agency(agency_name,agency_email,agency_phone,agency_street,agency_state,agency_city,agency_zip)values('" + name + "','" + email + "','" + phone + " ','" + street + "','" + state + " ','" + city + "','" + agency_zip + "')";
                //SqlCommand cmd = new SqlCommand(q, con);
                //cmd.ExecuteNonQuery();

                //push data into sql database.
                //string z = "insert into agent(agent_Fname,agent_Lname,agent_Uname,agent_password,agent_number,agent_email,agency_id,agent_number2)values('" + fName + "','" + lName + "','" + userName + " ','" + password + "','" + number + " ','" + email2 + "','" + agency_id + "','" + number2 + "')";
                //SqlCommand cmd1 = new SqlCommand(z, con);
                //cmd1.ExecuteNonQuery();

                //MessageBox.Show("Connection made successfully!");
                //Console.WriteLine("connect successfully");
            }
            else
            {
                Console.WriteLine("Failed to connect");
            }
        }
    }
}
