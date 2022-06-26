using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMain
{
    /// <summary>
    /// 文本类
    /// </summary>
    public static class TextMain
    {
        /// <summary>
        /// 当前时间文本
        /// </summary>
        /// <param name="dt">当前时间</param>
        /// <returns></returns>
        public static String GetNowText(DateTime dt) => dt.ToString("HH:mm:ss.fff");
        
    }
}
