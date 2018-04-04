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
	public partial class CalibrationPowerControl : UserControl
	{
		private CalibrationNUDLabelControl[] _powerBandControls = new CalibrationNUDLabelControl[16];
		/*
		public CalibrationNUDLabelControl [] data
		{
			set
			{
				for (int i = 0; i < 16; i++)
				{
					_powerBandControls[i] = value[i];
				}
			}
			get
			{
				return _powerBandControls;
			}
		}*/
		public CalibrationPowerControl()
		{
			InitializeComponent();
			_powerBandControls[0] = calibrationNUDLabelControl1;
			_powerBandControls[1] = calibrationNUDLabelControl2;
			_powerBandControls[2] = calibrationNUDLabelControl3;
			_powerBandControls[3] = calibrationNUDLabelControl4;
			_powerBandControls[4] = calibrationNUDLabelControl5;
			_powerBandControls[5] = calibrationNUDLabelControl6;
			_powerBandControls[6] = calibrationNUDLabelControl7;
			_powerBandControls[7] = calibrationNUDLabelControl8;
			_powerBandControls[8] = calibrationNUDLabelControl9;
			_powerBandControls[9] = calibrationNUDLabelControl10;
			_powerBandControls[10] = calibrationNUDLabelControl11;
			_powerBandControls[11] = calibrationNUDLabelControl12;
			_powerBandControls[12] = calibrationNUDLabelControl13;
			_powerBandControls[13] = calibrationNUDLabelControl14;
			_powerBandControls[14] = calibrationNUDLabelControl15;
			_powerBandControls[15] = calibrationNUDLabelControl16;
		}
	}
}
