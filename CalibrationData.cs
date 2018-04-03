using System;
using System.Runtime.InteropServices;

namespace GD77_FlashManager
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	class CalibrationData
	{
		// Changing any of them reduced the Tx power to virtually nothing
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] UnknownBlock1;// Uknown. Changing any of these values causes Tx power to drop to virtuially zero

		public UInt16 DACOscRefTune;// 	DAC word for frequency reference oscillator

		public byte UnknownBlock2; // Unkown byte E9 on UHF EE on VHF

		/* Power settings
		 * UHF 400 to 475 in 5Mhz stps (16 steps)
		 * VHF 136Mhz, then 140MHz -  165Mhz in steps of 5Mhz, then 172Mhz  (8 steps - upper 8 array entries contain 0xff )
		 */
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
		public PowerSettingData[] PowerSettings;// 

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] UnknownBlock3;// Unkown

		/*
		 * Digital mic gain ( possibly MBE Equalisation )
		 * Note. 
		 * UHF appears to have 8 bytes of data, 
		 * VHF only seems to use the first 6 bytes as the last 2 contain 0xff which is totally different from the values in the first 6 bytes
		 */
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
		public byte[] MicGainDigital;// Note 

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] UnknownBlock4;// Seems to contain 0x00 on both VHF and UHF. Potentially unused

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] UnknownBlock5;// Different values on VHF and UHF byt all in the range 0x12 - 0x1D



		public byte MuteStrictWidebandClose1;
		public byte MuteStrictWidebandOpen1;
		public byte MuteStrictWidebandClose2;
		public byte MuteStrictWidebandOpen2;

		public byte MuteNormalWidebandClose1;
		public byte MuteNormalWidebandOpen1;

		public byte MuteStrictNarrowbandClose1;
		public byte MuteStrictNarrowbandOpen1;
		public byte MuteStrictNarrowbandClose2;
		public byte MuteStrictNarrowbandOpen2;

		public byte MuteNormalNarrowbandClose1;
		public byte MuteNormalNarrowbandOpen1;

		public byte RSSILowerThreshold;
		public byte RSSIUpperThreshold;

		/*
		 * VHF 136Mhz , 140Mhz - 165Mhz (in 5Mhz steps), 172Mhz 
		 * UHF 405Mhz - 475Mhz (in 10Mhz steps)
		 */
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] TXIandQ;

		public byte UnknownBlock6;// 0x1D on VHF and UHF

		/*
		 * VHF 136Mhz , 140Mhz - 165Mhz (in 5Mhz steps), 172Mhz 
		 * UHF 405Mhz - 475Mhz (in 10Mhz steps)
		 */
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] DeviationControl;// 136Mhz , 140Mhz - 165Mhz, 172Mhz . Bits 0-4 conbined deviation, bit 5 CTCSS?DCS deviation, bits 6:7 DCS only deviation

		public byte MicGainAnalog;// Both wide and narrow band
		public byte ReceiveAGCGainTarget; // Receiver AGC target. Higher values give more gain. Reducing this may improve receiver overload with strong signals, but would reduce sensitivity

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] UnknownBlock7;
	}
}
