using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.SQL
{
    public class SQLHelper : stringConnect
    {
        //Hoàng
        //private string connStr = @"Data Source=DESKTOP-MPFCGCF;Initial Catalog=HeThongSoLienLac;Integrated Security=True";
        //Phong
        //private string connStr = @"Data Source=VHP;Initial Catalog=HeThongSoLienLac;Integrated Security=True";
        //Trường
        //private string connStr = @"Data Source=TRUONGTRAN\MSSQLSERVER1;Initial Catalog=HeThongSoLienLac;Integrated Security=True";


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
                    if (ex.Message.Equals("The transaction ended in the trigger. The batch has been aborted."))
                    {
                        MessageBox.Show("Dữ liệu đã có không thể thêm lại 1 lần nữa.");
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
    }
}
