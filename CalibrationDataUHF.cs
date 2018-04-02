using System;
using System.Runtime.InteropServices;

namespace GD77_FlashManager
{

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	class CalibrationDataUHF
	{
		// UHF data is stored at address 0x8f000 in the external Flash chip in the GD-77

		// Looks like this may be 4 pairs of bytes rather than 8 separate bytes
		// Changing any of them reduced the Tx power to virtually nothing
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] UnknownBlock1 = { 0xA0, 0x0F, 0xC0, 0x12, 0xA0, 0x0F, 0xC0, 0x12 };

		public UInt16 DACOscRefTune = 0x03E8;// 	DAC word for frequency reference oscillator

		public byte Unknown9 = 0xEE;// Seems similar to the UHF value of E9

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] // Array of 16 pairs of bytes (Low and High power settings)
		public PowerSettingData[] PowerSettings;// = {{0x83,0xc6},{0x,0x},{0x,0x},{0x,0x},{0x,0x},{0x,0x},{0x,0x},{0x,0x}};// 400 to 475 in 5Mhz stps (16 steps)


		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
		public byte[] UnknownBlock2 = { 0x3D, 0x3B, 0x3A, 0x38, 0x37, 0x36, 0x35 }; // Not sure what these do, but they all start with 0x03 

		public byte UnknownBlock3 = 0xA9;		// This byte may be related to those 7 bytes above, but its value is radically different

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] // Digital mic gain ( possibly MBE Equalisation )
		public byte[] MicGainDigital = {0x1D,0x0D,0x0D,0x11,0x11,0x0B,0x0B,0x0F } ;

		public byte MicGainAnalog = 0x31;		// Analogue mic gain (both wide and narrow band) - Higher values give more gain
		
		public byte ReceiveAGCGainTarget = 0x05; // Receiver AGC target. Higher values give more gain. Reducing this may improve receiver overload with strong signals, but would reduce sensitivity


		// This may not really be a block of 8 bytes. It looks like 2 x 16 bit values e.g. 2700 (or 0027) and then 4 more possibly unrelated bytes
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] UnknownBlock4 = { 0x27, 0x00, 0x27, 0x00, 0x0F, 0x0E, 0x00, 0x00 };
	}
}




