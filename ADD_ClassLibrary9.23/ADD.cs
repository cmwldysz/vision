using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ADD_ClassLibrary9._23
{
    //1.规定接口
    [ComVisible(true)]//可访问性允许
    [Guid("FF79F331-41C1-497C-BADE-08A39E619283")]
    public interface IMyClass {
        int Add(int a, int b);
    }
    //2、实现接口
    [ComVisible(true)]//可访问性允许
    [Guid("CF2E4EA8-5D7D-44A7-B384-16EC4272DC71")]
    [ProgId("ADD.IMyClass")]//在系统中起别名，方便用户使用
    public class ADD : IMyClass {
        public int Add(int a, int b) {
            return a + b;
        }
    }
}
