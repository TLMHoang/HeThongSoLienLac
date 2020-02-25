using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.SQL
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "<Pending>")]

    public class SQLHelper
    {
        public string connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

        public async Task<int> ExecuteNonQuery(string ProcName, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(ProcName, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        await con.OpenAsync();


                        return await cmd.ExecuteNonQueryAsync();
                    }
                }
                //Message = "The transaction ended in the trigger. The batch has been aborted."
                catch (Exception ex)
                {
                    if (ex.Message.Contains("transaction ended"))
                    {
                        MessageBox.Show(SlipString(ex.Message));
                    }
                    else
                    {
                        MessageBox.Show("Lỗi \n\n" + ex.ToString());
                    }
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }

            return 0;
        }

        public async Task<DataTable> ExecuteQuery(string ProcName, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(ProcName, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        await con.OpenAsync();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi \n\n" + ex.ToString());
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }

            return dt;
        }

        public async Task<T> ExecuteScalar<T>(string ProcName, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(ProcName, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        await con.OpenAsync();
                        var Val = await cmd.ExecuteScalarAsync();

                        return (Val == null) ? default(T) : (T)Convert.ChangeType(Val, typeof(T));

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi \n\n" + ex.ToString());
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }

                return default(T);
            }
        }

        public string SlipString(string str)
        {
            string strReturn = str;

            strReturn = strReturn.Remove(0, str.IndexOf("\r\n"));

            return strReturn;
        }
    }
}
