using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMain
{
    /// <summary>
    /// 计算类
    /// </summary>
    public class CalcMain
    {//CalibrationPrecision, PrecisionOverflow;
        /// <summary>
        /// 精度溢出
        /// </summary>
        /// <param name="dt">当前时间</param>
        /// <param name="PrecisionOverflow">精度溢出阈值</param>
        /// <returns></returns>
        public static Boolean InPrecisionOverflow(DateTime dt, Int32 PrecisionOverflow) =>
            dt.Millisecond >= PrecisionOverflow && dt.Millisecond <= 1000 - PrecisionOverflow;
        /// <summary>
        /// 校准达标
        /// </summary>
        /// <param name="dt">当前时间</param>
        /// <param name="CalibrationPrecision">校准精度目标</param>
        /// <returns></returns>
        public static Boolean InCalibrationPrecision(DateTime dt, Int32 CalibrationPrecision) =>
            dt.Millisecond <= CalibrationPrecision || dt.Millisecond >= 1000 - CalibrationPrecision;
    }
}
