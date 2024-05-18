using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyDuLich.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
         
        private string connectionString = "Data Source=THANHPHAT\\THANHPHAT;Initial Catalog=QUANLYDULICH;Integrated Security=True";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                //Nếu có đối số 
                if (parameter != null)
                {
                    //Ngắn cách bởi dấu ' '
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        //Nếu có chứa đối số kiểu --> @UserName 
                        //Bắt thằng @ 
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();

            }
            return data;
        }


        //trả về số dòng được thực thi thành công dùng Insert Update Delete
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                //Nếu có đối số 
                if (parameter != null)
                {
                    //Ngắn cách bởi dấu ' '
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        //Nếu có chứa đối số kiểu --> @UserName 
                        //Bắt thằng @ 
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();

                connection.Close();

            }
            return data;
        }

        //query với số dòng đầu tiên ==> Count(*)
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                //Nếu có đối số 
                if (parameter != null)
                {
                    //Ngắn cách bởi dấu ' '
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        //Nếu có chứa đối số kiểu --> @UserName 
                        //Bắt thằng @ 
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();

                connection.Close();

            }
            return data;
        }
    }
}
