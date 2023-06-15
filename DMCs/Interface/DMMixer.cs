using System;
using System.Runtime.InteropServices;

namespace DMCs.Interface
{
    public static class DMMixer
    {
        private const string DLLNAME = DMDMusic.DLLNAME;

        [DllImport(DLLNAME)] public static extern IntPtr DMusicInitMixer();
        [DllImport(DLLNAME)] public static extern void DMusicFreeMixer(IntPtr mixer);
        [DllImport(DLLNAME)] public static extern void DMusicSetVolume(IntPtr mixer, float volume);
        [DllImport(DLLNAME)] public static extern void DMusicSetMusicVolume(IntPtr mixer, float volume);
        [DllImport(DLLNAME)] public static extern void DMusicMix(IntPtr mixer, [In, Out] short[] output, uint samples);

        [DllImport(DLLNAME)] public static extern void DMusicSetMusic(IntPtr mixer, IntPtr music, int embellishment = 0);
    }
}
