using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using WinMain;

namespace CustomStyle
{
    /// <summary>
    /// 调用字体
    /// </summary>
    public static class CustomFonts
    {
        #region Region 字体
        private static void InitFont(ref PrivateFontCollection FontContainer, Byte[] ResourceName)
        {
            FontContainer = new PrivateFontCollection();
            GCHandle gh = GCHandle.Alloc(ResourceName, GCHandleType.Pinned);
            IntPtr ip = gh.AddrOfPinnedObject();
            FontContainer.AddMemoryFont(ip, ResourceName.Length);
        }
        #region Region Source Code Pro
        private static PrivateFontCollection SCP;
        /// <summary>
        /// 调用 Source Code Pro 字体
        /// </summary>
        /// <returns>字体家族</returns>
        public static FontFamily SourceCodePro()
        {
            if (SCP == null) InitFont(ref SCP, ResourceMain.SourceCodePro);
            return SCP.Families[0];
        }
        /// <summary>
        /// 调用 Source Code Pro 字体
        /// </summary>
        /// <param name="FontSize">字体大小</param>
        /// <returns>字体</returns>
        public static Font SourceCodePro(Int32 FontSize)
        {
            if (SCP == null) InitFont(ref SCP, ResourceMain.SourceCodePro);
            return new Font(SCP.Families[0], FontSize);
        }
        #endregion
        #region Region 马善政
        private static PrivateFontCollection MSZ;
        /// <summary>
        /// 调用 马善政 字体
        /// </summary>
        /// <returns>字体家族</returns>
        public static FontFamily MaShanZheng()
        {
            if (MSZ == null) InitFont(ref MSZ, ResourceMain.MaShanZheng);
            return MSZ.Families[0];
        }
        /// <summary>
        /// 调用 马善政 字体
        /// </summary>
        /// <param name="FontSize">字体大小</param>
        /// <returns>字体</returns>
        public static Font MaShanZheng(Int32 FontSize)
        {
            if (MSZ == null) InitFont(ref MSZ, ResourceMain.MaShanZheng);
            return new Font(MSZ.Families[0], FontSize);
        }
        #endregion

        #endregion
    }
}
