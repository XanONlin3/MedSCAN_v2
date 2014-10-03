using System;
using System.Data;
using System.Data.SqlClient;

namespace MedSCAN.Control
{
    /*----------------------------------------------------------------------------
    * Author: J. Nobles
    * Date: 3/23/2014
    * MedSCAN DB connection
    *///-------------------------------------------------------------------------
    public class DatabaseConnection
    {
        //private SqlConnection oSqlCon;
        //private SqlCommand oSqlCmd;
        //private SqlDataAdapter oSqlDtAdptr;
        //private SqlDataReader oSqlDtRoSqlDtrdr;

        //private SqlConnectionStringBuilder oConSB;

        // Set the connection string.
        public static string oSqlConStr = Properties.Settings.Default.MedSCAN_DatabaseConnectionString;

        // Returns a specific value.
        public static object GetScaler(SqlCommand oSqlCmd)
        {
            string RetVal = "";
            using (SqlConnection oSqlCon = new SqlConnection(oSqlConStr))
            {
                oSqlCon.Open();
                oSqlCmd.Connection = oSqlCon;
                RetVal = oSqlCmd.ExecuteScalar().ToString();

                oSqlCon.Close();

                oSqlCmd.Dispose();
            }
            return RetVal;
        }

        // Returns a datatable filled with pased query data.
        public static DataTable GetDataTable(SqlCommand oSqlCmd)
        {
            DataTable dt = new DataTable();
            using (SqlConnection oSqlCon = new SqlConnection(oSqlConStr))
            {
                oSqlCmd.Connection = oSqlCon;
                oSqlCmd.Connection.Open();
                SqlDataReader oSqlDtrdr = oSqlCmd.ExecuteReader();
                dt.Load(oSqlDtrdr);

                oSqlCmd.Connection.Close();

                oSqlDtrdr.Dispose();
                oSqlCmd.Dispose();
            }
            return dt;
        }

        // Returns a dataset filled with pased query data.
        public static DataSet GetDataSet(SqlCommand oSqlCmd)
        {
            DataSet ds = new DataSet();
            using (SqlConnection oSqlCon = new SqlConnection(oSqlConStr))
            {
                SqlDataAdapter oSqlDtAdptr = new SqlDataAdapter("", oSqlCon);
                oSqlDtAdptr.SelectCommand = oSqlCmd;
                oSqlDtAdptr.SelectCommand.Connection = oSqlCon;
                oSqlCon.Open();
                oSqlDtAdptr.Fill(ds);

                //oSqlCon.Close();
                oSqlCmd.Connection.Close();

                oSqlDtAdptr.Dispose();
                oSqlCmd.Dispose();
            }
            return ds;
        }

        // Deletes specified table.
        public static bool Delete(SqlCommand oSqlCmd, string tbl_Name)
        {
            bool operationSuccessful = false;

            using (SqlConnection oSqlCon = new SqlConnection(oSqlConStr))
            {
                SqlDataAdapter oSqlDtAdptr = new SqlDataAdapter("", oSqlCon);
                oSqlDtAdptr.UpdateCommand = oSqlCmd;
                oSqlDtAdptr.UpdateCommand.Connection = oSqlCon;
                oSqlCon.Open();

                oSqlCmd.ExecuteNonQuery();

                oSqlCmd.Connection.Close();

                oSqlDtAdptr.Dispose();
                oSqlCmd.Dispose();

            }
            return operationSuccessful;
        }

        
    }//Class
}//NS