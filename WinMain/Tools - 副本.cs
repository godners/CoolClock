using System;
using System.Collections.Generic;
using CustomStyle;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinMain
{
    internal static class Tools
    {
        #region Region GetParamFromTag
        internal static Boolean SplitTag(Object Tag, out Dictionary<String, String> dic)
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
        internal static Int32 GetInt32FromTag(Object Tag, String ParamName)
        {
            if (!SplitTag(Tag, out Dictionary<String, String> dic)) return 0;
            if (!dic.TryGetValue(ParamName, out String str)) return 0;
            return Convert.ToInt32(str);
        }
        internal static String GetStringFromTag(Object Tag, String ParamName)
        {
            if (!SplitTag(Tag, out Dictionary<String, String> dic)) return String.Empty;
            if (!dic.TryGetValue(ParamName, out String str)) return String.Empty;
            return str;
        }
        #endregion

        #region Region InitFormMain
        internal static void SetSCPFontToControl(Control c) =>
            c.Font = CustomFonts.SourceCodePro(GetInt32FromTag(c.Tag, "FontSize"));
        internal static void SetSCPFontToPanel(Panel p)
        { foreach (Control c in p.Controls) SetSCPFontToControl(c); }
        internal static void SetControlName(Control c) =>
            c.Name = GetStringFromTag(c.Tag, "Name") + GetStringFromTag(c.Tag, "Group");            
        internal static void SetControlNameInPanel(Panel p)
        { foreach (Control c in p.Controls) SetControlName(c); }
        internal static Label GetLabelID(Panel p)
        {
            foreach (Control c in p.Controls)            
                if (GetStringFromTag(c.Tag, "Name") == "LabelID") return (Label)c;
            return null;
        }
        internal static void SetLabelIDText(Panel p)
        { GetLabelID(p).Text = GetStringFromTag(p.Tag, "Group"); }


        #endregion
    }
}
