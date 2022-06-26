using static WinMain.Program;
using ControlClock;
using static ClassMain.CalcMain;
using static ClassMain.TextMain;
using static ClassMain.ControlMain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinMain
{
    /// <summary>
    /// 定义窗体
    /// </summary>
    public partial class WinMain : Form
    {
        /// <summary>
        /// 构建窗体
        /// </summary>
        public WinMain() => InitializeComponent();
        private Point ClockerLocation(Int32 i) =>
            new Point(i < 4 ? 8 : 256, i % 4 * 84 + 52);
        private List<Clocker> Clockers = new List<Clocker>();
        /// <summary>
        /// 校准精度目标，精度溢出阈值
        /// </summary>
        public Int32 CalibrationPrecision, PrecisionOverflow;




        private void WinMain_Load(object sender, EventArgs e)
        {
            SetSCPFontToControl(LabelNow);
            for (Int32 i = 0; i < 8; i++)
            {
                Clockers.Add(new Clocker(i));
                Clockers[i].Location = ClockerLocation(i);
                Controls.Add(Clockers[i]);
            }
            CalibrationPrecision = Convert.ToInt32(ResxMain.CalibrationPrecision);
            PrecisionOverflow = Convert.ToInt32(ResxMain.CalibrationOverflow);
            TimerCalibration.Interval = CalibrationPrecision;
            TimerCalibration.Enabled = true;

            foreach (Clocker a in Clockers) Debug.WriteLine($"{a.Location},{a.Size}");


        }
        #region Region 精度校准
        private void TimerCalibration_Tick(object sender, EventArgs e) => Calibration();
        private void Calibration()
        {
            TimerMain.Enabled = false; TimerCalibration.Enabled = true;
            DateTime dt = DateTime.Now; LabelNow.Text = GetNowText(dt);
            if (InCalibrationPrecision(dt, CalibrationPrecision))
            { TimerCalibration.Enabled = false; TimerMain.Enabled = true; }
        }
        #endregion

        private void TimerMain_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now; LabelNow.Text = GetNowText(dt);
            if (InPrecisionOverflow(dt, PrecisionOverflow)) Calibration(); 
            
        }
    }
}
