using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClassMain
{
    /// <summary>
    /// 控件类
    /// </summary>
    public static class ControlMain
    {
        #region Region 控件标签
        private static String[] GetKeyList(Dictionary<String, String> dic) =>
            dic.Keys.Cast<String>().ToArray();
        private static Boolean SplitTag(Object Tag, out Dictionary<String, String> dic)
        {
            try
            {
                String[] str = ((String)Tag).Split(';');
                dic = new Dictionary<String, String>(); String[] ss;
                foreach (String s in str) { ss = s.Split('='); dic.Add(ss[0], ss[1]); }
                return true;
            }
            catch { dic = null; return false; }
        }
        private static Int32 GetInt32FromTag(Object Tag, String ParamName)
        {
            if (!SplitTag(Tag, out Dictionary<String, String> dic)) return 0;
            if (!dic.TryGetValue(ParamName, out String str)) return 0;
            return Convert.ToInt32(str);
        }
        private static String GetStringFromTag(Object Tag, String ParamName)
        {
            if (!SplitTag(Tag, out Dictionary<String, String> dic)) return String.Empty;
            if (!dic.TryGetValue(ParamName, out String str)) return String.Empty;
            return str;
        }
        /// <summary>
        /// 修改控件标签中的属性
        /// </summary>
        /// <param name="TargetControl">目标控件</param>
        /// <param name="ParamName">属性名称</param>
        /// <param name="ParamValue">属性值</param>
        /// <returns></returns>
        public static void ModifyParamToTag(Control TargetControl, String ParamName, Object ParamValue)
        {
            SplitTag(TargetControl.Tag, out Dictionary<String, String> dic);
            if (GetKeyList(dic).Contains(ParamName)) dic[ParamName] = $"{ParamValue}";
            else dic.Add(ParamName, $"{ParamValue}"); String str = "";
            foreach (String s in dic.Keys) str += $"{s}={dic[s]};";
            TargetControl.Tag = str.Substring(0, str.Length - 1);
        }
        /// <summary>
        /// 删除控件标签中的属性
        /// </summary>
        /// <param name="TargetControl">目标控件</param>
        /// <param name="ParamName">属性名称</param>
        public static void RemoveParamToTag(Control TargetControl, String ParamName)
        {
            SplitTag(TargetControl.Tag, out Dictionary<String, String> dic);
            if (GetKeyList(dic).Contains(ParamName)) dic.Remove(ParamName);
            String str = "";
            foreach (String s in dic.Keys) str += $"{s}={dic[s]};";
            TargetControl.Tag = str.Substring(0, str.Length - 1);
        }
        #endregion
        #region Region 设置控件
        /// <summary>
        /// 设置控件字体
        /// </summary>
        /// <param name="c">控件</param>
        public static void SetSCPFontToControl(Control c) =>
            c.Font = FontMain.SourceCodePro(GetInt32FromTag(c.Tag, "FontSize"));
        /// <summary>
        /// 设置控件名称
        /// </summary>
        /// <param name="c">控件</param>
        public static void SetControlName(Control c) =>
            c.Name = GetStringFromTag(c.Tag, "Name") + GetStringFromTag(c.Tag, "Group");
        /// <summary>
        /// 读取控件集合ID标签
        /// </summary>
        /// <param name="uc">控件集合</param>
        /// <returns>控件集合ID标签</returns>
        private static Label GetLabelID(UserControl uc)
        {
            foreach (Control c in uc.Controls)
                if (GetStringFromTag(c.Tag, "Name") == "LabelID") return (Label)c;
            return null;
        }
        /// <summary>
        /// 设置控件集合ID标签文本
        /// </summary>
        /// <param name="uc">控件集合</param>
        public static void SetLabelIDText(UserControl uc) =>
            GetLabelID(uc).Text = GetStringFromTag(uc.Tag, "Group");
        /// <summary>
        /// 设置控件提示框
        /// </summary>
        /// <param name="tt">提示框</param>
        /// <param name="c">控件</param>
        public static void SetTipText(ToolTip tt, Control c) =>
            tt.SetToolTip(c, GetStringFromTag(c.Tag, "Tip"));
        #endregion
    }
}
