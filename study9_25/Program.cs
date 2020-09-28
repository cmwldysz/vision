using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study9_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================哈希表==================");
            Hashtable hash = new Hashtable();//穿件实例
            //添加键-值对
            hash.Add("key1", "value1");
            hash.Add("key2", "value2");
            //修改键-值对
            hash["key1"] = "value01";
            foreach (var item in hash.Keys)
            {
                Console.WriteLine(item + ":" + hash[item] + "\n");
            }
            Console.WriteLine("================哈希表==================");
            //  DictionaryEntry公开枚举器
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine("key={0},value={1}", item.Key, item.Value);
            }

            Console.WriteLine("================哈希表练习==================");
            Hashtable hashtext = new Hashtable();
            hashtext.Add(".txt", "记事本.exe");
            hashtext.Add(".bmp", "图片管理器.exe");
            hashtext.Add(".doc", "officeWorld.exe");
            hashtext.Add(".xls", "officeExcle.exe");
            hashtext[".doc"] = "wpf";
            foreach (var item in hashtext.Keys)
            {
                Console.WriteLine("key={0},value={1}", item, hashtext[item]);
            }
            Console.WriteLine("================字典==================");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("key1", "value1");
            dict.Add("key2", "value2");
            dict.Add("key3", "value3");
            dict.Add("key4", "value4");
            dict.Add("key5", "value5");
            dict["key3"] = "value03";
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + ":" + dict[item] + "\t");
            }
            foreach (KeyValuePair<string,string> item in dict)
            {
                Console.WriteLine("key={0},value={1}", item.Key, item.Value);
            }








            Console.ReadKey();
        }
    }
}
