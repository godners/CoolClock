using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace ClassMain
{
    /// <summary>
    /// 字体类
    /// </summary>
    public static class FontMain
    {
        private static void InitFont(ref PrivateFontCollection FontContainer, Byte[] ResourceName)
        {
            FontContainer = new PrivateFontCollection();
            GCHandle gh = GCHandle.Alloc(ResourceName, GCHandleType.Pinned);
            IntPtr ip = gh.AddrOfPinnedObject();
            FontContainer.AddMemoryFont(ip, ResourceName.Length);
        }
        #region Region 字体：Source Code Pro
        private static PrivateFontCollection SCP;
        internal static FontFamily SourceCodePro()
        {
            if (SCP == null)
                InitFont(ref SCP, ResxClass.SourceCodePro);
            return SCP.Families[0];
        }
        internal static Font SourceCodePro(Int32 FontSize)
        {
            if (SCP == null)
                InitFont(ref SCP, ResxClass.SourceCodePro);
            return new Font(SCP.Families[0], FontSize);
        }
        #endregion
        #region Region 字体：马善政
        private static PrivateFontCollection MSZ;
        /// <summary>
        /// 调用 马善政 字体
        /// </summary>
        /// <returns>字体家族</returns>
        public static FontFamily MaShanZheng()
        {
            if (MSZ == null)
                InitFont(ref MSZ, ResxClass.MaShanZheng);
            return MSZ.Families[0];
        }
        /// <summary>
        /// 调用 马善政 字体
        /// </summary>
        /// <param name="FontSize">字体大小</param>
        /// <returns>字体</returns>
        public static Font MaShanZheng(Int32 FontSize)
        {
            if (MSZ == null)
                InitFont(ref MSZ, ResxClass.MaShanZheng);
            return new Font(MSZ.Families[0], FontSize);
        }
        #endregion
    }
}
