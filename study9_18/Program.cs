using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study9_18
{
    //索引器
    class TempRecord
    {
        //温度数组-定义了一组温度
        private double[] temps = new double[5] { 31.2, 33, 55, 66, 77 };
        private double[] temp = new double[5] { 65, 100, 22, 456, 22 };
        public int Length
        {
            get
            {
                return temps.Length;
            }
        }
        public int tempLength
        {
            get
            {
                return temp.Length;
            }
        }
        public double this[int index]
        {
            get { return temps[index]; }
            set
            {
                temps[index] = value;
            }
        }
        public double this[string str, int index]
        {
            get
            {
                if (str == "摄氏度")
                {
                    return temp[index];
                }
                else
                {
                    return temps[index];
                }
            }
            set
            {
                if (str == "摄氏度")
                {
                    temp[index] = value;
                }
                else
                {
                    temps[index] = value;
                }
            }
        }
    }
    //运算符的重载
    public struct Complex //复数
    {
        public int real;//实部
        public int imaginary;//虚部

        //构造函数
        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        //重载运算符
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }
        //重载tostring方法用以显示复数的实部和虚部
        public override string ToString()
        {
            return (string.Format("{0}+{1}", real, imaginary));
        }
    }
    //析构函数
    class SimpleClassA
    {
        public SimpleClassA()
        {
            Console.WriteLine("执行SimpleClassA的构造函数");
        }
        ~SimpleClassA()
        {
            Console.WriteLine("执行SimpleClassA的析构函数");
        }
    }
    class SimpleClassB
    {
        public SimpleClassB()
        {
            Console.WriteLine("执行SimpleClassB的构造函数");
        }
        ~SimpleClassB()
        {
            Console.WriteLine("执行SimpleClassB的析构函数");
        }
        public void CreateObject()
        {
            Console.WriteLine("进入SimpleClassB.CreateObject()");
            SimpleClassA objSimpleClassA = new SimpleClassA();
            Console.WriteLine("退出SimpleClassB.CreateObject()");
        }
    }
    class SQLHelper
    {
        private readonly static string conString = @"Server=LAPTOP-NA9O9SEF;DataBase=Admin_information;Uid=sa;pwd=123456";
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
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("====================索引器========================");
            TempRecord tempRecord = new TempRecord();
            tempRecord[3] = 14.1; //访问索引器设置值
            tempRecord[4] = 16.3;//访问索引器设置值

            //输出温度的值
            for (int i = 0; i < tempRecord.Length; i++)
            {
                Console.WriteLine("华氏度   Element #{0}={1}", i, tempRecord[i]);
            }

            tempRecord["摄氏度", 3] = 14.1; //访问索引器设置值
            tempRecord["摄氏度", 4] = 16.3;//访问索引器设置值
                                        //输出温度的值
            for (int i = 0; i < tempRecord.Length; i++)
            {
                Console.WriteLine("摄氏度  Element #{0}={1}", i, tempRecord["摄氏度", i]);
            }

            Console.WriteLine("====================运算符的重载========================");

            Complex num1 = new Complex(2, 3);
            Complex num2 = new Complex(3, 4);
            //使用重载过后的运算符
            Complex sum = num1 + num2;

            //调用重写的tostring()方法；
            Console.WriteLine("第一个复数：\t{0}", num1.ToString());
            Console.WriteLine("第二个复数：\t{0}", num2.ToString());
            Console.WriteLine("两个复数之和：\t{0}", sum.ToString());


            Console.WriteLine("====================析构函数========================");
            Console.WriteLine("进入main()");
            SimpleClassB objSimpleClassB = new SimpleClassB();
            objSimpleClassB.CreateObject();
            Console.WriteLine("退出main()");

            #endregion
            Console.WriteLine("====================连接数据库========================");

            string conString = @"Server=LAPTOP-NA9O9SEF;DataBase=Admin_information;Uid=sa;pwd=123456";
            //创建连接对象
            SqlConnection conn = new SqlConnection(conString);
            //打开数据库
            conn.Open();
            //判断是否打开数据库
            if (conn.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("数据库已打开");
            }
            //关闭数据库
            conn.Close();
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                Console.WriteLine("数据库已关闭");
            }
            Console.WriteLine("====================数据库的查询========================");
            SqlDataReader objDataRead = SQLHelper.GetReader("select * from information");
            //循环
            while (objDataRead.Read())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", objDataRead["ID"], objDataRead["account"], objDataRead["passwords"], objDataRead["powers"]);
            }
            objDataRead.Close();
            Console.WriteLine("====================数据库的增删改========================");
            int result = SQLHelper.Updata("insert into information(ID,account,passwords,powers) values(3, 'Thread', '123', '用户')");
            if (result >= 1)
            {
                Console.WriteLine("插入成功！");
            }
            objDataRead = SQLHelper.GetReader("select * from information");
            //循环
            while (objDataRead.Read())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", objDataRead["ID"], objDataRead["account"], objDataRead["passwords"], objDataRead["powers"]);
            }
            objDataRead.Close();
            Console.ReadKey();
        }
    }
}
