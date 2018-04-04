using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GD77_FlashManager
{
	public partial class CalibrationBandControl : UserControl
	{

		private CalibrationData _calibrationData;

		public CalibrationBandControl()
		{
			InitializeComponent();
		}

		public CalibrationData data
		{
			get 
			{
				_calibrationData.DACOscRefTune				= (ushort)this.nudVhfOscRef.Value;
				_calibrationData.MuteNormalWidebandOpen1	= (byte)this.nudSquelchWideNormOpen.Value;
				_calibrationData.MuteNormalWidebandClose1	= (byte)this.nudSquelchWideNormClose.Value;
				_calibrationData.MuteStrictWidebandOpen1	= (byte)this.nudSquelchWideTightOpen.Value;
				_calibrationData.MuteStrictWidebandClose1	= (byte)this.nudSquelchWideTightClose.Value;
				_calibrationData.MuteNormalNarrowbandOpen1	= (byte)this.nudSquelchNarrowNormOpen.Value;
				_calibrationData.MuteNormalNarrowbandClose1 = (byte)this.nudSquelchNarrowNormClose.Value;
				_calibrationData.MuteStrictNarrowbandOpen1	= (byte)this.nudSquelchNarrowTightOpen.Value;
				_calibrationData.MuteStrictNarrowbandClose1 = (byte)this.nudSquelchNarrowTightClose.Value;
				_calibrationData.ReceiveAGCGainTarget		= (byte)this.nudReceiveAGCTarget.Value;
				_calibrationData.MicGainAnalog				= (byte)this.nudAnalogMicGain.Value;
				return _calibrationData; 
			}
			set 
			{ 
				_calibrationData = value;

				this.nudVhfOscRef.Value					= _calibrationData.DACOscRefTune;
				this.nudSquelchWideNormOpen.Value		= _calibrationData.MuteNormalWidebandOpen1;
				this.nudSquelchWideNormClose.Value		= _calibrationData.MuteNormalWidebandClose1;
				this.nudSquelchWideTightOpen.Value		= _calibrationData.MuteStrictWidebandOpen1;
				this.nudSquelchWideTightClose.Value		= _calibrationData.MuteStrictWidebandClose1;
				this.nudSquelchNarrowNormOpen.Value		= _calibrationData.MuteNormalNarrowbandOpen1;
				this.nudSquelchNarrowNormClose.Value	= _calibrationData.MuteNormalNarrowbandClose1;
				this.nudSquelchNarrowTightOpen.Value	= _calibrationData.MuteStrictNarrowbandOpen1;
				this.nudSquelchNarrowTightClose.Value	= _calibrationData.MuteStrictNarrowbandClose1;
				this.nudReceiveAGCTarget.Value			= _calibrationData.ReceiveAGCGainTarget;
				this.nudAnalogMicGain.Value				= _calibrationData.MicGainAnalog;
			}
		}
	}
}
