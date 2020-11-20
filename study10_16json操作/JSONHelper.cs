using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace study10_16json操作
{
    class JSONHelper
    {
        /// <summary>
        /// 将对象转换成JSON字符串
        /// </summary>
        /// <typeparam name="T">需要转换的类型</typeparam>
        /// <param name="x">具体的对象</param>
        /// <returns></returns>
        public static string EnitiyToJSON<T>(T x) {
            string result = string.Empty;
            try
            {
                result = JsonConvert.SerializeObject(x);
            }
            catch (Exception)
            {
                result = string.Empty;
            }
            return result;
        }
        /// <summary>
        /// JSON字符串转换成实例类
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="json">JSON字符串</param>
        /// <returns></returns>
        public static T JSONToEntity<T>(string json) {
            T t = default(T);
            try
            {
                t = (T)JsonConvert.DeserializeObject(json, typeof(T));
            }
            catch (Exception)
            {
                t = default(T);
            }
            return t;
        }
    }
}
