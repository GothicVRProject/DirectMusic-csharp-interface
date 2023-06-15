using System;
using System.Runtime.InteropServices;

namespace DMCs.Interface
{
    public static class DMMusic
    {
        private const string DLLNAME = DMDMusic.DLLNAME;

        [DllImport(DLLNAME)] public static extern IntPtr DMusicInitMusic();
        [DllImport(DLLNAME)] public static extern void DMusicFreeMusic(IntPtr m);
        [DllImport(DLLNAME)] public static extern void DMusicAddPattern(IntPtr music, IntPtr pattern);
    }
}