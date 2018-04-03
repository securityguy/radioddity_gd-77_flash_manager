using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace GD77_FlashManager
{
	public partial class CalibrationForm : Form
	{
		private CalibrationData _vhfData;
		private CalibrationData _uhfData;

		public CalibrationForm()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Feature in development");
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private CalibrationData ByteToData(byte[] byte_0, Type type_0)
		{
			int num = Marshal.SizeOf(type_0);
			if (num > byte_0.Length)
			{
				throw new ArgumentException();
			}
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(byte_0, 0, intPtr, num);
			object result = Marshal.PtrToStructure(intPtr, type_0);
			Marshal.FreeHGlobal(intPtr);
			return (CalibrationData)result;
		}

		private void onFormLoad(object sender, EventArgs e)
		{
			
			int calibrationDataSize = Marshal.SizeOf(typeof(CalibrationData));
			byte[] array = new byte[calibrationDataSize];
			Array.Copy(MainForm.eeprom, 0x8F000, array, 0, calibrationDataSize);
			_uhfData = (CalibrationData)ByteToData(array, typeof(CalibrationData));
			
			array = new byte[calibrationDataSize];
			Array.Copy(MainForm.eeprom, 0x8F070, array, 0, calibrationDataSize);
			_vhfData = (CalibrationData)ByteToData(array, typeof(CalibrationData));

//VHF Values
			this.nudVhfOscRef.Value= _vhfData.DACOscRefTune;
			
			this.nudVhfSquelchWideNormOpen.Value = _vhfData.MuteNormalWidebandOpen1;
			this.nudVhfSquelchWideNormClose.Value = _vhfData.MuteNormalWidebandClose1;
			this.nudVhfSquelchWideTightOpen.Value = _vhfData.MuteStrictWidebandOpen1;
			this.nudVhfSquelchWideTightClose.Value = _vhfData.MuteStrictWidebandClose1;
			this.nudVhfSquelchNarrowNormOpen.Value = _vhfData.MuteNormalNarrowbandOpen1;
			this.nudVhfSquelchNarrowNormClose.Value = _vhfData.MuteNormalNarrowbandClose1;
			this.nudVhfSquelchNarrowTightOpen.Value = _vhfData.MuteStrictNarrowbandOpen1;
			this.nudVhfSquelchNarrowTightClose.Value = _vhfData.MuteStrictNarrowbandClose1;



//UHF Values
			this.nudUhfOscRef.Value = _uhfData.DACOscRefTune;

			this.nudUhfSquelchWideNormOpen.Value = _uhfData.MuteNormalWidebandOpen1;
			this.nudUhfSquelchWideNormClose.Value = _uhfData.MuteNormalWidebandClose1;
			this.nudUhfSquelchWideTightOpen.Value = _uhfData.MuteStrictWidebandOpen1;
			this.nudUhfSquelchWideTightClose.Value = _uhfData.MuteStrictWidebandClose1;
			this.nudUhfSquelchNarrowNormOpen.Value = _uhfData.MuteNormalNarrowbandOpen1;
			this.nudUhfSquelchNarrowNormClose.Value = _uhfData.MuteNormalNarrowbandClose1;
			this.nudUhfSquelchNarrowTightOpen.Value = _uhfData.MuteStrictNarrowbandOpen1;
			this.nudUhfSquelchNarrowTightClose.Value = _uhfData.MuteStrictNarrowbandClose1;


			Console.Write("Done");
		}

		private void label10_Click(object sender, EventArgs e)
		{

		}
	}
}
