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
            connection.ConnectionString = "DataSource=HSV-ATHENA;Initial Catalog=PATRIOT_DTE;User ID=nathaniel.mccain;Password=";
            connection.Open();
        }

        public void closeConnection()
        {
            connection.Close();
        }

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
                    command.Parameters.Add("@listingPrice", SqlDbType.Image);

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
                    command.CommandText = String.Concat("SELECT COUNT(*) FROM TABLENAME WHERE agentID ='",agentID,"'");
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

                    command.Parameters.Add("@low",SqlDbType.Int);
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
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandType = CommandType.Text;
				command.CommandText = 
                    String.Concat("SELECT ALL smallPhoto, listingPrice, listingStreet, listingCity, listingState, ",
                                      "listingZip, listingSquareFootage, agentID, agencyID FROM TABLENAME");
				
				DataTable table = new DataTable();
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
				getText(table);

            }
            return null;
        }

        #endregion
        public void getText(String testNumber)
        {
            command.Parameters.Clear();
            command.Connection = connection;
            String query = "SELECT * FROM DESCRIPTIONS WHERE testNumber=@testNumber";
            command.CommandText = query;
            command.Parameters.AddWithValue("@testNumber", testNumber);

            DataTable table = new DataTable();
            table.Columns.Add("programName");
            table.Columns.Add("versionMod");
            table.Columns.Add("testNumber");
            table.Columns.Add("testDescription");


            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(table);
            }
            getText(table);

        }

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
            string conString = "Data Source=DESKTOP-KFI49LK;Initial Catalog=Housing;Integrated Security=True";

            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string name = "Destruction";
                string email = "death.org";
                string phone = "6669996666";
                string street = "666 Street";
                string state = "666 City";
                string city = "999 Death Row";
                string agency_zip = "66666";

                string fName = "Jake";
                string lName = "stateFarm";
                string userName = "Jake";
                string password = "fromStateFarm";
                string number = "345559999";
                string email2 = "Jake@stateFarm";
                int agency_id = 5;
                string number2 = "1234567890";


                //Int16 zip = 3580;

                //int zip = 45678;
                // string q = "insert into agency(agency_name,agency_email,agency_phone,agency_street,agency_state,agency_city,agency_zip)values('" + name + "','" + email + "','" + phone + " ','" + street + "','" + state + " ','" + city + "','" + agency_zip + "')";
                //SqlCommand cmd = new SqlCommand(q, con);
                //cmd.ExecuteNonQuery();

                string z = "insert into agent(agent_Fname,agent_Lname,agent_Uname,agent_password,agent_number,agent_email,agency_id,agent_number2)values('" + fName + "','" + lName + "','" + userName + " ','" + password + "','" + number + " ','" + email2 + "','" + agency_id + "','" + number2 + "')";

                SqlCommand cmd1 = new SqlCommand(z, con);
                cmd1.ExecuteNonQuery();

                //MessageBox.Show("Connection made successfully!");
            }
            else
            {
                Console.WriteLine("Failed to connect");
            }
        }
    }
}
