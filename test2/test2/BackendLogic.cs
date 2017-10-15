﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace test2
{

    #region Nate's input
    // Hi me!
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
                               String state, String zip, int squareFootage, string agentID, string agencyID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               "INSERT INTO TABLENAME (listing_smallImage, listing_largeImage, listing_price, listing_street, listing_city, listing_state, "
                               + "listing_zip, listing_sqFT, agentID, agencyID) VALUES (@smallImage, @largeImage, @listingPrice, "
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

                    command.Parameters["@smallImage"].Value = ImagetoByte(smallImage);
                    command.Parameters["@largeImage"].Value = ImagetoByte(largeImage);
                    command.Parameters["@listingPrice"].Value = listingPrice;
                    command.Parameters["@listingStreet"].Value = street.ToCharArray();
                    command.Parameters["@listingCity"].Value = city.ToCharArray();
                    command.Parameters["@listingState"].Value = state.ToCharArray();
                    command.Parameters["@listingZip"].Value = zip.ToCharArray();
                    command.Parameters["@squareFootage"].Value = squareFootage;
                    command.Parameters["@agentID"].Value = agentID.ToCharArray();
                    command.Parameters["@agencyID"].Value = agencyID.ToCharArray();

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

        public void UpdatePhotoSmall(Image replacementImage, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_smallPhoto = @listing_smallPhoto WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@listing_smallPhoto", SqlDbType.Image);

                    command.Parameters["@listing_smallPhoto"].Value = ImagetoByte(replacementImage);

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }

        public void UpdatePhotoLarge(Image replacementImage, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_largePhoto = @listing_largePhoto WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@listing_largePhoto", SqlDbType.Image);

                    command.Parameters["@listing_largePhoto"].Value = ImagetoByte(replacementImage);

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdatePhotoOne(Image replacementImage, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET pic1 = @pic1 WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@pic1", SqlDbType.Image);

                    command.Parameters["@pic1"].Value = ImagetoByte(replacementImage);

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdatePhotoTwo(Image replacementImage, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET pic2 = @pic2 WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@pic2", SqlDbType.Image);

                    command.Parameters["@pic2"].Value = ImagetoByte(replacementImage);

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdatePhotoThree(Image replacementImage, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET pic3 = @pic3 WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@pic3", SqlDbType.Image);

                    command.Parameters["@pic3"].Value = ImagetoByte(replacementImage);

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdatePhotoFour(Image replacementImage, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET pic4 = @pic4 WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@pic4", SqlDbType.Image);

                    command.Parameters["@pic4"].Value = ImagetoByte(replacementImage);

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdatePhotoFive(Image replacementImage, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET pic5 = @pic5 WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@pic5", SqlDbType.Image);

                    command.Parameters["@pic5"].Value = ImagetoByte(replacementImage);

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateListingPrice(int replacementPrice, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_price = @listing_price WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@listing_price", SqlDbType.Int);

                    command.Parameters["@listing_price"].Value = replacementPrice;

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateStreet(string replacementStreet, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_street = @listing_street WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@listing_street", SqlDbType.NChar);

                    command.Parameters["@listing_street"].Value = replacementStreet.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateCity(string replacementCity, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_city = @listing_city WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@listing_city", SqlDbType.NChar);

                    command.Parameters["@listing_city"].Value = replacementCity.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateState(string replacementState, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_state = @listing_state WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@listing_state", SqlDbType.NChar);

                    command.Parameters["@listing_state"].Value = replacementState.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateZip(string replacementZip, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_zip = @listing_zip WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@listing_zip", SqlDbType.NChar);

                    command.Parameters["@listing_zip"].Value = replacementZip.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateSquareFootage(int replacementSquareFootage, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_sqFT = @listing_sqFT WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@listing_sqFT", SqlDbType.Int);

                    command.Parameters["@listing_sqFT"].Value = replacementSquareFootage;

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateDescription(string replacementDescription, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_description = @listing_description WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@listing_description", SqlDbType.NVarChar);

                    command.Parameters["@listing_description"].Value = replacementDescription.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateRoomDescription(string replacementRoomDescription, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_roomDescription = @listing_roomDescription WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@listing_roomDescription", SqlDbType.NVarChar);

                    command.Parameters["@listing_roomDescription"].Value = replacementRoomDescription.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateShortDescription(string replacementShortDescription, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_shortDescription = @listing_shortDescription WHERE ",
                                                "listing_id='", listing_id, "'");
                    command.Parameters.Add("@listing_shortDescription", SqlDbType.NVarChar);

                    command.Parameters["@listing_shortDescription"].Value = replacementShortDescription.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateSubdivision(string replacementSubdivision, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_nameSubdivision = @listing_nameSubdivision WHERE ",
                                                "listing_id='", listing_id, "'");

                    command.Parameters.Add("@listing_nameSubdivision", SqlDbType.NVarChar);
                    command.Parameters["@listing_nameSubdivision"].Value = replacementSubdivision.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        // I don't know if this will work correctly, but it should. -Nate
        public void IncrementDailyHitCount(int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_hitCount = listing_hitCount + 1 WHERE ",
                                                "listing_id='", listing_id, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void ResetDailyHitCount(int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_hitCount = 0 WHERE ",
                                                "listing_id='", listing_id, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateLifetimeHitCount(int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listingLifetimeHitCount = listing_HitCount + listingLifetimeHitCount WHERE ",
                                                "listing_id='", listing_id, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAlarmInfo(string replacementAlarmInfo, int listing_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE listing SET listing_alarmInfo = @listing_alarmInfo WHERE ",
                                                "listing_id='", listing_id, "'");
                    // For each variable just start inserting stuff
                    command.Parameters.Add("@listing_alarmInfo", SqlDbType.NVarChar);

                    command.Parameters["@listing_alarmInfo"].Value = replacementAlarmInfo.ToCharArray();

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

        public void RemovePhotoOne(int listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoOne = NULL WHERE ",
                                                "listing_id='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemovePhotoTwo(int listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoTwo = NULL WHERE ",
                                             "listing_id='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemovePhotoThree(int listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoThree = NULL WHERE ",
                                             "listing_id='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemovePhotoFour(int listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoFour = NULL WHERE ",
                                             "listing_id='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemovePhotoFive(int listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET extraPhotoFive = NULL WHERE ",
                                             "listing_id='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemoveSquareFootage(int listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingSquareFootage = NULL WHERE ",
                                             "listing_id='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemoveDescription(int listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingDescription = NULL WHERE ",
                                             "listing_id='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemoveRoomDescription(int listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingRoomDescription = NULL WHERE ",
                                             "listing_id='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemoveSubdivision(int listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingSubdivision = NULL WHERE ",
                                             "listing_id='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemoveAlarmInfo(int listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE TABLENAME SET listingAlarmInfo = NULL WHERE ",
                                             "listing_id='", listingID, "'");

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void RemoveListing(int listingID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("DELETE FROM TABLENAME WHERE listing_id='", listingID, "'");

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
        public int GetTotalNumberOfListingsFromAgent(string agentID)
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = String.Concat("SELECT COUNT(*) FROM TABLENAME WHERE agent_id ='", agentID.ToCharArray(), "'");
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
        public int GetTotalNumberOfListingsFromAgency(string agencyID)
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = String.Concat("SELECT COUNT(*) FROM TABLENAME WHERE agency_id ='", agencyID.ToCharArray(), "'");
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
                        String.Concat("SELECT ALL listing_smallPhoto, listing_price, listing_street, listing_city, listing_state, ",
                                      "listing_zip, listing_sqFT, agent_id, agency_id FROM listing WHERE ",
                                         "listing_sqFT BETWEEN @low AND @high");

                    command.Parameters.Add("@low", SqlDbType.Int);
                    command.Parameters.Add("@high", SqlDbType.Int);
                    command.Parameters["@low"].Value = squareFootLow;
                    command.Parameters["@high"].Value = squareFootHigh;

                    table.Columns.Add("listing_smallPhoto");
                    table.Columns.Add("listing_price");
                    table.Columns.Add("listing_street");
                    table.Columns.Add("listing_city");
                    table.Columns.Add("listing_state");
                    table.Columns.Add("listing_zip");
                    table.Columns.Add("listing_sqFT");
                    table.Columns.Add("agent_id");
                    table.Columns.Add("agency_id");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                        foreach (DataRow row in table.Rows)
                        {
                            Byte[] dataStream = new Byte[0];
                            dataStream = (Byte[])(row["listing_smallPhoto"]);
                            row["listing_smallPhoto"] = BytetoImage(dataStream);
                        }
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
                               String.Concat("SELECT ALL listing_smallPhoto, listing_price, listing_street, listing_city, listing_state, ",
                                      "listing_zip, listing_sqFT, agent_id, agency_id FROM listing WHERE ",
                                         "listingPrice BETWEEN @low AND @high");

                    command.Parameters.Add("@low", SqlDbType.Int);
                    command.Parameters.Add("@high", SqlDbType.Int);
                    command.Parameters["@low"].Value = costLow;
                    command.Parameters["@high"].Value = costHigh;

                    table.Columns.Add("listing_smallPhoto");
                    table.Columns.Add("listing_price");
                    table.Columns.Add("listing_street");
                    table.Columns.Add("listing_city");
                    table.Columns.Add("listing_state");
                    table.Columns.Add("listing_zip");
                    table.Columns.Add("listing_sqFT");
                    table.Columns.Add("agent_id");
                    table.Columns.Add("agency_id");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                        foreach (DataRow row in table.Rows)
                        {
                            Byte[] dataStream = new Byte[0];
                            dataStream = (Byte[])(row["listing_smallPhoto"]);
                            row["listing_smallPhoto"] = BytetoImage(dataStream);
                        }
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
                               String.Concat("SELECT ALL listing_smallPhoto, listing_price, listing_street, listing_city, listing_state, ",
                                      "listing_zip, listing_sqFT, agent_id, agency_id FROM listing WHERE ",
                                         "listingZip = @searchZip");

                    command.Parameters.Add("@searchZip", SqlDbType.NChar);
                    command.Parameters["@searchZip"].Value = zip.ToCharArray();

                    table.Columns.Add("listing_smallPhoto");
                    table.Columns.Add("listing_price");
                    table.Columns.Add("listing_street");
                    table.Columns.Add("listing_city");
                    table.Columns.Add("listing_state");
                    table.Columns.Add("listing_zip");
                    table.Columns.Add("listing_sqFT");
                    table.Columns.Add("agent_id");
                    table.Columns.Add("agency_id");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                        foreach (DataRow row in table.Rows)
                        {
                            Byte[] dataStream = new Byte[0];
                            dataStream = (Byte[])(row["listing_smallPhoto"]);
                            row["listing_smallPhoto"] = BytetoImage(dataStream);
                        }
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
                               String.Concat("SELECT ALL listing_smallPhoto, listing_price, listing_street, listing_city, listing_state, ",
                                             "listing_zip, listing_sqFT, agent_id, agency_id FROM");

                    table.Columns.Add("listing_smallPhoto");
                    table.Columns.Add("listing_price");
                    table.Columns.Add("listing_street");
                    table.Columns.Add("listing_city");
                    table.Columns.Add("listing_state");
                    table.Columns.Add("listing_zip");
                    table.Columns.Add("listing_sqFT");
                    table.Columns.Add("agent_id");
                    table.Columns.Add("agency_id");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);

                        foreach (DataRow row in table.Rows)
                        {
                            Byte[] dataStream = new Byte[0];
                            dataStream = (Byte[])(row["listing_smallPhoto"]);
                            row["listing_smallPhoto"] = BytetoImage(dataStream);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            return table;
        }

        // Get all info for one specific listing. To be used for the agent detailed page.
        public DataTable GetSpecificListing(int listingID)
        {
            DataTable table = new DataTable();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM TABLENAME WHERE listing_id = @listingID";

                    command.Parameters.Add("@listingID", SqlDbType.Int);
                    command.Parameters["@listingID"].Value = listingID;

                    table.Columns.Add("listing_smallPhoto");
                    table.Columns.Add("listing_largePhoto");
                    table.Columns.Add("pic1");
                    table.Columns.Add("pic2");
                    table.Columns.Add("pic3");
                    table.Columns.Add("pic4");
                    table.Columns.Add("pic5");
                    table.Columns.Add("listing_price");
                    table.Columns.Add("listing_street");
                    table.Columns.Add("listing_city");
                    table.Columns.Add("listing_state");
                    table.Columns.Add("listing_zip");
                    table.Columns.Add("listing_sqFT");
                    table.Columns.Add("listing_description");
                    table.Columns.Add("listing_roomDescription");
                    table.Columns.Add("listing_short_Description");
                    table.Columns.Add("listing_nameSubdivision");
                    table.Columns.Add("listing_alarmInfo");
                    table.Columns.Add("listing_hitCount");
                    table.Columns.Add("listingLifetimeHitCount");
                    table.Columns.Add("agent_id");
                    table.Columns.Add("agency_id");


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                        foreach (DataRow row in table.Rows)
                        {
                            Byte[] dataStream = new Byte[0];

                            dataStream = (Byte[])(row["listing_smallPhoto"]);
                            row["listing_smallPhoto"] = BytetoImage(dataStream);

                            dataStream = (Byte[])(row["listing_largePhoto"]);
                            row["listing_largePhoto"] = BytetoImage(dataStream);

                            dataStream = (Byte[])(row["pic1"]);
                            row["pic1"] = BytetoImage(dataStream);

                            dataStream = (Byte[])(row["pic2"]);
                            row["pic2"] = BytetoImage(dataStream);

                            dataStream = (Byte[])(row["pic3"]);
                            row["pic3"] = BytetoImage(dataStream);

                            dataStream = (Byte[])(row["pic4"]);
                            row["pic4"] = BytetoImage(dataStream);

                            dataStream = (Byte[])(row["pic5"]);
                            row["pic5"] = BytetoImage(dataStream);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            return table;
        }

        //
        // Get the large photo for a specific listing
        public Image GetLargePhoto(int listing_id)
        {
            Image image = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_largePhoto FROM TABLENAME WHERE listing_id = @listingID";

                    command.Parameters.Add("@listingID", SqlDbType.Int);
                    command.Parameters["@listingID"].Value = listing_id;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        if (dataSet.Tables[0].Rows.Count == 1)
                        {
                            Byte[] dataStream = new Byte[0];
                            dataStream = (Byte[])(dataSet.Tables[0].Rows[0]["listing_largePhoto"]);
                            image = BytetoImage(dataStream);
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return image;
        }

        // Get the small photo for a specific listing.
        public Image GetSmallPhoto(int listing_id)
        {
            Image image = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_smallPhoto FROM TABLENAME WHERE listing_id = @listingID";

                    command.Parameters.Add("@listingID", SqlDbType.Int);
                    command.Parameters["@listingID"].Value = listing_id;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        if (dataSet.Tables[0].Rows.Count == 1)
                        {
                            Byte[] dataStream = new Byte[0];
                            dataStream = (Byte[])(dataSet.Tables[0].Rows[0]["listing_smallPhoto"]);
                            image = BytetoImage(dataStream);
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return image;
        }

        // Get the first extra picture for a specific listing.
        public Image GetPhotoOne(int listing_id)
        {
            Image image = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT pic1 FROM TABLENAME WHERE listing_id = @listingID";

                    command.Parameters.Add("@listingID", SqlDbType.Int);
                    command.Parameters["@listingID"].Value = listing_id;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        if (dataSet.Tables[0].Rows.Count == 1)
                        {
                            Byte[] dataStream = new Byte[0];
                            dataStream = (Byte[])(dataSet.Tables[0].Rows[0]["pic1"]);
                            image = BytetoImage(dataStream);
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return image;
        }

        // Get the second extra picture for a specific listing.
        public Image GetPhotoTwo(int listing_id)
        {
            Image image = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT pic2 FROM TABLENAME WHERE listing_id = @listingID";

                    command.Parameters.Add("@listingID", SqlDbType.Int);
                    command.Parameters["@listingID"].Value = listing_id;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        if (dataSet.Tables[0].Rows.Count == 1)
                        {
                            Byte[] dataStream = new Byte[0];
                            dataStream = (Byte[])(dataSet.Tables[0].Rows[0]["pic2"]);
                            image = BytetoImage(dataStream);
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return image;
        }

        // Get the third extra picture for a specific listing.
        public Image GetPhotoThree(int listing_id)
        {
            Image image = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT pic3 FROM TABLENAME WHERE listing_id = @listingID";

                    command.Parameters.Add("@listingID", SqlDbType.Int);
                    command.Parameters["@listingID"].Value = listing_id;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        if (dataSet.Tables[0].Rows.Count == 1)
                        {
                            Byte[] dataStream = new Byte[0];
                            dataStream = (Byte[])(dataSet.Tables[0].Rows[0]["pic3"]);
                            image = BytetoImage(dataStream);
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return image;
        }

        // Get the fourth extra picture for a specific listing.
        public Image GetPhotoFour(int listing_id)
        {
            Image image = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT pic4 FROM TABLENAME WHERE listing_id = @listingID";

                    command.Parameters.Add("@listingID", SqlDbType.Int);
                    command.Parameters["@listingID"].Value = listing_id;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        if (dataSet.Tables[0].Rows.Count == 1)
                        {
                            Byte[] dataStream = new Byte[0];
                            dataStream = (Byte[])(dataSet.Tables[0].Rows[0]["pic4"]);
                            image = BytetoImage(dataStream);
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return image;
        }

        // Get the fifth extra picture for a specific listing.
        public Image GetPhotoFive(int listing_id)
        {
            Image image = null;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT pic5 FROM TABLENAME WHERE listing_id = @listingID";

                    command.Parameters.Add("@listingID", SqlDbType.Int);
                    command.Parameters["@listingID"].Value = listing_id;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        if (dataSet.Tables[0].Rows.Count == 1)
                        {
                            Byte[] dataStream = new Byte[0];
                            dataStream = (Byte[])(dataSet.Tables[0].Rows[0]["pic5"]);
                            image = BytetoImage(dataStream);
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return image;
        }

        // Get the listing price for a specific listing.
        public int GetListingPrice(int listing_id)
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_price FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;
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

        // Get the listing street for a specific listing.
        public string GetListingStreet(int listing_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_street FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing",SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;

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

        // Get the listing city for a specific listing.
        public string GetListingCity(int listing_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_city FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;

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

        // Get the listing state for a specific listing.
        public string GetListingState(int listing_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_state FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;

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

        // Get the listing zip code for a specific listing.
        public string GetListingZip(int listing_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_zip FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;

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

        // Get the listing square footage for a specific listing.
        public int GetListingSquareFootage(int listing_id)
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_sqFT FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;
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

        // Get the short description for a specific listing.
        public string GetListingShortDescription(int listing_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_shortDescription FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;

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

        // Get the description for a specific listing.
        public string GetListingDescription(int listing_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_description FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;

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

        // Get the room description for a specific listing.
        public string GetListingRoomDescription(int listing_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_roomDescription FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;

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

        // Get the subdivision for a specific listing.
        public string GetListingSubdivision(int listing_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_nameSubdivision FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;

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

        // Get the alarm information for a specific listing.
        public string GetListingAlarmInfo(int listing_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_alarmInfo FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;

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

        // Get the daily hit count for a specific listing.
        public int GetListingDailyHitCount(int listing_id)
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listing_hitCount FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;
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

        // Get the lifetime hit count for a specific listing.
        public int GetListingLifetimeHitCount(int listing_id)
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT listingLifetimeHitCount FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;
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

        // Get the listing agent id for a specific listing.
        public string GetListingAgentID(int listing_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT agent_id FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;

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

        // Get the agency id for a specific listing.
        public string GetListingAgencyID(int listing_id)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT agency_id FROM listing WHERE listing_id = @listing";
                    command.Parameters.Add("@listing", SqlDbType.Int);
                    command.Parameters["@listing"].Value = listing_id;

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

        public int GetAgentID(String username)
		{
			int result = 0;
			using (SqlCommand command = new SqlCommand())
			{
				try
				{
					command.Connection = connection;
					command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT agent_id FROM agent WHERE agent_Uname = @username";
                    command.Parameters.Add("@username",SqlDbType.NVarChar);
                    command.Parameters["@username"].Value = username.ToCharArray();
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

        public bool CheckAgentPassword(string username, string enteredPassword)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT agent_passwd FROM agent WHERE agent_Uname = @username";
                    command.Parameters.Add("@username", SqlDbType.NVarChar);
                    command.Parameters["@username"].Value = username.ToCharArray();
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
                                      "FROM agent WHERE agent_id='", agent_id, "'");

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
                               "INSERT INTO agency (agency_name, agency_email, agency_phone, agency_street, agency_city, agency_state, "
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

        public void UpdateAgencyName(string name, int agency_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE agency SET agency_name = @agency_name WHERE ",
                                                "agency_id='", agency_id, "'");
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

        public void UpdateAgencyEmail(string email, int agency_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE agency SET agency_email = @agency_email WHERE ",
                                                "agency_id='", agency_id, "'");
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

        public void UpdateAgencyPhone(string phoneNumber, int agency_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE agency SET agency_phone = @agency_phone WHERE ",
                                                "agency_id='", agency_id, "'");
                    command.Parameters.Add("@agency_phone", SqlDbType.NVarChar);

                    command.Parameters["@agency_phone"].Value = phoneNumber.ToCharArray();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void UpdateAgencyStreet(string street, int agency_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE agency SET agency_street = @agency_street WHERE ",
                                                "agency_id='", agency_id, "'");
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

        public void UpdateAgencyCity(string city, int agency_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE agency SET agency_city = @agency_city WHERE ",
                                                "agency_id='", agency_id, "'");
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

        public void UpdateAgencyState(string state, int agency_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE agency SET agency_state = @agency_state WHERE ",
                                                "agency_id='", agency_id, "'");
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

        public void UpdateAgencyZip(string zip, int agency_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("UPDATE agency SET agency_zip = @agency_zip WHERE ",
                                                "agency_id='", agency_id, "'");
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
        public void DeleteAgency(int agency_id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                               String.Concat("DELETE FROM agency WHERE agency_id='", agency_id, "'");

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
                    command.CommandText = "SELECT COUNT(*) FROM agency";
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
                                          + "agency_state, agency_zip FROM agency";

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

        public DataTable GetAgency(int agency_id)
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
                                      "agency_state, agency_zip FROM agency WHERE agency_id='", agency_id, "'");

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


        //convert image to byte[]
        public byte[] ImagetoByte(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //convert byte[] to image
        public Image BytetoImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private SqlConnection connection;
        private SqlCommand command;
       
    }
    #endregion
    //************************************************************************
   
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
                string name = "Boston";
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
                //tester.UpdateShortDescription("A beautiful, best, bigger than ur house...",5);
                Image image1 = Image.FromFile("c:\\image1.jpeg");
                tester.UpdatePhotoOne(image1, 5);
            


                //test table
                /*
                DataTable temp = tester.GetAgency(5);
                foreach (DataRow row in temp.Rows)
                {
                    Console.WriteLine("----------row------------");
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write("item:  ");
                        Console.WriteLine(item);
                    }
                }
                */



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