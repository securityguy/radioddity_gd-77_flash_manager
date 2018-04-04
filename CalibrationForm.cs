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
			// Need to setup the VHF and UHF data storage class first, as its used when initialising the components
			int calibrationDataSize = Marshal.SizeOf(typeof(CalibrationData));
			byte[] array = new byte[calibrationDataSize];
			Array.Copy(MainForm.eeprom, 0x8F000, array, 0, calibrationDataSize);
			_uhfData = (CalibrationData)ByteToData(array);

			array = new byte[calibrationDataSize];
			Array.Copy(MainForm.eeprom, 0x8F070, array, 0, calibrationDataSize);
			_vhfData = (CalibrationData)ByteToData(array);

			InitializeComponent();
			this.calibrationBandControlVHF.data = this._vhfData;
			this.calibrationBandControlUHF.data = this._uhfData;
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

		private CalibrationData ByteToData(byte[] byte_0)
		{
			int num = Marshal.SizeOf(typeof(CalibrationData));
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(byte_0, 0, intPtr, num);
			object result = Marshal.PtrToStructure(intPtr, typeof(CalibrationData));
			Marshal.FreeHGlobal(intPtr);
			return (CalibrationData)result;
		}

		private void onFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}
