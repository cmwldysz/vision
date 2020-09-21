using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INI_ClassLibrary;

namespace SQLHelper
{
    public class SQLHelper
    {
       
        public readonly static string conString = GetSQLString();
        public static string GetSQLString() {
            string Save_File = AppDomain.CurrentDomain.BaseDirectory + "数据库配置.ini";

            //读取的操作
            string Server = INI.ContentValue("数据库配置信息", "数据库地址", Save_File);
            string DataBase = INI.ContentValue("数据库配置信息", "数据库名称", Save_File);
            string Uid = INI.ContentValue("数据库配置信息", "账号", Save_File);
            string pwd = INI.ContentValue("数据库配置信息", "密码", Save_File);
            return "Server="+ Server + ";DataBase="+ DataBase + ";Uid="+ Uid + ";pwd="+ pwd;
        }
        /// <summary>
        /// 执行 SQL查询命令，获取SqlDataReader结果对象
        /// </summary>
        /// <param name="sql">SQL命令</param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(conString);//连接数据库
            SqlCommand cmd = new SqlCommand(sql, conn);//执行SQL语句
            try
            {
                conn.Open();//打开数据库
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);//返回对象
            }
            catch (Exception)
            {
                conn.Close();//关闭数据库
                throw;
            }
        }
        /// <summary>
        /// 执行增删改方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>返回受影响的行数</returns>
        public static int Updata(string sql)
        {

            SqlConnection conn = new SqlConnection(conString);//连接数据库
            SqlCommand cmd = new SqlCommand(sql, conn);//执行SQL语句
            try
            {
                conn.Open();//打开数据库
                return cmd.ExecuteNonQuery();//返回受影响的行数
            }
            catch (Exception)
            {
                //可以将错误的日志写入保存都TXT文档中
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
