
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WFrmTestConnection.Dao
{
    public class ProcessDao
    {
        private SqlConnection cn;        
        private string conn = ConfigurationManager.AppSettings["ProcessTestDaoConnString"];

        public ProcessDao()
        {

        }

        public int SavePersonalData(string name, string lastName, string address, string phone, string email)
        {
            int resp = 0;

            try
            {
                string cmdText = "insert into [dbo].[Person]([Name],[LastName],[Address],[Phone],[Email]) " +
                "values ('" + name + "','" + lastName + "','" + address + "','" + phone + "','" + email + "')";

                using (cn = new SqlConnection(this.conn))
                {
                    SqlCommand cmd = new SqlCommand(cmdText, cn);

                    cmd.CommandType = CommandType.Text;

                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    resp = cmd.ExecuteNonQuery();
                }

                return resp;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet GetPersonalData()
        {
            DataSet ds = new DataSet();

            try
            {
                string cmdText = "select Id,Name,LastName,Address, Phone, Email from [dbo].[Person]";

                using (cn = new SqlConnection(this.conn))
                {
                    SqlCommand cmd = new SqlCommand(cmdText, cn);

                    cmd.CommandType = CommandType.Text;

                    if (cn.State != ConnectionState.Open)
                        cn.Open();

                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    da.Fill(ds);

                    return ds;
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeletePersonalData(List<string> lstSelected)
        {
            int resp = 0;

            try
            {
                foreach(var record in lstSelected)
                {
                    string cmdText = "delete from [dbo].[Person] where id = '" + record + "' ";

                    using (cn = new SqlConnection(this.conn))
                    {
                        SqlCommand cmd = new SqlCommand(cmdText, cn);

                        cmd.CommandType = CommandType.Text;

                        if (cn.State != ConnectionState.Open)
                            cn.Open();

                        resp = cmd.ExecuteNonQuery();
                    }
                }                

                return resp;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}