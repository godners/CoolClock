namespace ControlClock
{
    partial class Clocker
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();            
            base.Dispose(disposing);
        }
        #region 组件设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clocker));
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelDistance = new System.Windows.Forms.Label();
            this.LabelStop = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.LabelContinued = new System.Windows.Forms.Label();
            this.LabelBegin = new System.Windows.Forms.Label();
            this.ButtonPause = new System.Windows.Forms.Button();
            this.ButtonSwitch = new System.Windows.Forms.Button();
            this.LabelMode = new System.Windows.Forms.Label();
            this.ButtonDefine = new System.Windows.Forms.Button();
            this.TipClocker = new System.Windows.Forms.ToolTip(this.components);
            this.BarSchedule = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LabelID
            // 
            resources.ApplyResources(this.LabelID, "LabelID");
            this.LabelID.Name = "LabelID";
            this.LabelID.Tag = "FontSize=12;Name=LabelID;Tip=Clocker ID";
            this.LabelID.UseCompatibleTextRendering = true;
            // 
            // LabelDistance
            // 
            resources.ApplyResources(this.LabelDistance, "LabelDistance");
            this.LabelDistance.Name = "LabelDistance";
            this.LabelDistance.Tag = "FontSize=9;Name=LabelDistance;Tip=Distance Time";
            this.LabelDistance.UseCompatibleTextRendering = true;
            // 
            // LabelStop
            // 
            resources.ApplyResources(this.LabelStop, "LabelStop");
            this.LabelStop.Name = "LabelStop";
            this.LabelStop.Tag = "FontSize=9;Name=LabelStop;Tip=Stop Time";
            this.LabelStop.UseCompatibleTextRendering = true;
            // 
            // ButtonReset
            // 
            resources.ApplyResources(this.ButtonReset, "ButtonReset");
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Tag = "FontSize=12;Name=ButtonReset;Tip=Reset Clock";
            this.ButtonReset.UseCompatibleTextRendering = true;
            this.ButtonReset.UseVisualStyleBackColor = true;
            // 
            // LabelContinued
            // 
            resources.ApplyResources(this.LabelContinued, "LabelContinued");
            this.LabelContinued.Name = "LabelContinued";
            this.LabelContinued.Tag = "FontSize=9;Name=LabelContinued;Tip=Continued Time";
            this.LabelContinued.UseCompatibleTextRendering = true;
            // 
            // LabelBegin
            // 
            resources.ApplyResources(this.LabelBegin, "LabelBegin");
            this.LabelBegin.Name = "LabelBegin";
            this.LabelBegin.Tag = "FontSize=9;Name=LabelBegin;Tip=Begin Time";
            this.LabelBegin.UseCompatibleTextRendering = true;
            // 
            // ButtonPause
            // 
            resources.ApplyResources(this.ButtonPause, "ButtonPause");
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Tag = "FontSize=12;Name=ButtonPause;Tip=Pause Clocker";
            this.ButtonPause.UseCompatibleTextRendering = true;
            this.ButtonPause.UseVisualStyleBackColor = true;
            // 
            // ButtonSwitch
            // 
            resources.ApplyResources(this.ButtonSwitch, "ButtonSwitch");
            this.ButtonSwitch.Name = "ButtonSwitch";
            this.ButtonSwitch.Tag = "FontSize=12;Name=ButtonSwitch;Tip=Switch Clocker";
            this.ButtonSwitch.UseCompatibleTextRendering = true;
            this.ButtonSwitch.UseVisualStyleBackColor = true;
            // 
            // LabelMode
            // 
            resources.ApplyResources(this.LabelMode, "LabelMode");
            this.LabelMode.Name = "LabelMode";
            this.LabelMode.Tag = "FontSize=12;Name=LabelMode;Tip=Clock Mode";
            this.LabelMode.UseCompatibleTextRendering = true;
            // 
            // ButtonDefine
            // 
            resources.ApplyResources(this.ButtonDefine, "ButtonDefine");
            this.ButtonDefine.Name = "ButtonDefine";
            this.ButtonDefine.Tag = "FontSize=12;Name=ButtonDefine;Tip=Difine Clocker";
            this.ButtonDefine.UseCompatibleTextRendering = true;
            this.ButtonDefine.UseVisualStyleBackColor = true;
            // 
            // TipClocker
            // 
            this.TipClocker.AutoPopDelay = 5000;
            this.TipClocker.InitialDelay = 200;
            this.TipClocker.ReshowDelay = 100;
            this.TipClocker.Tag = "FontSize=9;Name=TipClocker";
            // 
            // BarSchedule
            // 
            resources.ApplyResources(this.BarSchedule, "BarSchedule");
            this.BarSchedule.Name = "BarSchedule";
            this.BarSchedule.Tag = "FontSize=12;Name=BarSchedule;Tip=Schedule";
            // 
            // Clocker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.BarSchedule);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.LabelDistance);
            this.Controls.Add(this.LabelStop);
            this.Controls.Add(this.ButtonDefine);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.LabelMode);
            this.Controls.Add(this.LabelContinued);
            this.Controls.Add(this.ButtonSwitch);
            this.Controls.Add(this.LabelBegin);
            this.Controls.Add(this.ButtonPause);
            resources.ApplyResources(this, "$this");
            this.Name = "Clocker";
            this.Tag = "FontSize=12;Name=Clocker;Tip=Clocker";
            this.Load += new System.EventHandler(this.Clocker_Load);
            this.ResumeLayout(false);

        }
        #endregion
        
        /// <summary>
        /// 时钟序号
        /// </summary>
        public System.Int32 ClockID { get => _ClockID; 
            set => _ClockID = _ClockID == -1 ? value : _ClockID; }
        private System.Int32 _ClockID = -1;
        /// <summary>
        /// 运行状态
        /// </summary>
        public ClockMode RunningMode
        {
            get => _RunningMode;
            set
            {
                _RunningMode = value;
                LabelMode.Text = value.ToString().Substring(0, 1);
                TipClocker.SetToolTip(LabelMode, value.ToString());
                FlushButtonStyle();
            }
        }
        private ClockMode _RunningMode = ClockMode.Undefine;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelDistance;
        private System.Windows.Forms.Label LabelStop;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Label LabelContinued;
        private System.Windows.Forms.Label LabelBegin;
        private System.Windows.Forms.Button ButtonPause;
        private System.Windows.Forms.Button ButtonSwitch;
        private System.Windows.Forms.Label LabelMode;
        private System.Windows.Forms.Button ButtonDefine;
        private System.Windows.Forms.ToolTip TipClocker;
        private System.Windows.Forms.ProgressBar BarSchedule;
 
    }
    /// <summary>
    /// ClockMode
    /// </summary>
    public enum ClockMode
    {
        /// <summary>
        /// </summary>
        Undefine = 0,
        /// <summary>
        /// </summary>
        Sleeping = 1,
        /// <summary>
        /// </summary>
        Pause    = 2,
        /// <summary>
        /// </summary>
        Timer    = 3,
        /// <summary>
        /// </summary>
        Distance = 4,
        /// <summary>
        /// </summary>
        Logger   = 5,
    }
}
