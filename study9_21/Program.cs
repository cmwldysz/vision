using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHelper;
using TXT_ClassLibrary;
using INI_ClassLibrary;

namespace study9_21
{
    //定义一个数据类
    class AdminLogin {
        private string account;//账号
        private string passwords;//密码
        private string powers;//权限

        public string Account { get => account; set => account = value; }
        public string Passwords { get => passwords; set => passwords = value; }
        public string Powers { get => powers; set => powers = value; }
    }
    class AdminLoginEx : AdminLogin {
        private string name;//拥有人姓名
        private string phoneNumber;//电话号码

        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
    class Person {
        public string name;public int age;
        public Person(string name, int age) {
            this.name = name;
            this.age = age;
           }
        public void pring() {
            Console.WriteLine("name={0},age={1}",name,age);
        }
    }
    class student : Person {
        public string studentId;
        public student(string name, int age, string id) :base(name,age){
            this.studentId = id;
        }
        public void print() {
            base.pring();
            Console.WriteLine("studentid={0}", this.studentId);
        }
    }
    class TEST {
        public static string aaa = "123";
    }
    class Program
    {
        public const string txtPath = @"D:\work\log\Log_Save.txt";
        /// <summary>
        /// 验证账号密码
        /// </summary>
        /// <param name="objAdmin">数据类</param>
        /// <returns></returns>
        public static AdminLogin login(AdminLogin objAdmin)
        {
            //形成SQL语句
            string sql = "select powers from information where account='{0}' and passwords='{1}'";
            sql = string.Format(sql,objAdmin.Account, objAdmin.Passwords);

            string information = DateTime.Now.ToString() + "： 执行SQL语句 " + sql;
            Console.WriteLine(information);
            //向txt中写入信息
            TXT.write_txt(txtPath, information);
            //向数据库发起请求
            SqlDataReader objReader = SQLHelper.SQLHelper.GetReader(sql);

            //判断是否有内容
            if (objReader.Read())
            {
                TXT.write_txt(txtPath, DateTime.Now.ToString() + "：SQL查询成功");
                objAdmin.Powers = (string)objReader["powers"];//获取对应的权限
                return objAdmin;//取到对应的值，返回对象(账号/密码/权限)
            }
            else
            {
                TXT.write_txt(txtPath, DateTime.Now.ToString() + "：SQL查询没有找到对应的账号密码");
                return objAdmin = null;//返回NULL说明没有对应的账号
            }
        }
        public static void userLogin() {
            Console.WriteLine("=============访问数据库 验证账号密码===================");
            Console.WriteLine("欢迎登录XXX系统");
            Console.Write("请输入登录用户：\t");
            string name = Console.ReadLine();
            Console.Write("请输入登录密码：\t");
            string pwds = Console.ReadLine();

            //创建数据对象
            AdminLogin admin = new AdminLogin();
            admin.Account = name;
            admin.Passwords = pwds;
            //验证账号和密码数据库中是否存在
            admin = login(admin);
            if (admin != null)
            {
                Console.WriteLine("登录成功");
            }
            else
            {
                Console.WriteLine("登录失败");
            }
            Console.WriteLine(TXT.read_txx(txtPath));
        }
        static void Main(string[] args)
        {

            //测试INI的写入操作

            //保存绝对路径
            //string Save_File = System.AppDomain.CurrentDomain.BaseDirectory + "数据库配置.ini";

            //Console.WriteLine("Save_File:{0}", Save_File);
            //INI.WritePrivateProfileString("数据库配置信息", "数据库地址", "LAPTOP-NA9O9SEF", Save_File);
            //INI.WritePrivateProfileString("数据库配置信息", "数据库名称", "Admin_information", Save_File);
            //INI.WritePrivateProfileString("数据库配置信息", "账号", "sa", Save_File);
            //INI.WritePrivateProfileString("数据库配置信息", "密码", "123456", Save_File);

            TEST.aaa = "wqewqewqe";
            Console.WriteLine("试一下静态变量是否可赋值：{0}",TEST.aaa);
            Console.WriteLine("==========base关键字==============");
            student objstudent = new student("李四", 18, "2020921");
            objstudent.print();

            while (true)
            {
                userLogin();
            }

            //Console.ReadKey();
        }
    }
}
