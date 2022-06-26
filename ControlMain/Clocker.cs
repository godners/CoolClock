using ClassMain;
using System;
using System.Windows.Forms;

namespace ControlClock
{
    /// <summary>
    /// 生成控件
    /// </summary>
    public partial class Clocker : UserControl
    {
        /// <summary>
        /// 构建控件
        /// </summary>
        public Clocker(Int32 ID) { ClockID = ID;  InitializeComponent(); }
        #if DEBUG
        public Clocker() { ClockID = 1;InitializeComponent(); }
        

        #endif


        private void Clocker_Load(object sender, EventArgs e)
        {
            InitStyle(); RunningMode = ClockMode.Undefine; 
            FlushButtonStyle(); 
        }
        private void SetButtonEnable
            (Int32 Switch, Int32 Pause, Int32 Define, Int32 Reset)
        {
            ButtonSwitch.Enabled = Convert.ToBoolean(Switch); 
            ButtonPause.Enabled = Convert.ToBoolean(Pause);
            ButtonDefine.Enabled = Convert.ToBoolean(Define); 
            ButtonReset.Enabled = Convert.ToBoolean(Reset);
        }
        private void FlushButtonStyle()
        {
            switch (RunningMode)
            {
                case ClockMode.Undefine: SetButtonEnable(0, 0, 1, 0); break;
                case ClockMode.Sleeping: SetButtonEnable(1, 0, 1, 1); break;
                case ClockMode.Pause:    SetButtonEnable(1, 0, 1, 0); break;
                case ClockMode.Timer:    SetButtonEnable(1, 0, 1, 1); break;
                case ClockMode.Distance: SetButtonEnable(1, 1, 1, 1); break;
                case ClockMode.Logger:   SetButtonEnable(1, 1, 1, 1); break;
                default: SetButtonEnable(0, 0, 0, 0); break;
            }
        }
        private void InitStyle()
        {
            ControlMain.ModifyParamToTag(this, "Group", ClockID);
            foreach (Control c in this.Controls) ControlMain.ModifyParamToTag(c, "Group", ClockID);
            ControlMain.SetSCPFontToControl(this);
            foreach (Control c in this.Controls) ControlMain.SetSCPFontToControl(c);
            ControlMain.SetControlName(this);
            foreach (Control c in this.Controls) ControlMain.SetControlName(c);
            ControlMain.SetLabelIDText(this);
            ControlMain.ModifyParamToTag(this, "Tip", $"Clocker {ClockID:D2}");
            ControlMain.SetTipText(TipClocker, this);
            foreach (Control c in this.Controls) ControlMain.SetTipText(TipClocker, c);
        }

        private void SetBarValue(Int32 Value)
        {
            Double calc = (Double)Value/(Double)BarSchedule.Width;
            calc = Math.Pow(calc, Math.E) - 1; calc /= Math.E - 1;
            calc = Math.Round(calc * (Double)BarSchedule.Width, 0);
            BarSchedule.Value = (Int32)calc;
        }



        
    }
}
