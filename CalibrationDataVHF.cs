using System;
using System.Runtime.InteropServices;

namespace GD77_FlashManager
{
	class CalibrationDataVHF
	{
		// Changing any of them reduced the Tx power to virtually nothing
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] UnknownBlock1 = { 0x50, 0x05, 0xCC, 0x06, 0x50, 0x05, 0xCC, 0x06 };

		public UInt16 DACOscRefTune = 0x03E8;// 	DAC word for frequency reference oscillator

		public byte Unknown9 = 0xE9;// VHF data has 0xEE in this value

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] // Array of 8 pairs of bytes (Low and High power settings)
		public PowerSettingData[] PowerSettings;// 136Mhz, then 140MHz -  165Mhz in steps of 5Mhz, then 172Mhz

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public byte[] UnknownBlock2;// All these contain 0xFF so are probably not used. 

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] UnknownBlock3 = { 0x40, 0xF0, 0x40, 0xF0, 0x40, 0xF0 };// Possibly 4 uint16 words

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public byte[] UnknownBlock4;// All these contain 0xFF so are probably not used. 

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] // Digital mic gain ( possibly MBE Equalisation )
		public byte[] MicGainDigital = { 0x0F, 0x0F, 0x0F, 0x1B, 0x1B, 0x1B };

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public byte[] UnknownBlock5;// All these contain 0xFF so are probably not used. 

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
		public byte[] UnknownBlock6 = { 0x00, 0x00, 0x00, 0x00, 0x1D, 0x1D, 0x1D, 0x1C, 0x1C, 0x1C, 0x1B, 0x1B };


		// = {0x3E, 0x3C, 0x3D, 0x3A, 0x53, 0x51, 0x34, 0x32, 0x34, 0x32, 0x53, 0x51 };
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

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] TXIandQ;// 136Mhz , 140Mhz - 165Mhz, 172Mhz 

		public byte UnknownBlock7;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] VHFDeviationControl;// 136Mhz , 140Mhz - 165Mhz, 172Mhz . Bits 0-4 conbined deviation, bit 5 CTCSS?DCS deviation, bits 6:7 DCS only deviation

		public byte MicGainAnalog;// Both wide and narrow band
		public byte ReceiveAGCGainTarget; // Receiver AGC target. Higher values give more gain. Reducing this may improve receiver overload with strong signals, but would reduce sensitivity

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] UnknownBlock8 = { 0x27, 0x00, 0x27, 0x00, 0x0F, 0x0F, 0x00, 0x00 };
	}
}
