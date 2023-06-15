using System;
using System.Runtime.InteropServices;

namespace DMCs.Interface
{
    public static class DMDirectMusic
    {
        private const string DLLNAME = DMDMusic.DLLNAME;

        [DllImport(DLLNAME)] public static extern IntPtr DMusicInitDirectMusic();
        [DllImport(DLLNAME)] public static extern void DMusicFreeDirectMusic(IntPtr dm);
        [DllImport(DLLNAME)] public static extern IntPtr DMusicLoadFile(IntPtr dm, string filename, int size);
        [DllImport(DLLNAME)] public static extern IntPtr DMusicLoadSegment(IntPtr dm, IntPtr s);
        [DllImport(DLLNAME)] public static extern void DMusicAddPath(IntPtr dm, string path);
        [DllImport(DLLNAME)] public static extern IntPtr DMusicGetPath(IntPtr dm);



    }
}
