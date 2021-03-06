﻿namespace Unosquare.RaspberryIO.Native
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// OS uname structure
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    internal struct utsname
    {
        /// <summary>
        /// System name
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string sysname;
        /// <summary>
        /// Node name
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string nodename;
        /// <summary>
        /// Release level
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string release;
        /// <summary>
        /// Version level
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string version;
        /// <summary>
        /// Hardware level
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string machine;
        /// <summary>
        /// Domain name
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string domainname;
    }
}
