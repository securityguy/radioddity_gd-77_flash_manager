using System;
using System.Runtime.InteropServices;

namespace GD77_FlashManager
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	class PowerSettingData
	{
		public byte lowPower=0x00;
		public byte highPower=0x00;

		public PowerSettingData()
		{
			this.lowPower = 0;
			this.highPower = 0;
		}
	}

}
