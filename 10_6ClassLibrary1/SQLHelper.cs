using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6ClassLibrary1
{
    public class SQLHelper
    {
        public readonly static string conString = "Server=LAPTOP-NA9O9SEF;DataBase=Student_Information;Uid=sa;pwd=123456";
        public static DataTable GetDataTable(string sql) {
            SqlConnection sqlcon = new SqlConnection(conString);//连接数据库
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);//执行SQL语句
            //创建数据集用于接收
            DataSet myds = new DataSet();
            //往数据集中填充数据
            sqlda.Fill(myds);
            return myds.Tables[0];
        }
        public static int Updata(string sql) {
            using (SqlConnection sqlcon = new SqlConnection(conString))
            {
                using (SqlCommand sql_cmd = new SqlCommand(sql,sqlcon))
                {
                    //打开数据库
                    sqlcon.Open();
                    //操作数据库返回受影响的行
                    return sql_cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
