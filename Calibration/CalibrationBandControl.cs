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
		private string _type="";

		public CalibrationBandControl()
		{
			InitializeComponent();
		}

		public string Type
		{
			get
			{
				return _type;
			}
			set
			{
				_type = value;
				string[] oneToEight = { "1", "2", "3", "4", "5", "6", "7", "8" };
				this.calibrationDigitalMicGain.Names = oneToEight;
				this.calibrationTXIandQ.Names = oneToEight;
				this.calibrationDeviationControl.Names = oneToEight;
				switch(_type)
				{
					case "VHF":
						{
							calibrationPowerControlHigh.Cols = 8;
							calibrationPowerControlLow.Cols = 8;
							string[] freqBandNames = { "136","140","145","150","155","160","165","172"};
							calibrationPowerControlLow.Names = freqBandNames;
							calibrationPowerControlHigh.Names = freqBandNames;

						}
						break;
					case "UHF":
						{
							calibrationPowerControlHigh.Cols = 16;
							calibrationPowerControlLow.Cols = 16;
							string[] freqBandNames = { "400", "405", "410", "415", "420", "425", "430", "435", "440", "445", "450", "455", "460", "465", "470", "475" };
							calibrationPowerControlLow.Names = freqBandNames;
							calibrationPowerControlHigh.Names = freqBandNames;
						}
						break;
				}
			}
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
				_calibrationData.RSSILowerThreshold			= (byte)this.nudSMeterLow.Value;
				_calibrationData.RSSIUpperThreshold			= (byte)this.nudSMeterHigh.Value;

				_calibrationData.MuteStrictWidebandOpen2 = _calibrationData.MuteStrictWidebandOpen1;
				_calibrationData.MuteStrictWidebandClose2 = _calibrationData.MuteStrictWidebandClose1;
				_calibrationData.MuteStrictNarrowbandOpen2 = _calibrationData.MuteStrictNarrowbandOpen1;
				_calibrationData.MuteStrictNarrowbandClose2 = _calibrationData.MuteStrictNarrowbandClose1;


				// Power
				int numItems = calibrationPowerControlLow.Rows * calibrationPowerControlLow.Cols;
				for (int i = 0; i < numItems; i++)
				{
					_calibrationData.PowerSettings[i].lowPower  = (byte)calibrationPowerControlLow.Values[i];
					_calibrationData.PowerSettings[i].highPower = (byte)calibrationPowerControlHigh.Values[i];
				}

				// Digital \mic gain
				numItems = calibrationDigitalMicGain.Rows * calibrationDigitalMicGain.Cols;
				for (int i = 0; i < numItems; i++)
				{
					_calibrationData.MicGainDigital[i] = (byte)calibrationDigitalMicGain.Values[i];
				}

				// TX I & Q
				numItems = calibrationTXIandQ.Rows * calibrationTXIandQ.Cols;
				for (int i = 0; i < numItems; i++)
				{
					_calibrationData.TXIandQ[i] = (byte)calibrationTXIandQ.Values[i];
				}


				// Deviation control
				numItems = calibrationDeviationControl.Rows * calibrationDeviationControl.Cols;
				for (int i = 0; i < numItems; i++)
				{
					_calibrationData.DeviationControl[i] = (byte)calibrationDeviationControl.Values[i];
				}

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
				this.nudSMeterLow.Value					= _calibrationData.RSSILowerThreshold;
				this.nudSMeterHigh.Value				= _calibrationData.RSSIUpperThreshold;

				// Power
				int numItems = calibrationPowerControlLow.Rows * calibrationPowerControlLow.Cols;
				int[] lowPower = new int[numItems];
				int[] highPower = new int[numItems];
				for (int i = 0; i < numItems; i++)
				{
					lowPower[i] = _calibrationData.PowerSettings[i].lowPower;
					highPower[i] = _calibrationData.PowerSettings[i].highPower;
				}
				calibrationPowerControlLow.Values = lowPower;
				calibrationPowerControlHigh.Values = highPower;

				// Digital mic gain
				numItems = calibrationDigitalMicGain.Rows * calibrationDigitalMicGain.Cols;
				int[] micGainDigital = new int[numItems];
				for (int i = 0; i < numItems; i++)
				{
					micGainDigital[i] = _calibrationData.MicGainDigital[i];
				}
				calibrationDigitalMicGain.Values = micGainDigital;

				// TX I & Q
				numItems = calibrationDigitalMicGain.Rows * calibrationDigitalMicGain.Cols;
				int[] txIAndQ = new int[numItems];
				for (int i = 0; i < numItems; i++)
				{
					txIAndQ[i] = _calibrationData.TXIandQ[i];
				}
				calibrationTXIandQ.Values = txIAndQ;

				// Deviation control
				numItems = calibrationDeviationControl.Rows * calibrationDeviationControl.Cols;
				int[] deviationControl = new int[numItems];
				for (int i = 0; i < numItems; i++)
				{
					deviationControl[i] = _calibrationData.DeviationControl[i];
				}
				this.calibrationDeviationControl.Values = deviationControl;


			}
		}

	}
}
